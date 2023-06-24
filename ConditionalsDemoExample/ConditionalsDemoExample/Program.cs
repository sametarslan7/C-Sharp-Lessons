using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsDemoExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int speed, limit;
            speed = 120;
            limit = 100;

            if (speed < limit)
            {
                Console.WriteLine("Your speed isn't over the limit");
            }
            else if (speed == limit)
            {
                Console.WriteLine("Your speed is equal to the limit.Be Careful!");
            }
            else
            {
                Console.WriteLine("Your speed is over the limit.Please slow down!");
            }
            Console.ReadLine();
        }
    }
}
