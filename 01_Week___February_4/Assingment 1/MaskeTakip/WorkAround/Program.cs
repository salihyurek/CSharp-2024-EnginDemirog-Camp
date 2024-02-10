// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using Entities.Concrete;

class Program
{
    static void Main(string[] args)
    {
        // Degiskenler();

        Vatandas vatandas = new Vatandas();

        Console.WriteLine(vatandas.Ad);

        Selamver("Engin");
        Selamver("Ahmet");
        Selamver("Salih");
        Selamver();

        int sonuc = Topla(3,5);
        
        // Arrays // Diziler

        string ogrenci1 = "Engin";
        string ogrenci2 = "Berkay";
        string ogrenci3 = "Salih";

        Console.WriteLine(ogrenci1);
        Console.WriteLine(ogrenci2);
        Console.WriteLine(ogrenci3);
        
        string[] ogrenciler = new string[3];
        ogrenciler[0] = "Engin";
        ogrenciler[1] = "Berkay";
        ogrenciler[2] = "Salih";

        // reference types // Arrays, Class, Interface, Abstract, List // String?
        
        ogrenciler = new string[4]; // research Stack and heap // Garbage Collector 
        ogrenciler[3] = "İlker";

        string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
        string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

        sehirler2 = sehirler1;
        sehirler1[0] = "Adana";
        Console.WriteLine(sehirler2[0]);


        int sayi1 = 10;
        int sayi2 = 20;
        sayi2 = sayi1;
        sayi1 = 30;
        Console.WriteLine(sayi2); // value types // int, float, bool, double...

        Person person1 = new Person();
        person1.FirstName = "Salih";
        person1.LastName = "Yürek";
        person1.DateOfBirthYear = 1999;
        person1.NationalIdentity = 12345678910;

        Person person2 = new Person();
        person2.FirstName = "Murat";
        
        // Loops // Döngüler

        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }

        foreach (string sehir in sehirler1)
        {
            Console.WriteLine(sehir);
        }
        
        // List 

        List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
        yeniSehirler1.Add("Adana");

        foreach (string sehir in yeniSehirler1)
        { 
            Console.WriteLine(sehir);
        }

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1); 

    }

    static void Selamver(string isim = "isimsiz")
    {
        Console.WriteLine("Merhaba " + isim);
    }

    static int Topla(int sayi1 = 5, int sayi2 = 11) // default parametreler en sonra yazılır, aksi halde code hata verir 
    {
        int sonuc = sayi1 + sayi2;
        Console.WriteLine("Toplam " + sonuc);
        return sonuc;
    }

    private static void Degiskenler()
    {
        Console.WriteLine("Hello, World!");


        string mesaj = "Merhaba";
        double tutar = 100000; // database den gelir 
        int sayi = 100;
        bool girisYapmisMi = false;


        Console.WriteLine(tutar * 1.18);

        Console.WriteLine(mesaj);

        Console.WriteLine(mesaj);
    }

    // PascalCase
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public int DogumYili { get; set; }

        public long TcNo { get; set; }


        // string ad = "Salih";
        // string soyad = "Yürek";
        // int dogumYili = 1999;
        // long tcNo = 12345678910;
    }
}