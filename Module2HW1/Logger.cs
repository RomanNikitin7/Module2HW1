using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logger
{
    internal class Logger
    {
        private static readonly Logger instance = new Logger();
        private LinkedList<string> _data = new LinkedList<string>();
        private int _dataIndex = 0;

        static Logger()
        {
        }

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                return instance;
            }
        }

        public void Log(LogType type, string message)
        {
            string entity = DateTime.Now.ToShortTimeString() + ": " + type + ": " + message;
            _data.AddLast(entity);
        }

        public LinkedList<string> GetLog()
        {
            return _data;
        }

        public string GetLogString()
        {
            var log = Logger.Instance.GetLog();
            var resultString = "";
            foreach (string write in log)
            {
                resultString += write + "\n";
            }

            return resultString;
        }
    }
}
