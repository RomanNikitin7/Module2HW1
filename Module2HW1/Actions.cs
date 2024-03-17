using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logger
{
    internal class Actions
    {
        public Result Method1()
        {
            Logger.Instance.Log(LogType.Info, "Start method: Method1");
            return new Result() { Status = true };
        }
        public Result Method2()
        {
            Logger.Instance.Log(LogType.Warning, "Skipped logic in method: Method2");
            return new Result() { Status = true };
        }
        public Result Method3()
        {
            return new Result()
            {
                Status = false,
                ErrorMessage = "I broke a logic"
            };
        }
    }
}
