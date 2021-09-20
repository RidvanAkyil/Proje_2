using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_2
{
    public  class MusteriManager
    {
        public void MusteriAdd(Musteri musteri)
        {
            Console.WriteLine("Müşteri Başarıyla Eklendi : " + musteri.MusteriAd + " " + musteri.MusteriSoyad);
        }

        public void MusteriRemove(Musteri musteri)
        {
            Console.WriteLine("Müşteri Başarıyla Güncellendi : " + musteri.MusteriAd + " " + musteri.MusteriSoyad);
        }

        public void MusteriDelete(Musteri musteri)
        {
            Console.WriteLine("Müşteri Başarıyla Silindi : " + musteri.MusteriAd + " " + musteri.MusteriSoyad);
        }

    }
}
