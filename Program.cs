using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 11111111111;
            musteri1.MusteriAdi = "Yıldız";
            musteri1.MusteriSoyadi = "Tilbe";
            musteri1.Yasi = 32;
            musteri1.Adres = "İstanbul";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 22222222222;
            musteri2.MusteriAdi = "Sezen";
            musteri2.MusteriSoyadi = "Aksu";
            musteri2.Yasi = 45;
            musteri2.Adres = "İzmir";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 33333333333;
            musteri3.MusteriAdi = "Haluk";
            musteri3.MusteriSoyadi = "Levent";
            musteri3.Yasi = 26;
            musteri3.Adres = "Ankara";

            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("Ekleme İşlemi İçin Bir Tuşa Basınız...");
            Console.ReadKey();
            musteriManager.Ekle(musteri1);
            Console.WriteLine("******************************************");
            Console.WriteLine("Listeleme İşlemi İçin Bir Tuşa Basınız...");
            Console.ReadKey();
            musteriManager.Listele(musteri2);
            Console.WriteLine("******************************************");
            Console.WriteLine("Silme İşlemi İçin Bir Tuşa Basınız...");
            Console.ReadKey();
            musteriManager.Sil(musteri3);

            Console.ReadLine();
        }
    }
}
