﻿using ClusterManagerServerLib;
using LogLib;
using ServerFrameWork;
using System;
using System.Threading;

namespace ClusterManagerServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Api api = new Api();
            AbstractServer api = new Api();
            try
            {
                api.Init(args);
            }
            catch (Exception e)
            {
                Log.Error("{0} init failed:{1}", api.ApiTag.GetServerTagString(), e.ToString());
                api.Exit();
                return;
            }

            Thread thread = new Thread(api.MainLoop);
            thread.Start();

            Log.Info("{0} OnReady..", api.ApiTag.GetServerTagString());

            while (thread.IsAlive)
            {
                api.ProcessInput();
                Thread.Sleep(1000);
            }

            api.Exit();
            Log.Info("{0} Exit..", api.ApiTag.GetServerTagString());
        }
    }
}
