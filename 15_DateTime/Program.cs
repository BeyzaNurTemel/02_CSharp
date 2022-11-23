// DateTime struct (DateTime parçalı değer tipi)

using System.Globalization;

namespace _15_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DateTime tarih ve saat verilerini tutan struct yapıda bir değer tiptir.



            #region Now, Today ve Date Özellikleri
            DateTime simdikiTarihVeSaat = DateTime.Now; // bu satır çalıştığı andaki bilgisayarın tarihini ve saatini alır ve simdikiTarihVeSaat değişkenine atar
            Console.WriteLine(simdikiTarihVeSaat); // konsola örneğin "21.11.2022 18:17:03" yazdırır

            DateTime simdikiTarih = DateTime.Today; // bu satır çalıştığı andaki bilgisayarın tarihini, saatini de tümünü 0 olarak alır ve simdikiTarih değişkenine atar
            Console.WriteLine(simdikiTarih); // konsola örneğin "21.11.2022 00:00:00" yazdırır

            simdikiTarih = simdikiTarihVeSaat.Date; // simdikiTarihVeSaat verisindeki sadece tarih kısmını alır, saatini de tümünü 0 olarak alır ve simdikiTarih değişkenine atar
            Console.WriteLine(simdikiTarih); // konsola örneğin "21.11.2022 00:00:00" yazdırır
            #endregion



            #region Yeni Tarih Oluşturma ve Formatlama
            DateTime tarih1 = new DateTime(2022, 11, 21); // herhangi bir struct tipindeki parçalı verileri oluşturabilmek için new'lemek gerekir
            Console.WriteLine(tarih1); // konsola bilgisayarın bölgesel ayarına göre tarihi formatlayarak yazdırır: "21.11.2022 00:00:00"

            DateTime tarih2 = new DateTime(2022, 11, 21, 18, 23, 59);
            string tarih2formatlanmis = tarih2.ToString("MM/dd/yyyy HH:mm:ss", new CultureInfo("en-US")); 
            // bölgesel ayardan bağımsız istenilen bölgeye göre formatlama yapabilmek için
            // örneğin İngilizce için new CultureInfo("en-US") parametresi kullanılır, Türkçe olsaydı new CultureInfo("tr-TR") kullanılacaktı.
            // MM: iki hane ay, dd: iki hane gün, yyyy: dört hane yıl, HH: iki hane 24 saat, mm: iki hane dakika, ss: iki hane saniye
            Console.WriteLine(tarih2formatlanmis); // konsola İngilizce bölgesel ayarda tarihi formatlayarak yazdırır: "11/21/2022 18:23:59"

            DateTime tarih3 = new DateTime(2022, 11, 21, 18, 35, 41, 567); // 567: istenirse milisaniye parametresi de kullanılabilir
            string tarih3yazi = tarih3.Year + "-" + tarih3.Month + "-" + tarih3.Day + " " + tarih3.Hour + ":" + tarih3.Minute + ":" + tarih3.Second + "." + tarih3.Millisecond;
            // struct tiplerin her bir parçasına özellikler üzerinden ulaşılabilir
            Console.WriteLine(tarih3yazi); // konsola "2022-11-21 18:35:41.567" yazdırır

            Console.WriteLine(tarih3.ToShortDateString()); // konsola kısa formatta ve bilgisayarın bölgesel ayarına göre "21.11.2022" yazdırır
            Console.WriteLine(tarih3.ToLongDateString()); // konsola uzun formatta ve bilgisayarın bölgesel ayarına göre "21 Kasım 2022" Pazartesi yazdırır
            Console.WriteLine(tarih3.ToShortTimeString()); // konsola kısa formatta "18:35" yazdırır
            Console.WriteLine(tarih3.ToLongTimeString()); // konsola uzun formatta "18:35:41" yazdırır

            DateTime tarih4 = DateTime.Parse("23.11.2022"); // metinsel formatlı tarih verisini bilgisayarın bölgesel ayarına göre kendi içerisinde new'leyerek DateTime tipinde sonuç döner
            Console.WriteLine(tarih4.ToString(new CultureInfo("tr-TR"))); // konsola "23.11.2022 00:00:00" verisini Türkçe bölgesel ayara göre formatlar ve yazdırır

            DateTime tarih5 = DateTime.Parse("23.11.2022 19:26:35", new CultureInfo("tr-TR")); // istenirse saat de kullanılabilir, Türkçe bölgesel ayara göre DateTime verisi döner
            Console.WriteLine(tarih5.ToString(new CultureInfo("en-US"))); // konsola "11/23/2022 7:26:35 PM" verisini İngilizce bölgesel ayara göre formatlar ve yazdırır

            DateTime tarih6 = DateTime.Parse("11/23/2022", new CultureInfo("en-US")); // İngilizce bölgesel ayara göre DateTime verisi döner
            Console.WriteLine(tarih6.ToString("yyyy-MM-dd")); // konsola istenilen özel formatta (SQL formatı) "2022-11-23" verisini yazdırır
            #endregion



            #region Ekleme Methodları
            DateTime simdi = DateTime.Now;
            Console.WriteLine($"Bugün: {simdi}"); // konsola örneğin "Bugün: 23.11.2022 19:39:11" yazdırır
            Console.WriteLine($"Yarın: {simdi.AddDays(1).ToShortDateString()}"); // konsola örneğin "Yarın: 24.11.2022" yazdırır
            Console.WriteLine($"1 hafta öncesi: {simdi.AddDays(-7).ToShortDateString()} {simdi.AddDays(-7).ToLongTimeString()}"); // konsola örneğin "1 hafta öncesi: 16.11.2022 19:39:11" yazdırır
            Console.WriteLine($"6 ay sonrası: {simdi.AddMonths(6).ToShortDateString()}"); // konsola örneğin "6 ay sonrası: 23.05.2023" yazdırır
            Console.WriteLine($"10 yıl öncesi: {simdi.AddYears(-10).ToShortDateString()}"); // konsola örneğin "10 yıl öncesi: 23.11.2012" yazdırır
            Console.WriteLine($"12 saat sonrası: {simdi.AddHours(12).ToString(new CultureInfo("tr-TR"))}"); // konsola örneğin "12 saat sonrası: 24.11.2022 07:39:11" yazdırır
            Console.WriteLine($"Yarım saat öncesi: {simdi.AddMinutes(-30).ToString(new CultureInfo("en-US"))}"); // konsola örneğin "Yarım saat öncesi: 11/23/2022 7:09:11 PM" yazdırır
            #endregion



            #region Kıyaslama İşlemleri
            DateTime date1 = DateTime.Parse("06.09.2015 01:02:03", new CultureInfo("tr-TR"));
            DateTime date2 = DateTime.Parse("29.04.2010 23:59:58", new CultureInfo("tr-TR"));
            if (date1 > date2) // date1 > date2 yerine date1.CompareTo(date2) > 0 da yazılabilir
                Console.WriteLine($"{date1} büyüktür {date2}");
            else if (date1 < date2) // date1 < date2 yerine date1.CompareTo(date2) < 0) da yazılabilir
                Console.WriteLine($"{date1} küçüktür {date2}");
            else if (date1 == date2) // date1 == date2 yerine date1.CompareTo(date2) == 0 veya date1.Equals(date2) de yazılabilir, son koşul olduğundan else'den sonra if'e gerek yoktur
                Console.WriteLine($"{date1} eşittir {date2}");
            // konsola "6.09.2015 01:02:03 büyüktür 29.04.2010 23:59:58" yazdırır
            #endregion



            #region Tarihin Sayısal Kullanımı
            long sayisalTarih = DateTime.Now.Ticks;
            Console.WriteLine(sayisalTarih); // konsola 01.01.0001 00:00:00.000 tarihinden itibaren belirli bir aralıkta ekleme yaparak bugünün tarihini sayısal olarak yazdırır
            #endregion



            // Algoritma Örnek 1: Yaş Hesaplama
            /*
            1. başla
            2. kullanıcıya doğum tarihi Türkçe formatta sorulur, çıkmak için Ç'ye basması gerektiği yazdırılır ve kullanıcıdan doğum tarihi alınır
            3. bir methoda doğum tarihi gönderilerek yaş hesaplanır ve geriye dönülür
            4. geriye dönülen yaş ekrana yazdırılır
            5. 2. adıma dönülür, eğer kullanıcı Ç girerse 6. adıma gidilir
            6. bitiş
            */
            Console.Write("Doğum tarihinizi giriniz (gün.ay.yıl), çıkmak için \"Ç\" tuşuna basınız: ");
            string dogumTarihiGiris = Console.ReadLine();
            int yas;
            while (dogumTarihiGiris.ToUpper() != "Ç")
            {
                yas = YasHesapla(dogumTarihiGiris);
                Console.WriteLine("Yaşınız: " + yas);
                Console.Write("Doğum tarihinizi giriniz (gün.ay.yıl), çıkmak için \"Ç\" tuşuna basınız: ");
                dogumTarihiGiris = Console.ReadLine();
            }



            // Algoritma Örnek 2: Son Kullanma Tarihi Kontrolü
            /*
            1. başla
            2. kullanıcıdan son kullanma tarihi İngilizce formatta sorulur ve alınır
            3. bir methoda son kullanma tarihi gönderilerek eğer geçtiyse true geçmediyse false dönülür
            4. dönen sonuca göre ekrana son kullanma tarihi geçmiş ya da son kullanma tarihi geçmemiş yazdırılır
            5. bitiş
            */
            Console.Write("Expiration date (month/day/year): ");
            string expirationDate = Console.ReadLine();
            bool result = IsExpired(expirationDate);
            Console.WriteLine(result ? "Expired." : "Not expired.");
        }
        


        #region Algoritma Örnek 1: Yaş Hesaplama
        static int YasHesapla(string dogumTarihiGiris)
        {
            int yas;
            DateTime dogumTarihi = DateTime.Parse(dogumTarihiGiris, new CultureInfo("tr-TR"));
            DateTime simdikiTarih = DateTime.Today;
            TimeSpan tarihFarki = simdikiTarih.Subtract(dogumTarihi); // TimeSpan süre için kullanılan veri tipidir. Gün, saat, dakika, saniye ve milisaniyeden oluşan bir struct'tır.
            yas = (int)(tarihFarki.TotalHours / (365 * 24 + 6)); // 1 yıl 365 gün 6 saat olduğu için tarih farkı olan sürenin toplam saatini kullanarak işlem yapıp
                                                                 // ondalık haneden kurtulmak için int'e cast ediyoruz.
                                                                 // Toplam süre için TotalDays, TotalHours, TotalMinutes, TotalSeconds veya TotalMilliseconds özellikleri kullanılmalıdır
            return yas;
        }
        #endregion



        #region Algoritma Örnek 2: Son Kullanma Tarihi Kontrolü
        // eğer istenirse bu method Türkçe formatta bir tarih ile culture parametresi tr-TR gönderilerek de kullanılabilir
        static bool IsExpired(string date, string culture = "en-US")
        {
            bool result = false;
            DateTime today = DateTime.Now.Date;
            DateTime expirationDate = DateTime.Parse(date, new CultureInfo(culture));
            if (expirationDate < today)
                result = true;
            return result;
        }
        #endregion
    }
}