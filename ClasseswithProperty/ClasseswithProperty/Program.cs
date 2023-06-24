using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseswithProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Michael";
            customer1.LastName = "Eneramo";
            customer1.City = "Köln";
            //Console.WriteLine(customer1.FirstName);
            customer1.PrintInformation();

            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "Hakan",
                LastName = "Kutlu",
                City = "Bilecik"
            };
            customer1.PrintInformation();
            Console.ReadLine();
        }
        class Customer
        {
            public int Id { get; set; } // it keeps the features of classes - id-name-number...
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }

            public void PrintInformation()
            {
                Console.WriteLine(" Id : {0} \n First Name : {1} \n Last Name : {2} \n City : {3} ",Id,FirstName,LastName,City);
            }

        }
    }
}
