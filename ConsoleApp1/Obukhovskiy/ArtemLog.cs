using ConsoleApp1.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Obukhovskiy
{
    class ArtemLog : LogAbstract, LogInterface
    {
        private static ArtemLog i = null;

        public static ArtemLog I()
        {
            if (i == null)
            {
                i = new ArtemLog();
            }

            return i;
        }

        private ArtemLog() { }

        List<string> logs = new List<string>();

        public LogInterface log(string str)
        {
            logs.Add(str);
            return this;
        }

        public LogInterface write()
        {
            writeConsole(logs.ToArray());
            return this;
        }
    }
}
