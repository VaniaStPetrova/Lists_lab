using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            numbers.Sort();

            List<int> specificDigit = new List<int>();

            List<int> repeatedTimes = new List<int>();

            bool isLastElementPrinted = false;

            int count = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    count++;
                    if (i == numbers.Count - 1)
                    {
                        specificDigit.Add(numbers[i - 1]);
                        repeatedTimes.Add(count);
                        count = 1;
                        isLastElementPrinted = true;
                    }
                }
                else
                {
                    specificDigit.Add(numbers[i - 1]);
                    repeatedTimes.Add(count);
                    count = 1;
                }
            }

            for (int cycle = 0; cycle < specificDigit.Count; cycle++)
            {
                Console.WriteLine("{0} -> {1}", specificDigit[cycle], repeatedTimes[cycle]);
            }

            if (!isLastElementPrinted)
            {
                Console.WriteLine("{0} -> 1", numbers[numbers.Count - 1]);
            }
        }
    }
}
