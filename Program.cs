using System;
using System.Collections.Generic;
namespace proje_odev // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
           
           List<int> sayilistesi=new List<int>();
           sayilistesi.Add(23);
           sayilistesi.Add(10);
           sayilistesi.Add(4);
           sayilistesi.Add(9);
           sayilistesi.Add(17);
           List<string> renk_liste=new List<string>();
           renk_liste.Add("red");
           renk_liste.Add("blue");
           renk_liste.Add("green");
           Console.WriteLine(sayilistesi.Count());
           Console.WriteLine(renk_liste.Count());
           foreach (var sayi in sayilistesi)
           {
            Console.WriteLine(sayi);
           }
           foreach (var renk in renk_liste)
           {
            Console.WriteLine(renk);
           }
           sayilistesi.ForEach(sayi=>Console.WriteLine(sayi));
           renk_liste.ForEach(renk=>Console.WriteLine(renk));
           //listeden eleman çıkarma
           sayilistesi.Remove(4);
           renk_liste.Remove("blue");
           
            sayilistesi.RemoveAt(0);
             sayilistesi.ForEach(sayi=>Console.WriteLine(sayi));
           renk_liste.ForEach(renk=>Console.WriteLine(renk));
           //liste içerisinde arama
           if(sayilistesi.Contains(10))
           Console.WriteLine("10 var");
           //eleman ile indexe erişmek
           Console.WriteLine(renk_liste.BinarySearch("red"));
           //diziyi listeçevirme
           string[] animals={"kedi","köpek","kuş"};
            List<string> animals_list=new List<string>(animals);
            foreach (var animal in animals_list)
           {
            Console.WriteLine(animal);
           }
           //listeyi nasıl temizleriz
           animals_list.Clear();
           //liste içerisinde nesne tutmak
           List<kullnici> kullanici_list=new List<kullnici>();
           kullnici kln=new kullnici();
           kln.Isim="test";
           kln.Soyisim="deneme";
           kln.Yas=25;

           kullnici kln2=new kullnici();
           kln2.Isim="t2";
           kln2.Soyisim="d2";
           kln2.Yas=30;
           kullanici_list.Add(kln);
           kullanici_list.Add(kln2);
           //listeye kullnici atama işlemi başka nasıl yapılır yeni bir kullanıcı listesi oluşturalım
            List<kullnici> yeniliste=new List<kullnici>();
            yeniliste.Add(new kullnici(){
                Isim="ayse",
                Soyisim="aaaa",
                Yas=15
            });
            foreach (var kullanici in kullanici_list)
            {
                Console.WriteLine("kullanici adi"+kullanici.Isim);
                Console.WriteLine("kullanici soyadi"+kullanici.Soyisim);
                Console.WriteLine("kullanici yas"+kullanici.Yas);
            }
            yeniliste.Clear();

         }
         public class kullnici
         {
             private string isim;
             private string soyad;
             private int yas;
             public string Isim{get=>isim; set=>isim=value;}
             public string Soyisim{get=>soyad; set=>soyad=value;}
             public int Yas{get=>yas; set=>yas=value;}

         }

    }
}
