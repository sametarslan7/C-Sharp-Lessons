using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWtihParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = Add(10, 20);
            Console.WriteLine("Result : " + result);
            Console.ReadLine();
        }
        static int Add(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }
    }
}
