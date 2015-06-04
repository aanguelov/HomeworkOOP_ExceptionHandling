using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SquareRoot
{
    class SquareRootMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to find its square root:");

            try
            {
                uint number = uint.Parse(Console.ReadLine());
                Console.WriteLine(CalcSquareRoot(number));
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number, the number must be non-negative!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number, input must be a number!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }    
        }

        private static int CalcSquareRoot(uint anyNumber)
        {
            uint square = anyNumber * anyNumber;
            return (int)square;
        }
    }
}
