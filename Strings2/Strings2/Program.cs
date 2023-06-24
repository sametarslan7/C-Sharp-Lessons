using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My name is John McKeny";

            var result = sentence.Length;//it gives us , how many letter the sentence has  with space caracters.
            Console.WriteLine(result);

            bool result2 = sentence.EndsWith("a");//it means , is the expression ends with a letter
            bool result3 = sentence.StartsWith("m");//it means, is the sentence starts with m letter

            var result4 = sentence.ToLower();// every letter will be lowercase
            var result5 = sentence.ToUpper();// every letter will be uppercase

            var result6 = sentence.Replace(" ","/");// it means , every " " caracter (space) replace with / 
            Console.WriteLine(result6);



            Console.ReadLine();


        }
    }
}
