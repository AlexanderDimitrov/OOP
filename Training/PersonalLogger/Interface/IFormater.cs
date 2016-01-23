using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLogger.Interface
{
    public interface IFormater
    {
        string Format(string msg, ReportLevel level, DateTime date);
        
    }
}
