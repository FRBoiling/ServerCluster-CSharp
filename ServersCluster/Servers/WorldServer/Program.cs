﻿using ServerFrameWork;
using System;
using System.Threading;
using WorldServerLib;

namespace WorldServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Api api = new Api();
            AbstractServer api = new Api();
            try
            {
                api.ApiTag.Type = ServerType.World;
                api.Init(args);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} init failed:{1}", api.ApiTag.Type, e.ToString());
                api.Exit();
                return;
            }

            Thread thread = new Thread(api.MainLoop);
            thread.Start();

            Console.WriteLine("{0} OnReady..", api.ApiTag.GetServerTagString());

            while (thread.IsAlive)
            {
                api.ProcessInput();
                Thread.Sleep(1000);
            }

            api.Exit();
            Console.WriteLine("{0} Exit..", api.ApiTag.GetServerTagString());
        }
    }
}
