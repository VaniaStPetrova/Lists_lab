using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lineOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> solution = new List<int>();

            for (int i = 0; i < lineOfDigits.Count; i++)
            {
                if (Math.Sqrt(lineOfDigits[i]) == (int)Math.Sqrt(lineOfDigits[i]))
                {
                    solution.Add(lineOfDigits[i]);
                }
            }

            solution.Sort();
            solution.Reverse();

            Console.WriteLine(string.Join(" ", solution));
        }
    }
}
