using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace EnDPoINT
{
    class Log
    {
        private static Log instance;
        private bool isSetup;
        private int _logLevel;
        private String _logFile;

        private Log() 
        {
            this.isSetup = false;
        }

        public static Log Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Log();
                }
                return instance;
            }
        }

        public void setupLog(String file, int loglevel)
        {
            this._logFile = file;
            this._logLevel = loglevel;
            isSetup = true;
        }

        public void log(int loglevel, String source, String message)
        {
            if (!isSetup || loglevel < this._logLevel || this._logLevel == 0)
            {
                return;
            }
            DateTime now = DateTime.Now;
            File.AppendAllText(this._logFile, now.ToString() + ": " + source + " - " + message + "\n");
        }
    }
}
