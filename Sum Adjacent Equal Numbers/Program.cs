using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> lineOfDigits = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int i = 1; i < lineOfDigits.Count; i++)
            {
                if (lineOfDigits[i] == lineOfDigits[i - 1])
                {
                    lineOfDigits[i] += lineOfDigits[i];
                    lineOfDigits.RemoveAt(i - 1);
                    i = 0;
                }
            }

            Console.WriteLine(string.Join(" ", lineOfDigits));
        }
    }
}
