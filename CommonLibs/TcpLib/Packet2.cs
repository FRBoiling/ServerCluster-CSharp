﻿using System;
using System.Collections.Generic;
using System.IO;
using Engine.Foundation;
using ProtoBuf;

namespace TcpLib
{
    public class Packet2: AbstractParsePacket
    {
        private class PacketInfo
        {
            public const int Size = 10;
            public Int32 Uid;
            public UInt32 MsgId;
            public MemoryStream Msg;
            public PacketInfo(UInt32 msgId, Int32 uid = 0)
            {
                MsgId = msgId;
                Uid = uid;
            }
        }

        private Queue<PacketInfo> m_msgQueue = new Queue<PacketInfo>();
        private Queue<PacketInfo> m_deal_msgQueue = new Queue<PacketInfo>();

        public override int UnpackPacket(MemoryStream stream)
        {
            byte[] buffer = stream.GetBuffer();
            int offset = 0;
            int pos = 0;
            while (stream.Length > sizeof(UInt16))
            {
                UInt16 size = BitConverter.ToUInt16(buffer, offset);
                offset += sizeof(UInt16);
                if (size > stream.Length - offset)
                {
                    break;
                }

                UInt32 msg_id = BitConverter.ToUInt32(buffer, offset);
                offset += sizeof(UInt32);
                Int32 uid = BitConverter.ToInt32(buffer, offset);
                offset += sizeof(Int32);

                PacketInfo packet = new PacketInfo(msg_id, uid);

                byte[] content = new byte[size];
                Array.Copy(buffer, offset, content, 0, size);
                packet.Msg = new MemoryStream(content, offset, size, true, true);

                lock (m_msgQueue)
                {
                    m_msgQueue.Enqueue(packet);
                }
                offset += size;
                pos = offset;
            }

            return offset;
        }

        public override void Process()
        {
            lock (m_msgQueue)
            {
                while (m_msgQueue.Count > 0)
                {
                    var msg = m_msgQueue.Dequeue();
                    m_deal_msgQueue.Enqueue(msg);
                }
            }
            while (m_deal_msgQueue.Count > 0)
            {
                var msg = m_deal_msgQueue.Dequeue();
                Process(msg.MsgId,msg.Msg, msg.Uid);
            }
        }

        public override void PackPacket<T>(T msg, out MemoryStream head, out MemoryStream body)
        {
            body = new MemoryStream();
            ProtoBuf.Serializer.Serialize(body, msg);

            head = new MemoryStream(sizeof(ushort) + sizeof(uint));
            ushort len = (ushort)body.Length;
            head.Write(BitConverter.GetBytes(len), 0, 2);
            head.Write(BitConverter.GetBytes(Id<T>.Value), 0, 4);
        }

        public override void PackPacket<T>(T msg, int uid, out MemoryStream head, out MemoryStream body)
        {
            throw new NotImplementedException();
        }

        public override int CryptoUnpackPacket(MemoryStream stream)
        {
            throw new NotImplementedException();
        }
    }
}
