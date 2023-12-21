using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOef1LoggerLogic
{

    public sealed class Logger
    {
        private static Logger _instantie = null;

        public static Logger GetInstance
        {
            get
            {
                if (_instantie == null)
                {
                    _instantie = new Logger();
                }
                return _instantie;
            }
        }

        public void Log(string message)
        {
            File.AppendAllText(Directory.GetCurrentDirectory() + "\\Log_Test.txt", $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} {message}\n");
       
        }
    }
}
