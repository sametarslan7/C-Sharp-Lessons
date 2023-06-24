using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = {"Apple","Banana","StrawBerry","Orange","Cherry","Peach","Apricot" };
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.ReadLine();
        }
    }
}
