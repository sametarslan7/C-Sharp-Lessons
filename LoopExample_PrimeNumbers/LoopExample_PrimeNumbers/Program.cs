using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LoopExample_PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(IsPrimeNumber(7))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not prime number");
            }
            Console.ReadLine();
        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for(int i=2;i<number;i++)
            {
                if(number%i==0)
                {
                    return false; break;
                }
            }
            return result; 
        }
    }
}
