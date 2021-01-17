using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine($"{musteri.Ad} {musteri.Soyad} Eklendi!");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine($"{musteri.Ad} {musteri.Soyad} Silindi!");
        }
        public void Listele(Musteri[] musteriler)
        {
            int sayac = 1;
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine($"\n*********{sayac}.Muşteri**********");
                Console.WriteLine("Adı : "+musteri.Ad);
                Console.WriteLine("Soyadı : "+musteri.Soyad);
                Console.WriteLine("TC : "+musteri.Tc);
                Console.WriteLine("Telefon : "+musteri.Telefon);
                Console.WriteLine("E-posta : "+musteri.Eposta);
                sayac++;
            }
        }
    }
}
