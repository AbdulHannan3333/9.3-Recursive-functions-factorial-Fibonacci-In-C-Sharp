using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3_Recursive_functions__factorial__Fibonacci_
{
    internal class Program
    {
        static int Factorial(int n) 
        {
            if (n == 0 || n==1) 
            { 
                return 1; 
            } 
            return n *Factorial(n-1);
        }

        static int Fibonacci(int n)
        {
            if (n <= 1) 
            { 
                return n; 
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine($"Factorial of {n}: {Factorial(n)}");
            Console.WriteLine($"Fibonacci of {n}: {Fibonacci(n)}");
        }
    }
}
