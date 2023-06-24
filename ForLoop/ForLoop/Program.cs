using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
             //print the numbers 1 to 100 with for loop
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
             //print the odd numbers 1 to 100 with for loop
            for (int i = 1; i <= 100; i+=2)
            {
                Console.WriteLine(i);
            }
             //print the even numbers 0 to 100 with for loop
            for(int i = 0;i <= 100; i+=2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
