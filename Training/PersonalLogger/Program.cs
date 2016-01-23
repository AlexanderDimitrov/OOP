using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLogger
{
    using Formater;
    using Interface;
    class Program
    {
        static void Main(string[] args)
        {
            IFormater formetter = new SimpleFormatter();
            IAppender appender = new FileAppender("file.txt",formetter); 
            Logger logger = new Logger(appender);
            logger.Critical("Out of Memmory");
            logger.Info("Unused local Variable");
        }
    }
}
