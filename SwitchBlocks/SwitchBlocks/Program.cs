using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchBlocks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade=70;

            switch(grade)
            {
                case 50:
                    Console.WriteLine("Your grade is FF");
                    break;
                case 70:
                    Console.WriteLine("Your grade is BB");
                    break;
                case 90:
                    Console.WriteLine("Your grade is AA");
                    break;
                default:
                    Console.WriteLine("Grade is not valid.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
