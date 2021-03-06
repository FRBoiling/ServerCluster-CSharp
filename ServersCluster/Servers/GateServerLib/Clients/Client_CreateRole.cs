﻿using LogLib;
using Protocol.Client.C2G;
using Protocol.Gate.G2WM;
using System.IO;

namespace GateServerLib
{
    public partial class Client
    {
        private void OnResponse_CreateRole(MemoryStream stream, int uid)
        {
            MSG_C2G_CreateRole msg = ProtoBuf.Serializer.Deserialize<MSG_C2G_CreateRole>(stream);
            Log.Debug("recv user {0} create role name {1} ", _authMgr.Username,msg.Name);

            //1 检查名字合法性 包括：屏蔽字，串长，重名等等
            //2 如合法，通过WorldManagerServer获取角色ID
            MSG_G2WM_CreateRoleId requestMsg = new MSG_G2WM_CreateRoleId();
            requestMsg.Username = _authMgr.Username;
            
            //3 收到WorldManagerServer返回ID后。进行创角步骤
        }


    }
}
