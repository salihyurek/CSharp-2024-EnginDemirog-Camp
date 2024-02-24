using System;

namespace Loops
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // ForLoop();
            // WhileLoop();
            // DoWhileLoops();
            // ForEachLoop();

            if (IsPrimeNumber(2))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }

        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }

        private static void ForEachLoop()
        {
            string[] students = new string[3] {"Engin", "Derin","Salih"};
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoops()
        {
            int number = 10;

            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >  0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
        }

        private static void ForLoop()
        {
            //    initial    condition  increment 
            for (int i = 100; i >= 0; i-=2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Finished!");
        }
    }
}