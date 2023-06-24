using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while(number<=20)
            {
                Console.WriteLine(number);
                number++;
            }
            Console.ReadLine();
        }
    }
}
