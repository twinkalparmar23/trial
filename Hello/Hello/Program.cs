﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name:");
            string name = Console.ReadLine();

            Console.WriteLine("how many hours of sleep did you get last night??");
            int hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello " + name);

            if (hours > 8)
            {
                Console.WriteLine("well rested...");
            }
            else
            {
                Console.WriteLine("You need more sleep..");
            }


        }
    }
}