using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[4];
            students[0] = "Samet";
            students[1] = "John";
            students[2] = "Thiago";
            students[3] = "Mia";

            string[] students2 = { "Samet", "John", "Thiago","Mia" };

            foreach(var student in students)
            {
                Console.WriteLine(student);  
            }

            Console.ReadLine();
        }
    }
}
