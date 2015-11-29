using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_2.Enter_Numbers.Prop;

namespace Problem_2.Enter_Numbers
{
    class Program
    {
        private const int Count = 10;
        private const int StartNum = 1;
        private const int EndNum = 100;
        private static List<int> nums;
        static void Main(string[] args)
        {
            nums = new List<int>();
            while (nums.Count < Count)
            {
                try
                {
                    nums.Add(!nums.Any() ? ReadNumber(StartNum, EndNum) : ReadNumber(nums[nums.Count - 1], EndNum));
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.Error.WriteLine(Extentions.NOutOfRange, StartNum + 1, EndNum - 1);
                }
                catch (OverflowException)
                {
                    Console.Error.WriteLine(Extentions.NOverFlow);
                }
                catch (InfiniteLoopException)
                {
                    Console.Error.WriteLine(Extentions.Error,Count);
                    return;
                }
                catch (FormatException)
                {
                    Console.Error.WriteLine(Extentions.NoNumber);
                }
               

            }
        }
            private static int ReadNumber(int start, int end)
        {
            Console.Write(Extentions.Instert, start + 1, end - 1);
            int num = int.Parse(Console.ReadLine());

            if (num >= end || num <= start)
            {
                throw new ArgumentOutOfRangeException(string.Format(Extentions.NOutOfRange, start + 1, end - 1));
            }

            if (end - num < Count - nums.Count)
            {
                throw new InfiniteLoopException(string.Format(Extentions.Error, Count));
            }

            return num;
        }
    }
}
    

