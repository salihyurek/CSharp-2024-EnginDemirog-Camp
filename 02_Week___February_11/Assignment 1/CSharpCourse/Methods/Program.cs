using System;
using System.Linq;

namespace Methods
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Add();
            // var result = Add2(3, 5);
            // Console.WriteLine(result);
            // Console.WriteLine(Add2(4));

            // int number1 = 20;
            // int number2 = 100;
            //
            // var result2 = Add3(out number1, number2);
            // Console.WriteLine(result2);
            // Console.WriteLine(number1);
            
            Console.WriteLine(Multiplay(3,4));
            Console.WriteLine(Multiplay(6,8,2));
            
            Console.WriteLine(Add4(2,3,4,5,6,7));
            
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2 = 30) // int number = 30 for // default value
        {
            return number1 + number2;
        }

        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiplay(int number1, int number2)
        {
            return number1 * number2;
        }
        
        static int Multiplay(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(int number1, params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}