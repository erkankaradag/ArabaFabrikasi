using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaFabrikasi
{
    internal class Araba
    {
        
        public DateTime UretimTarihi { get; set; }
        public long SeriNumarasi { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public int KapiSayisi { get; set; }

        public void BilgileriYazdir()
        {
            Console.WriteLine($"Üretim Tarihi: {UretimTarihi}");
            Console.WriteLine($"Aracın Seri Numarası: {SeriNumarasi}");
            Console.WriteLine($"Aracın Markası: {Marka}");
            Console.WriteLine($"Aracın Modeli: {Model}");
            Console.WriteLine($"Aracın Rengi: {Renk}");
            Console.WriteLine($"Aracın Kapı Sayısı: {KapiSayisi}");
        }
        public Araba()
        {
            UretimTarihi = DateTime.Now;
        }

    }
}
