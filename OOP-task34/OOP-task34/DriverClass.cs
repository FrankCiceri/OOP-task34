using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPtask34
{
    internal class DriverClass
    {

        public static void Main(string[] args) {


            while (true) {

                Console.WriteLine("Enter a number, press 0 to exit");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 0) break;
                Fibonacci.displayFibonacci(number);
                Console.WriteLine();
                Fibonacci.displayFibonacciRecursive(number);
                Console.WriteLine();



            }


        }
    }
}
