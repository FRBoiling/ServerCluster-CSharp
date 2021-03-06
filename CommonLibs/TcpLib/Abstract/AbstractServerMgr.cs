﻿using LogLib;
using System;
using System.Collections.Generic;
using TcpLib.TcpSrc;
using UtilityLib;

namespace TcpLib
{
    public abstract class AbstractServerMgr
    {
        private List<AbstractTcpServer> _connectedServers = new List<AbstractTcpServer>();
        private object _allServersLock = new object();

        private Dictionary<string, AbstractTcpServer> _servers = new Dictionary<string, AbstractTcpServer>();
        private List<AbstractTcpServer> _removeServers = new List<AbstractTcpServer>();
      

        public AbstractServerMgr()
        {
        }

        public void Bind(ushort port, int backLog)
        {
            TcpMgr.Inst.Bind(port, backLog);
        }

        public void Listen(ushort port)
        {
            TcpMgr.Inst.Listen(port, InitListen);
        }

        protected abstract void InitListen(ushort port);

        public void Process()
        {
            lock (_allServersLock)
            {
                foreach (var item in _connectedServers)
                {
                    try
                    {
                        item.Process();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
            }
            if (_removeServers.Count > 0)
            {
                foreach (var item in _removeServers)
                {
                    _connectedServers.Remove(item);
                }
                _removeServers.Clear();
            }
        }

        public void AddAccpetServer(AbstractTcpServer server)
        {
            if (server == null)
            {
                Log.Error("AddAccpet server failed:server is null");
                return;
            }
            else
            {
                lock (_allServersLock)
                {
                    _connectedServers.Add(server);
                }
            }
        }

        public void RemoveServer(AbstractTcpServer server)
        {
            if (server == null)
            {
                Log.Error("RemoveServer server failed:server is null");
                return;
            }
            else
            {
                lock (_allServersLock)
                {
                    if (_connectedServers.Contains(server))
                    {
                        _connectedServers.Remove(server);
                        _servers.Remove(server.Key);
                    }
                }
            }
        }

        public bool AddServer(AbstractTcpServer server)
        {
            if (server == null)
            {
                Log.Error("add server failed: server is null");
                return false;
            }
            else
            {
                AbstractTcpServer temp;
                if (_servers.TryGetValue(server.Key, out temp))
                {
                    _removeServers.Add(server);
                    Log.Warn("{0}_{1} repeated add !", temp.Name, temp.Key);
                    return false;
                }
                else
                {
                    Log.Debug("{0}_{1} add success ! ", server.Name, server.Key);
                    _servers.Add(server.Key, server);
                    return true;
                }

            }
        }


    }
}
