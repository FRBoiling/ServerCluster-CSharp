﻿using Protocol.BattleManager.BM2CM;
using ServerFrameWork;
using System;
using TcpLib;

namespace BattleManagerServerLib
{
    public class CMServer : AbstractTcpClient
    {
        ServerInfo _serverTag = new ServerInfo();
        Api _api = null;
        public ServerInfo ServerTag
        {
            get { return _serverTag; }
            set { _serverTag = value; }
        }

        public CMServer(Api api, string ip, ushort port)
            : base(ip, port)
        {
            _api = api;
            _serverTag.Type = ServerType.ClusterManager;
        }

        protected override void ConnectedComplete()
        {
                Console.WriteLine("connected to {0} ip {1} port {2}"
                    , ServerTag.Type,Ip,Port);
                RequsetRegister();
        }
        protected override void ReConnectedComplete()
        {
            Console.WriteLine("re connected to {0}", ServerTag.Type);
        }
        protected override void DisconnectComplete()
        {
            Console.WriteLine("switch off from {0}"
                , ServerTag.Type);
        }

        protected override void BindResponser()
        {
            
        }

        public void RequsetRegister()
        {
            Console.WriteLine("Requst Register to {0}", ServerTag.Type);
            MSG_BM2CM_REGISTER requset = new MSG_BM2CM_REGISTER();
            requset.GroupId = _api.ApiTag.GroupId;
            requset.SubId = _api.ApiTag.SubId;
            Send(requset);
        }

        protected override void ProcessLogic()
        {
            throw new NotImplementedException();
        }
    }
}
