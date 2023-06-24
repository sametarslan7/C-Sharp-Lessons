using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = "Miami";
            //Console.WriteLine(city[0]);//it means get the first letter of city value
            
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "London";

            Console.WriteLine("{0} {1} ",city,city2);//it means , sum of 2 string expression

            Console.ReadLine();


        }
    }
}
