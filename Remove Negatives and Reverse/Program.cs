using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < listOfDigits.Count; i++)
            {
                if (listOfDigits[i] < 0)
                {
                    listOfDigits.RemoveAt(i);
                    i--;
                }
            }

            listOfDigits.Reverse();

            if (listOfDigits.Count > 0)
            {
                Console.WriteLine(string.Join(" ", listOfDigits));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
