using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalLogger;

namespace PersonalLogger.Interface
{
    public interface IAppender
    {
        IFormater Formatter { get; set; }
        void Append(string message,ReportLevel level,DateTime date);
    }
}
