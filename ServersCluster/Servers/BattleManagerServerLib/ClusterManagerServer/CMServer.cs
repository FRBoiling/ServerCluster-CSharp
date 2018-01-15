﻿using Message.BattleManager.ClusterManager.Protocol.BM2CM;
using ServerFrameWork;
using System;
using System.Collections.Generic;
using System.IO;
using TcpLib;

namespace BattleManagerServerLib
{
    public class CMServer : AbstractTcpClient
    {
        ServerTag _serverTag = new ServerTag();
        Api _api = null;
        public ServerTag ServerTag
        {
            get { return _serverTag; }
            set { _serverTag = value; }
        }

        public CMServer(Api api, string ip, ushort port)
            : base(ip, port)
        {
            _api = api;
            _serverTag.Type = ServerType.ClusterManager;
            BindResponser();
            InitTcp();
        }

        protected override void ConnectedComplete(bool ret)
        {
            if (ret)
            {
                Console.WriteLine("connected to {0}"
                    , ServerTag.Type);
                RequsetRegister();
            }
            else
            {
                Console.WriteLine("connect failed, connect to {0} ip {4} port {5} again"
                    , ServerTag.Type, ServerTag.GroupId, ServerTag.SubId,Ip,Port);
            }
        }

        protected override void DisconnectComplete()
        {
            Console.WriteLine("switch off from {0}" 
                , ServerTag.Type);
        }

        public override void Update()
        {
            OnProcessProtocal();
        }

        public delegate void Responseer(MemoryStream stream);
        private Dictionary<uint, Responseer> _responsers = new Dictionary<uint, Responseer>();

        public void AddResponser(uint id, Responseer responser)
        {
            _responsers.Add(id, responser);
        }

        protected override void Response(uint id, MemoryStream stream)
        {
            Responseer responser = null;
            if (_responsers.TryGetValue(id, out responser))
            {
                responser(stream);
            }
            else
            {
                Console.WriteLine("got unsupported packet {0} from {1}",
                    id, ServerTag.GetServerTagString());
            }
        }

        public void BindResponser()
        {
        }

        public void RequsetRegister()
        {
            Console.WriteLine("Requst Register to {0}"
               , ServerTag.Type);
            MSG_BM2CM_REGISTER requset = new MSG_BM2CM_REGISTER();
            requset.GroupId = _api.ApiTag.GroupId;
            requset.SubId = _api.ApiTag.SubId;
            Send(requset);
        }


    }
}
