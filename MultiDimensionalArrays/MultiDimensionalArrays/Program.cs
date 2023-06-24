using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[,] region = new string[5, 3]
            {
                {"İstanbul","İzmit","Balıkesir" },
                {"Ankara","Kayseri","Sivas" },
                {"Rize","Gümüşhane","Samsun" },
                {"İzmir","Aydın","Manisa" },
                {"Antalya","Adana","Mersin" }
            };
            for(int i=0;i<=region.GetUpperBound(0);i++)
            {
                for(int j=0;j<=region.GetUpperBound(1);j++)
                {
                    Console.WriteLine(region[i, j]);
                }
                Console.WriteLine("--------");
            }
            Console.ReadLine();
            
        }
    }
}
