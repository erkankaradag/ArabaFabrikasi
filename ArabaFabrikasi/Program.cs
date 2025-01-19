using System;
namespace ArabaFabrikasi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Araba> arabalar = new List<Araba>(); // Arabaları saklamak için liste oluşturduk

            while (true)
            {
                Console.WriteLine("Araba üretmek ister misiniz? (Evet: e Hayır: h) ");
                string input = Console.ReadLine().ToLower();


                // Kullanıcı doğru bir giriş yapana kadar döngü devam eder.
                while (input != "e" && input != "h")
                {
                    Console.WriteLine("Geçersiz giriş yaptınız. Lütfen araba üretmek istiyorsanız 'e' (Evet) istemiyorsanız 'h' (Hayır) girin!");
                    input = Console.ReadLine().ToLower();
                }
                // Kullanıcı doğru giriş yaptığında işlem yapılır.
                if (input == "e")
                {
                    Araba araba = new Araba();


                    // Seri numarası alma
                    Console.WriteLine("Lütfen Aracın Seri Numarasını Girin: ");
                    while (true)
                    {
                        if (long.TryParse(Console.ReadLine(), out long seriNumarasi))
                        {
                            araba.SeriNumarasi = seriNumarasi;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz giriş! Lütfen geçerli bir uzun tam sayı (long) girin.");
                        }
                    }

                    // Marka bilgisi alma
                    Console.WriteLine("Lütfen Aracın Markasını Girin: ");
                    araba.Marka = Console.ReadLine();

                    // Model bilgisi alma
                    Console.WriteLine("Lütfen Aracın Modelini Girin: ");
                    araba.Model = Console.ReadLine();

                    // Renk bilgisi alma
                    Console.WriteLine("Lütfen Aracın Renk Bilgisini Girin: ");
                    araba.Renk = Console.ReadLine();

                    // Kapı sayısı alma
                    KapiSayisiGir(araba);

                    // Arabayı listeye ekle
                    arabalar.Add(araba);

                    // Araba bilgilerini yazdırma
                    Console.WriteLine("Araba üretildi! İşte aracın bilgileri:");
                    araba.BilgileriYazdir();
                    
                }

                else if (input == "h")
                {
                    foreach (var araba in arabalar)
                    {
                        Console.WriteLine($"Araba Markası: {araba.Marka}, Seri Numarası: {araba.SeriNumarasi}");
                    }
                    Console.WriteLine("Programdan çıkılıyor...");
                    break; // Programdan çıkış.
                }

            }
            // Kapı sayısını almak için fonksiyon
            static void KapiSayisiGir(Araba araba)
            {
            KapiSayisiYenidenGir:
                try
                {
                    Console.WriteLine("Lütfen Aracın Kapı Sayısını Girin (2-4): ");
                    araba.KapiSayisi = Convert.ToInt32(Console.ReadLine());

                    // Kapı sayısının 2 ile 4 arasında olup olmadığını kontrol et
                    if (araba.KapiSayisi == 2 || araba.KapiSayisi == 4)
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Kapı sayısı 2 veya 4 olmalıdır. Lütfen tekrar girin.");
                        goto KapiSayisiYenidenGir; // Hatalı giriş durumunda tekrar başa dön.
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen geçerli bir tam sayı girin.");
                    goto KapiSayisiYenidenGir; // Hatalı giriş durumunda tekrar başa dön.
                }
            }

        }
    }
}
