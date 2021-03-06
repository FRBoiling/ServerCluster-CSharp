﻿using DataParserLib;
using LogLib;
using System;
using System.Collections.Generic;
using System.IO;
using UtilityLib;

namespace ServerFrameWork
{
    public enum ServerState
    {
        Disconnect = 0,
        Connected = 1,
        Starting = 2,
        Running = 3,
        Stopping = 4,
        Stopped = 5
    }
    public abstract class AbstractServer
    {
        ServerInfo _apiTag = new ServerInfo();
        public ServerInfo ApiTag
        {
            get { return _apiTag; }
        }

        //private Mode _startMode;
        //public Mode StartMode
        //{
        //    get { return _startMode; }
        //    set { _startMode = value; }
        //}

        /// <summary>
        /// 预存当前时间
        /// </summary>
        private static DateTime _now;
        public static DateTime Now
        {
            get { return _now; }
            set { _now = value; }
        }


        /// <summary>
        /// 运行标示
        /// </summary>
        bool _isRuning;
        public bool IsRuning
        {
            get { return _isRuning; }
            set { _isRuning = value; }
        }

        /// <summary>
        /// 帧数
        /// </summary>
        FrameControl _fpsCtrl;
        public FrameControl FpsCtrl
        {
            get { return _fpsCtrl; }
            set { _fpsCtrl = value; }
        }

        /// <summary>
        /// 当前状态
        /// </summary>
        ServerState _state;
        public ServerState State
        {
            get { return _state; }
            set { _state = value; }
        }

        /// <summary>
        /// 服务器关闭时间
        /// </summary>
        DateTime _serverStopTime;
        public DateTime ServerStopTime
        {
            get { return _serverStopTime; }
            set { _serverStopTime = value; }
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="args"></param>
        public void Init(string[] args)
        {
            if (args.Length >= 2)
            {
                ApiTag.GroupId = ushort.Parse(args[0]);
                ApiTag.SubId = ushort.Parse(args[1]);
            }
            //log最先初始化
            InitLogger();
            //StartMode = Mode.Auto;
            InitPath();
            InitXmlData();
            InitServer();
        }

        /// <summary>
        /// 退出
        /// </summary>
        public void Exit()
        {
            ExitServer();
        }

        /// <summary>
        /// 初始化路径
        /// </summary>
        private void InitPath()
        {
            PathExt.InitPath();
            Log.Info("InitPath successed");
        }

        /// <summary>
        /// 初始化LOG系统
        /// </summary>
        private void InitLogger()
        {
            var logger = new ConsoleLogger();
            logger.Init(true,@"..\Log\", _apiTag.GetServerTagString());
            logger.SetLogo(_apiTag.GetServerKey());
#if DEBUG
            logger.SetPriority(4);
#else
            logger.SetPriority(2);
#endif
            Log.InitLog(logger);
            Log.Info("InitLogger successed");
        }

        /// <summary>
        /// 初始化XML数据
        /// </summary>
        private void InitXmlData()
        {
            string[] files = Directory.GetFiles(PathExt.FullPathFromData("XML"), "*.xml", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                XmlDataManager.Inst.Parse(file);
            }
            Log.Info("InitXmlData successed");
        }

        /// <summary>
        /// 主循环
        /// </summary>
        public void MainLoop()
        {
            IsRuning = true;
            FpsCtrl = new FrameControl();
            FpsCtrl.Init();
            while (IsRuning)
            {
                Now = FpsCtrl.SetFrameBegin();
                Process();
                ProccessCmd();
                if (State == ServerState.Stopping)
                {
                    if (ServerStopTime < Now)
                    {
                        State = ServerState.Stopped;
                        Console.WriteLine("{0} stopped!", ApiTag.Type.ToString());
                        //LOG.Error("{0} stopped!", ServerName);
                    }
                }
                FpsCtrl.SetFrameEnd();
            }
        }

        /// <summary>
        /// 初始化模块
        /// </summary>
        /// <param name="args"></param>
        protected abstract void InitServer();

        /// <summary>
        /// 退出
        /// </summary>
        public abstract void ExitServer();

        /// <summary>
        /// 执行
        /// </summary>
        protected abstract void Process();


        /// <summary>
        /// 处理GM命令 没有后台 临时用控制台输入替代
        /// </summary>
        protected Queue<string> _cmdList = new Queue<string>();
        /// <summary>
        /// 输入
        /// </summary>
        public void CmdInput()
        {
            try
            {
                string cmd = Console.ReadLine().ToLower().Trim();
                lock (_cmdList)
                {
                    _cmdList.Enqueue(cmd);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
                //LOG.Error(e.ToString());
            }
        }

        private void ProccessCmd()
        {
            lock (_cmdList)
            {
                while (_cmdList.Count > 0)
                {
                    try
                    {
                        string cmd = _cmdList.Dequeue();
                        ExcuteCmd(cmd);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
            }
        }
        protected abstract void ExcuteCmd(string cmd);

    }
}
