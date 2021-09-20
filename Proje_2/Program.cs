using System;

namespace Proje_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.MusteriAd = "Ahmet";
            musteri.MusteriSoyad = "Dalkılıç";
            Musteri musteri2 = new Musteri();
            musteri2.MusteriAd = "Mehmet";
            musteri2.MusteriSoyad = "Akif";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAd = "Engin";
            musteri3.MusteriSoyad = "Demiroğ";

            Musteri[] musterilerdizisi = new Musteri[] { musteri, musteri2, musteri3 };
            MusteriManager musterimanager = new MusteriManager();
            foreach (var musterilistele in musterilerdizisi)
            {
                musterimanager.MusteriAdd(musterilistele);
                musterimanager.MusteriDelete(musterilistele);
                musterimanager.MusteriRemove(musterilistele);
                Console.WriteLine("-------------------------------------------");
            }

        }
    }
}
