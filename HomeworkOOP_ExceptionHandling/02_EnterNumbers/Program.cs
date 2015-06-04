using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int previous = 0;
            for (int i = 0; i < 10; i++)
            {
                int inputNumber = ReadNumber(1, 100);

                if (i > 0)
                {
                    if (!IsBigger(inputNumber,previous))
                    {
                        Console.WriteLine("Give it another try!");
                        i--;
                        inputNumber = previous;
                    }
                }
                previous = inputNumber;
            }
        }

        static int ReadNumber(int start, int end)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < start || number > end)
            {
                throw new ArgumentOutOfRangeException("Number not in range!");
            }
            return number;
        }
        static bool IsBigger(int current, int previous)
        {
            bool isBigger = false;
            if (current > previous)
            {
                isBigger = true;
            }
            return isBigger;
        }
    }
}
