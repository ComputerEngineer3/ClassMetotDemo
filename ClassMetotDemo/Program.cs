using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.Adi = "Ad1";
            musteri1.Soyadi = "Soyad1";
            musteri1.Sehri = "Sehir1";
            musteri1.TelefonNumarasi = "Numara1";


            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.Adi = "Ad2";
            musteri2.Soyadi = "Soyad2";
            musteri2.Sehri = "Sehir2";
            musteri2.TelefonNumarasi = "Numara2";



            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkleme(musteri2);


            musteriManager.MusteriListeleme(musteri1);


            musteriManager.MusteriSilme(musteri2);
        }
    }
}
