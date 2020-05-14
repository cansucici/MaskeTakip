using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            // degiskenler();
            // Vatandas vatandas1 = new Vatandas();

            int sonuc = Topla(3, 5);

            SelamVer(isim: "cansu");
            SelamVer(isim: "c");
            SelamVer(isim: "cccc");
            SelamVer();

            //diziler  / Arrays 

          //  string ogrenci1 = "engin";
          //  string ogrenci2 = "kerem";
          //  string ogrenci3 = "berkay";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "engin";
            ogrenciler[1] = "kerem";
            ogrenciler[2] = "berkay";
            ogrenciler = new string[4];

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }


            string[] sehirler1 = new[] { "ankara", "istanbul", "izmir" };
            string[] sehirler2 = new[] { "bursa", "antalya", "diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "adana";
            Console.WriteLine(sehirler2[0]);



            Person person1 = new Person();
            person1.FirstName = "cansu";
            person1.LastName = "Demiroğ";
            person1.NationalIdentity = 123;
            person1.DateOfBirthYear = 1995;


            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "ank", "izmir", "ist" };
            yeniSehirler1.Add("blk");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }



            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi2 = sayi1;


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


            Console.ReadLine();
        }

        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("merhaba" + isim);
        }

        static int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam" + sonuc);
            return sonuc;
        }

    }
}

//        pr  ivate static void degiskenler()
//        {
//            string mesaj = "selam";
//            double tutar = 100000;
//            bool girisYapildiMi = false;

//            string ad = "Cansu";
//            string soyad = "CİCİ";
//            int dogumYili = 1995;
//            long tcNo = 12345678910;


//            Console.WriteLine(tutar * 1.18);
//        }
//    }


//    public class Vatandas
//    {
//        //public string ad = "Cansu";
//        //public string soyad = "CİCİ";
//        //public int dogumYili = 1995;
//        //public long tcNo = 12345678910;

//        public string Ad { get; set; }
//        public string Soyad { get; set; }
//        public int DogumYili { get; set; }
//        public long TcNo { get; set; }
//    }

