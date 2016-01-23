using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLogger.Interface
{ 
    using Appenders;

    using PersonalLogger;
    public class ConsoleAppender:Appenders,IAppender
    {
        public ConsoleAppender(IFormater formatter):base(formatter)
        {
          
        }
       
        public void Append(string message,ReportLevel level,DateTime date)
        {
            string output = this.Formatter.Format(message, level, date);
            Console.WriteLine(output);
        }
    }
}
