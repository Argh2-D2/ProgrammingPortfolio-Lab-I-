﻿using System;

namespace L1._5_SayMyName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string myName = Console.ReadLine();
            Console.WriteLine("Hello " + myName + "!");
        }
    }
}
