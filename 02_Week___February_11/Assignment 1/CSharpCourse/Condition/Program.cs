﻿using System;

namespace Condition
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var number = 10;
            // if (number == 10)
            // {
            //     Console.WriteLine("Number is 10");
            // }
            // else if (number == 20)
            // {
            //     Console.WriteLine("Number is 20");
            // }
            // else
            // {
            //     Console.Write("Number is not 10");
            // }
            //
            // Console.Write(number == 10 ? "number is 10" : "number is not 10");

            // switch (number)
            // {
            //     case 10:
            //         Console.Write("Number is 10");
            //         break;
            //     case 20:
            //         Console.WriteLine("Number is 20");
            //         break
            //     default:
            //         Console.WriteLine("Number is not 10 or 20"); 
            //         break;
            // }

            // if (number >= 0 && number <= 100)
            // {
            //     Console.WriteLine("Number is between 0-100");
            // }
            // else if (number > 100 && number <= 200)
            // {
            //     Console.WriteLine("Number is between 101-200");
            // }
            // else if (number > 200|| number < 0)
            // {
            //     Console.WriteLine("Number is less than 0 or grater than 200");
            // }

            if (number < 100)
            {
                if (number >= 90 && number < 95)
                {
                    Console.WriteLine("Number is between 90-95");
                }
            }
            
            
            
            
            Console.ReadLine();    
        }
    }
}