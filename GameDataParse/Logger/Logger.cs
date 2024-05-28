using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParse.Logger
{
    public class Logger
    {
        public void LogException(Exception ex)
        {
            string logMsg = Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine + ex.Message + Environment.NewLine + ex.StackTrace + Environment.NewLine;
            File.AppendAllText("log.txt", logMsg);
        }
    }
}
