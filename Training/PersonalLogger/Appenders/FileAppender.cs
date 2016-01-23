using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLogger.Interface
{
    using Appenders;
    public class FileAppender:Appenders,IAppender
    {
        public FileAppender(string path,IFormater formater):base(formater)
        {
            this.Formatter = formater;
            this.Path = path;
        }
        
        public string Path { get; set; }
        
        public void Append(string message,ReportLevel level,DateTime date)
        {
            StreamWriter writer = new StreamWriter(this.Path,true);

            string output = this.Formatter.Format(message, level, date);
            writer.WriteLine(output);
            writer.Close();
        }
    }
}
