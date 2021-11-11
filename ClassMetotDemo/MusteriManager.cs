using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Yeni müşteri eklendi. " + musteri.Adi + " " + musteri.Soyadı + " " + musteri.TcNo);
        }
        public void MusteriListele(Musteri musteri)
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

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            foreach (Musteri musteris in musteriler)
            {
                Console.WriteLine(musteris.Adi + " " + musteris.Soyadı + " " + musteris.TcNo);

            }
            Console.WriteLine("Müsteri listelenmesi tamamlanmıştır.");

        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("İsteğiniz üzere müşteri silindi. " + musteri.Adi + " " + musteri.Soyadı + " " + musteri.TcNo);
        }
    }
}
