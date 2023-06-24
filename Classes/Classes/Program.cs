﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager firstCustomer = new CustomerManager();
            firstCustomer.Add();
            firstCustomer.Update();

            Console.ReadLine();
        }
        class CustomerManager
        {
            public void Add()
            {
                Console.WriteLine("Customer Added");
            }
            public void Update()
            {
                Console.WriteLine("Customer Updated");
            }
        }
    }
}
