using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Mesut";
            musteri1.Soyadı = "Rüzgar";
            musteri1.TcNo = 414141;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Okan";
            musteri2.Soyadı = "Çetinkaya";
            musteri2.TcNo = 424242;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Mesut";
            musteri3.Soyadı = "Aksoy";
            musteri3.TcNo = 404040;

            Musteri musteri4 = new Musteri();
            musteri4.Adi = "Furkan";
            musteri4.Soyadı = "Kaya";
            musteri4.TcNo = 474747;

            Console.WriteLine("----------Musteri Ekleme--------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriEkle(musteri4);

            Console.WriteLine("-----Musteri Cıkartma--------");

            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriSil(musteri3);
            musteriManager.MusteriSil(musteri4);

            Console.WriteLine("-----Musteri Listele--------");
            musteriManager.MusteriListele(musteri1);

        }
    }
}
