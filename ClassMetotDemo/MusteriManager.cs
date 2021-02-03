using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi : " + musteri.Adi + " " + musteri.Soyadi);
            Console.WriteLine("------------------------------------------------------------");
        }
        public void MusteriListeleme(Musteri musteri)
        {
            Console.WriteLine("Müşterinin Id si : " + musteri.MusteriId);
            Console.WriteLine("Müşterinin Adı : " + musteri.Adi);
            Console.WriteLine("Müşterinin Soyadı : " + musteri.Soyadi);
            Console.WriteLine("Müşterinin Şehri : " + musteri.Sehri);
            Console.WriteLine("Müşterinin Telefon Numarası : " + musteri.TelefonNumarasi);
            Console.WriteLine("------------------------------------------------------------");
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi.");
            Console.WriteLine("------------------------------------------------------------");
        }
    }
}
