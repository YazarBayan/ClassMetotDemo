using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Id Eklendi: " + musteri.Id);
            Console.WriteLine("Müşteri İsmi Eklendi: " + musteri.MusteriAdi);
            Console.WriteLine("Müşteri Soyadı Eklendi: " + musteri.MusteriSoyadi);
            Console.WriteLine("Müşteri Yaşı Eklendi: " + musteri.Yasi);
            Console.WriteLine("Müşteri Adresi Eklendi: " + musteri.Adres);

        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("{0} nolu Müşteri Bilgileri: ",musteri.Id);
            Console.WriteLine("Ad: "+"\t"+musteri.MusteriAdi+"\n"+"Soyad: "+ "\t" + musteri.MusteriSoyadi+"\n" +"Yaş: "+ "\t" + musteri.Yasi+"\n" +"Adres: "+ "\t" + musteri.Adres);

        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("{0} nolu Müşteri Bilgileri Silindi ", musteri.Id);
        }
    }
}
