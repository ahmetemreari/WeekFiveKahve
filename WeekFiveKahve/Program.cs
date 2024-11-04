using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            //liste oluştur
            List<string> kahveListesi = new List<string>();
            //konsol girdisi al
            Console.WriteLine("Lütfen 5 kahve ismi giriniz:");

            for (int i = 0; i < 5; i++)
            {
                //alınan dataları listeye ekle
                Console.Write($"Kahve {i + 1}: ");
                string kahveIsmi = Console.ReadLine();
                kahveListesi.Add(kahveIsmi);
                //sayı değilse hata ver
                if (int.TryParse(kahveIsmi, out int sayi))
                {
                    Console.WriteLine("Hatalı giriş yaptınız. Lütfen kahve ismi giriniz.");
                    i--;
                }
            }
            //listeyi tek satırda yazdır
            Console.WriteLine("\nGirdiğiniz kahve isimleri: " + String.Join(", ", kahveListesi));

            // menüye dönmek için seçenek sun
            //Console.WriteLine("\nMenüye dönmek için 'e' tuşuna basın, çıkmak için herhangi bir tuşa basın.");
            //char secim = Console.ReadKey().KeyChar;
            //if (secim != 'e' && secim != 'E')
           // {
           //     break;
           // }
            //Console.Clear();
        }
    }
}