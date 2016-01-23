using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLogger.Appenders
{
    using Interface;
    public abstract class Appenders
    {
        private IFormater formatter;
        public Appenders(IFormater formatter)
        {
            this.Formatter = formatter;
        }
        public IFormater Formatter
        {
            get { return this.formatter; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Formatter cannot be null");
                }
                this.formatter = value;
            }
        }

    }
}

