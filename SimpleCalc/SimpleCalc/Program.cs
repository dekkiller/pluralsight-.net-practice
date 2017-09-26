using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            Console.WriteLine("Enter function to do: Add, Subtract");
            var userFunction = Console.ReadLine();

            if (userFunction.ToLower() == "add")
            {
                Console.WriteLine("Enter the first number to add.");
                var numberOne = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second numnber to add.");
                var numberTwo = Int32.Parse(Console.ReadLine());
                Console.WriteLine(AddNumbers(numberOne, numberTwo));
            }
            else if (userFunction.ToLower() == "subtract")
            {
                Console.WriteLine("Enter the first number to sub from.");
                var numberOne = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second numnber to subtract from number 1.");
                var numberTwo = Int32.Parse(Console.ReadLine());
                Console.WriteLine(SubtractNumbers(numberOne, numberTwo));
            }

            Console.ReadKey();
        }

        private static int AddNumbers(int numberOne, int numberTwo)
        {
            Console.WriteLine();
            var calcResult = numberOne + numberTwo;
            return calcResult;
        }

        private static int SubtractNumbers(int numberOne, int numberTwo)
        {
            Console.WriteLine();
            var calcResult = numberOne - numberTwo;
            return calcResult;
        }
    }
}
