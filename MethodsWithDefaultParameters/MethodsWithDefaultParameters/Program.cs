using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithDefaultParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result=multiple(50);
            Console.WriteLine("Result : " + result);
            Console.ReadLine();
        }

        //this mean , if number2 will not give, we will accept to the default value.
        static int multiple(int number1,int number2=10)
        {
            var multiplication = number1 * number2;
            return multiplication;
        }

    }
}
