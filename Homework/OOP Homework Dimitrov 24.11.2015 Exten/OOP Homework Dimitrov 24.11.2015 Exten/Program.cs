using System;
using Problem1.Exception;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomNumber = Console.ReadLine();
            try
            {
                uint.Parse(randomNumber);
                uint number = Convert.ToUInt32(randomNumber);
                Console.WriteLine(Math.Sqrt(number));
            }
            catch(ArgumentOutOfRangeException)
            {
                throw new ArgumentException(string.Format(Exeptions.Negative));
                
            }
            catch(OverflowException)
            {
                throw new ArgumentException(string.Format(Exeptions.Negative));
            }
            finally
            {
                
                Console.WriteLine("Good bye");
            }
        }
    }
}
