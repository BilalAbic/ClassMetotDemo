using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri()
            {
                Id = 1,
                Ad = "Ali",
                Soyad = "Demir",
                Tc = "00000000000",
                Eposta = "alidemir@gmail.com",
                Telefon = "+905758569678"
            };
            Musteri musteri2 = new Musteri()
            {
                Id = 2,
                Ad = "Ateş",
                Soyad = "Sönmez",
                Tc = "00000000000",
                Eposta = "alidemir@gmail.com",
                Telefon = "+905757485678"
            };
            Musteri musteri3 = new Musteri()
            {
                Id = 3,
                Ad = "Fatih",
                Soyad = "Buralı",
                Tc = "00000000000",
                Eposta = "alidemir@gmail.com",
                Telefon = "+9057584034"
            };
            Musteri musteri4 = new Musteri()
            {
                Id = 4,
                Ad = "Hüseyin",
                Soyad = "Aydın",
                Tc = "00000000000",
                Eposta = "huseyin@ziraat.com",
                Telefon = "+901158560758"
            };
            Musteri musteri5 = new Musteri()
            {
                Id = 5,
                Ad = "Hicran",
                Soyad = "Atak",
                Tc = "00000000000",
                Eposta = "hicranatak9@gmail.com",
                Telefon = "+905751111678"
            };
            Musteri musteri6 = new Musteri()
            {
                Id = 6,
                Ad = "Erdal",
                Soyad = "Ateş",
                Tc = "00000000000",
                Eposta = "erdalates@gmail.com",
                Telefon = "+905799999678"
            };
            MusteriManager managermusteri = new MusteriManager();
            Musteri[] musteris = new Musteri[]
            {
                musteri1,musteri2,musteri3,musteri4,musteri5,musteri6
            };
            Console.WriteLine("\n------------Musteri Listeleme Sayfası----------");
            managermusteri.Listele(musteris);
            Console.WriteLine("\n------------Musteri Ekleme Sayfası----------");
            managermusteri.Ekle(musteri4);
            Console.WriteLine("\n------------Musteri Silme Sayfası----------");
            managermusteri.Sil(musteri6);
        }
    }
}
