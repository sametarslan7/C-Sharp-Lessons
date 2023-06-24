using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Addition : "+Addition(10,20));
            Console.WriteLine("Second Addition  : "+Addition(50,100,80));
            Console.WriteLine("Third Addition(Params Notation) : " + Addition(10, 250, 650, 14, 283));
            Console.ReadLine();
        }

        static int Addition(int number1,int number2)
        {
            return number1 + number2;
        }

        //if we will add another parameter for a method, we can create another method with another name but also we can write the same method and add the parameter in this same method . 
        //This called  by Method Overloading 
        static int Addition(int number1,int number2,int number3)
        {
            return number1 + number2 + number3;
        }

        //params notation : we can also multiply 4 parameters, 5 parameters ...
        //but we can't create same method with same name but new parameters repeteadly.
        //we should the params notation.With params notation we can give parameters how many we want

        static int Addition(params int[] numbers)
        {
            return numbers.Sum();//sum is a default function.
        }
    }
}
