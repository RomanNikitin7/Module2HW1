using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logger
{
    internal class Starter
    {
        public void Run()
        {
            var random = new Random();

            for (int i = 0; i < 100; i++)
            {
                var actions = new Actions();
                Result result = null;
                switch (random.Next(1, 4))
                {
                    case 1:
                        result = actions.Method1();
                        break;
                    case 2:
                        result = actions.Method2();
                        break;  
                    case 3:
                        result = actions.Method3();
                        break;
                }

                if (result != null && !result.Status)
                {
                    Logger.Instance.Log(LogType.Error, "Action failed by a reason:" + result.ErrorMessage);
                }
            }

            File.WriteAllText("log.txt", Logger.Instance.GetLogString());
        }
    }
}
