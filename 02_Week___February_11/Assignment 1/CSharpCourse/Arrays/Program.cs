using System;

namespace Arrays
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string student1 = "Engin";
            string student2 = "Derin";
            string student3 = "Salih";


            string[] students = new string [3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            string[] students2 = { "Engin", "Derin", "Salih" };
            // students2[3] = "Ahmet"; // error 

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[7, 3]
            {
                // regions[0, 0] = "İstanbul";
                {"İstanbul","Bursa","Kocaeli"},
                {"Ankara","Konya","Kayseri"},
                {"Antalya","Adana","Mersin"},
                {"Samsun","Trabzon","Ordu"},
                {"İzmir","Manisa","Aydın"},
                {"Gaziantep","Diyarbakır","Şanlıurfa"},
                {"Erzurum","Van","Erzincan"}
            };


            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("*****");
            }
        
        }
    }
}