using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPtask34
{
    public class Fibonacci{

      


        public static void displayFibonacci(int number) {
            int fn2 = 1;
            int fn1 = 0;            
            int fn = 0;
            Console.Write(fn1 + " ");
            Console.Write(fn2 + " ");
            while (fn < number) 
            {
                fn = fn1 + fn2;

                fn1 = fn2;
                fn2 = fn;
                if (fn <= number) {
                    Console.Write(fn + " ");
                }
               

            }       


        }

        public static void displayFibonacciRecursive(int number, int fn1=0,int fn2=1)
        {

           if (fn1 == 0) {
                Console.Write($"{fn1} {fn2} ");  
            }
            int fn = fn1 + fn2;
            fn1 = fn2;
            fn2 = fn;
            if (fn <= number) {
                Console.Write(fn + " ");
                displayFibonacciRecursive(number, fn1, fn2);
            }
        }
                
    }
}
