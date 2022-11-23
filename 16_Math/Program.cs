// Math class (Math sınıfı)

using System.Globalization;

namespace _16_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Math içerisinde temel matematik işlemler için kullanılabilecek method ve özelliklerin bulunduğu bir sınıftır



            #region Abs (Mutlak Değer) Methodu
            int sayi1 = 10;
            int sayi2 = 20;
            int mutlakDeger = Math.Abs(sayi1 - sayi2); // 10 sonucunu döner
            Console.WriteLine("sayi1 - sayi2 = " + (sayi1 - sayi2) + ", Mutlak değeri: " + Math.Abs(mutlakDeger));
            // konsola "sayi1 - sayi2 = -10, Mutlak değeri: 10" yazdırır
            #endregion



            #region Min (Minimum), Max (Maksimum), Pow (Üs) ve Sqrt (Karekök) Methodları
            int sayi3 = 3;
            int sayi4 = 4;
            Console.WriteLine($"{sayi3} ve {sayi4} için büyük olan sayı: {Math.Max(sayi3, sayi4)}, küçük olan sayı: {Math.Min(sayi3, sayi4)}");
            // konsola "3 ve 4 için büyük olan sayı: 4, küçük olan sayı: 3" yazdırır

            Console.WriteLine(sayi4 + " üzeri " + sayi3 + ": " + Math.Pow(sayi4, sayi3));
            // konsola "4 üzeri 3: 64" yazdırır

            Console.WriteLine(sayi4 + " sayısının karekökü: " + Math.Sqrt(sayi4));
            // konsola "4 sayısının karekökü 2" yazdırır

            // küpkök hesaplama:
            Console.WriteLine("8 sayısının küpkökü: " + Math.Pow(8, 1 / 3)); // yanlış çünkü 1 / 3 = 0, 8 üzeri 0 = 1, konsola "8 sayısının küpkökü: 1" yazdırır
            Console.WriteLine("8 sayısının küpkökü: " + Math.Pow(8, 1.0 / 3)); // doğru çünkü 1.0 / 3 = 0.333..., 8 üzeri 0.333... = 2, konsola "8 sayısının küpkökü: 2" yazdırır
            Console.WriteLine("8 sayısının küpkökü: " + Math.Pow(8, 1 / 3.0)); // doğru çünkü 1 / 3.0 = 0.333..., 8 üzeri 0.333... = 2, konsola "8 sayısının küpkökü: 2" yazdırır
            Console.WriteLine("8 sayısının küpkökü: " + Math.Pow(8, 1.0 / 3.0)); // doğru çünkü 1.0 / 3.0 = 0.333..., 8 üzeri 0.333... = 2, konsola "8 sayısının küpkökü: 2" yazdırır
            #endregion



            #region Floor (Taban), Ceiling (Tavan) ve Round (Yuvarlama) Methodları
            double sayi5 = 12.345;
            double sayi6 = 98.765;
            Console.WriteLine($"{sayi5} tabana yuvarlanmış: {Math.Floor(sayi5)}, {sayi5} tavana yuvarlanmış: {Math.Ceiling(sayi5)}");
            // konsola "12,345 tabana yuvarlanmış: 12, 12,345 tavana yuvarlanmış: 13" yazdırır

            // Round methodu 5 ve daha küçük sayıları aşağı, 5'ten büyük sayıları yukarı yuvarlar
            Console.WriteLine($"{sayi5} yuvarlanmış: {Math.Round(sayi5)}; {sayi6} yuvarlanmış: {Math.Round(sayi6)}");
            // konsola "12,345 yuvarlanmış: 12; 98,765 yuvarlanmış: 99" yazdırır

            Console.WriteLine($"{sayi5} 1 ondalık için yuvarlanmış: {Math.Round(sayi5, 1)}; {sayi6} 1 ondalık için yuvarlanmış: {Math.Round(sayi6, 1)}");
            // konsola "12,345 1 ondalık için yuvarlanmış: 12,3; 98,765 1 ondalık için yuvarlanmış: 98,8" yazdırır

            Console.WriteLine($"{sayi5} 2 ondalık için yuvarlanmış: {Math.Round(sayi5, 2)}; {sayi6} 2 ondalık için yuvarlanmış: {Math.Round(sayi6, 2)}");
            // konsola "12,345 2 ondalık için yuvarlanmış: 12,34; 98,765 2 ondalık için yuvarlanmış: 98,76" yazdırır
            #endregion



            // Algoritma Örnek 1:
            /*
            1. başla
            2. kullanıcıya yarıçap sorulur ve alınır, çıkış için q'ya basması istenir
            3. kullanıcıya alan (a) veya çevre (ç) hesabı mı yapılacağı sorulur ve alınır 
            4. kullanıcıya Pİ'nin gerçek değeri mi (evet için e) 3.14 değeri mi (hayır için h) kullanılacağı sorulur ve alınır
            5. bir methoda alınan yarıçap, alan (a) veya çevre (ç) hesabı ve Pİ sayısının 3.14 mü gerçek değeri mi kullanılacağı parametreler olarak gönderilir
            6. Pİ'nin gerçek veya 3.14 değerine göre eğer alan (a) hesaplanacaksa dairenin alanı, çevre (ç) hesaplanacaksa dairenin çevresi hesaplanır ve dönülür
            7. dönen sonuç ekrana yazdırılır
            8. 2. adımdan devam edilir, eğer q girilirse 9. adıma gidilir
            9. bitiş
            */
            Console.Write("Yarıçap (çıkış için q): ");
            double yariCap = Convert.ToDouble(Console.ReadLine(), new CultureInfo("tr-TR")); // Türkçe formatta ondalık olarak , İngilizce formatta . kullanılır
            Console.Write("Alan (a) veya çevre (ç): ");
            string hesapTuru = Console.ReadLine();
            Console.Write("Pİ gerçek değeri mi (evet için e, hayır için h)? ");
            string piGercekDegeriMi = Console.ReadLine();
            double sonuc = Hesapla(yariCap, hesapTuru, piGercekDegeriMi);
            string mesaj = "Dairenin " + (hesapTuru == "a" ? "alanı" : "çevresi") + ": " + sonuc;
            Console.WriteLine(mesaj);
        }



        #region Algoritma Örnek 1:
        static double Hesapla(double yariCap, string hesapTuru, string piGercekDegeriMi)
        {
            double sonuc;
            double pi = piGercekDegeriMi == "e" ? Math.PI : 3.14;
            if (hesapTuru == "a")
            {
                sonuc = pi * Math.Pow(yariCap, 2);
            }
            else
            {
                sonuc = 2 * pi * yariCap;
            }
            return sonuc;
        }
        #endregion
    }
}