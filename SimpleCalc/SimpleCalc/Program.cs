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
            sum = AddNumbers(62, 34);
            Console.WriteLine(sum);
            Console.WriteLine(AddNumbers(-1,10));
            Console.ReadKey();
        }

        private static int AddNumbers(int numberOne, int numberTwo)
        {
            var calcResult = numberOne + numberTwo;
            return calcResult;
        }
    }
}
