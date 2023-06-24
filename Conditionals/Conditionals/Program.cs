using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 110;
            if (number >= 0 && number <= 50)
            {
                Console.WriteLine("Number is between 0-50");
            }
            else if (number > 50 && number <= 70)
            {
                Console.WriteLine("Number is between 50-70");
            }
            else if (number > 70 && number<=100)
            {
                Console.WriteLine("number is between 70-100");
            }
            else
            {
                Console.WriteLine("Number is not between 0-100");
            }
            Console.ReadLine();
        }
    }
}
