﻿namespace LogLib
{
    public enum LogType
    {
        ERROR = 0,
        WARN = 1,
        INFO = 2,
        WRITE = 3,  //只写到console，普通的write
        DEBUG = 4  //只在debug时候
    }
}
