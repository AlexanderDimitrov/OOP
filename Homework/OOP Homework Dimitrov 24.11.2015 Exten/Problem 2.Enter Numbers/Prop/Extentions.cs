using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Enter_Numbers.Prop
{
    internal class Extentions
    {
        internal const string NOutOfRange = "Number should be in range [{0}..{1}]";
        internal const string NOverFlow = "Number is too large ot too small to fit fit in 32bit integer,please try again :)";
        internal const string Error = "You won't finish mate.Sorry \nGood Bye";
        internal const string Instert = "Number should be in range [{0}...{1}]";
        internal const string NoNumber = "This is nothing close to a number :).Go play again";
        internal const string YouDidIt = "You made it!!!You win a smile on the radio with those numbers >>{{{0}}}";

    }
    internal class InfiniteLoopException : Exception
    { 
        public InfiniteLoopException(string msg)
        : base(msg)
        {
        }
    }
}
