# Araba Fabrikası Uygulaması

Bu proje, kullanıcıların konsol uygulaması üzerinden araba üretmesine ve üretilen arabaların bilgilerini yönetmesine olanak tanır.

## Özellikler
- Kullanıcıdan araba üretme isteği alınır.
- Araba özellikleri (Seri Numarası, Marka, Model, Renk, Kapı Sayısı) kullanıcıdan dinamik olarak talep edilir.
- Geçersiz girişlere karşı hatalı giriş kontrol mekanizması uygulanır.
- Üretilen arabalar bir listeye kaydedilir.
- Kullanıcı programdan çıkmadan önce tüm üretilen arabaların özet bilgileri görüntülenir.

## Nasıl Çalışır?
1. Kullanıcıya araba üretmek isteyip istemediği sorulur.
   - "e" girilirse araba üretim süreci başlar.
   - "h" girilirse program sona erer ve üretilen arabalar listelenir.
   - Hatalı giriş yapılırsa tekrar doğru bir giriş istenir.

2. Araba üretim süreci:
   - **Seri Numarası**: Uzun tam sayı (long) türünde kullanıcıdan alınır.
   - **Marka**: Kullanıcıdan serbest metin olarak alınır.
   - **Model**: Kullanıcıdan serbest metin olarak alınır.
   - **Renk**: Kullanıcıdan serbest metin olarak alınır.
   - **Kapı Sayısı**: 2 veya 4 olarak alınır. Geçersiz giriş durumunda tekrar giriş istenir.

3. Üretilen araba bilgileri listeye eklenir ve kullanıcıya gösterilir.

4. Kullanıcı programı sonlandırmak istediğinde tüm üretilen arabaların özet bilgileri yazdırılır ve uygulama sona erer.

## Kullanılan Teknolojiler
- **C# Programlama Dili**
- **.NET Core Konsol Uygulaması**

## Kod Yapısı
- **`Program` sınıfı**: Uygulamanın giriş noktasıdır.
- **`Araba` sınıfı**: Arabalara ait özellikleri ve metotları içerir.

### `Araba` Sınıfı
```csharp
class Araba
{
    public long SeriNumarasi { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }
    public int KapiSayisi { get; set; }

    public void BilgileriYazdir()
    {
        Console.WriteLine($"Seri Numarası: {SeriNumarasi}, Marka: {Marka}, Model: {Model}, Renk: {Renk}, Kapı Sayısı: {KapiSayisi}");
    }
}
```

## Nasıl Çalıştırılır?
1. Projeyi bir C# geliştirme ortamında (örneğin Visual Studio veya VS Code) açın.
2. `Program.cs` dosyasını çalıştırın.
3. Konsol ekranında verilen talimatları izleyerek arabalar üretin ve işlemleri tamamlayın.

## Örnek Kullanım
### Konsol Çıktısı
```
Araba üretmek ister misiniz? (Evet: e Hayır: h)
e
Lütfen Aracın Seri Numarasını Girin:
123456789
Lütfen Aracın Markasını Girin:
Toyota
Lütfen Aracın Modelini Girin:
Corolla
Lütfen Aracın Renk Bilgisini Girin:
Kırmızı
Lütfen Aracın Kapı Sayısını Girin (2-4):
4
Araba üretildi! İşte aracın bilgileri:
Seri Numarası: 123456789, Marka: Toyota, Model: Corolla, Renk: Kırmızı, Kapı Sayısı: 4

Araba üretmek ister misiniz? (Evet: e Hayır: h)
h
Araba Markası: Toyota, Seri Numarası: 123456789
Programdan çıkılıyor...
```

## Geliştirme Önerileri
- **Dosya Kaydı**: Üretilen arabalar bir dosyaya kaydedilebilir ve daha sonra okunabilir.
- **Veri Tabanı Entegrasyonu**: Arabalar bir veri tabanında saklanabilir.
- **Araba Özellikleri Genişletme**: Arabalara ek özellikler (ör. motor tipi, yakıt türü) eklenebilir.

## Katkıda Bulunma
Eğer projeye katkıda bulunmak isterseniz, lütfen bir pull request oluşturun veya önerilerinizi [buradan](mailto:example@example.com) paylaşın.

## Lisans
Bu proje MIT lisansı ile lisanslanmıştır.

