// while Loop (while Döngüsü)

namespace _10_WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while ve for döngüleri duruma göre birbirlerine alternatif olarak kullanılabilir



            // 1'den 10'a kadar (10 dahil) sayıları ekrana yazdıralım
            int i = 1; // döngüdeki değişkenin başlangıç değeri
            while (i <= 10) // döngünün değişken üzerinden çalışma koşulu
            {
                // her bir tur için buradaki kodlar çalıştırılır
                Console.WriteLine(i);
                i++; // döngüyü sonlandırabilmek için yukarıdaki koşulda kullanılan değişkeni güncelleme, eğer unutulursa döngü sürekli çalışır ve sonsuz döngü meydana gelir
            }



            // Algoritma örnek 1: Faktoriyel
            /*
            1. başla
            2. bir methodda kullanıcıdan 0 ile 10 arasında bir tam sayı istenir
            3. başka bir methodda eğer sayı 0 girilirse sonuç 1 atanır
            4. eğer 1'den 10'a kadar başka bir sayı girilirse 2'den başlanıp kullanıcının girdiği sayıya kadar çarpım yapılır ve sonuç güncellenerek methoddan dönülür
            5. dönen sonuç sayı ile birlikte ekrana yazdırılır
            6. bitiş
            */
            byte sayi = SayiAl();
            long faktoriyel = FaktoriyelHesapla(sayi);
            Console.WriteLine(sayi + " faktoriyeli " + faktoriyel);



            // Algoritma örnek 2: Üs Alma
            /*
            1. başla
            2. kullanıcıdan pozitif bir tam sayı taban değeri olarak istenir
            3. kullanıcıdan pozitif bir tam sayı üs değeri olarak istenir
            4. bir methodda taban sayı üs değeri kadar çarpılarak sonuç güncellenir ve methoddan dönülür
            5. dönen sonuç sayı ile birlikte ekrana yazdırılır
            6. bitiş
            */
            long taban, us, sonuc;
            Console.Write("Pozitif taban sayı: ");
            taban = Convert.ToInt64(Console.ReadLine());
            Console.Write("Pozitif üs sayı: ");
            us = Convert.ToInt64(Console.ReadLine());
            sonuc = UsAl(taban, us);
            Console.WriteLine($"{taban} üssü {us} eşittir {sonuc}");



            // Algoritma örnek 3: KDV Hesaplama (ç tuşu ile çıkış yapılana kadar)
            /*
            1. başla
            2. KDV %18 olarak sabit kullanılır
            3. kullanıcıdan ücret istenir
            4. toplam ücret, ücret üzerine ücretin %18'i eklenerek hesaplanır
            5. ilk ücret bilgisi ekrana yazdırılır
            6. daha sonra KDV bilgisi ekrana yazdırılır
            7. en son olarak da toplam ücret ekrana yazdırılır
            8. kullanıcı ç (çıkış) girene kadar 3. adımdan devam edilir
            9. bitiş
            */
            const double kdv = 0.18; // const yani sabit değişkenler bir kere tanımlanır ve değerleri tanımlandıktan sonra değiştirilemez
            double ucret, toplamUcret;
            Console.Write("Ücret giriniz (ç: çıkış) ");
            string ucretGiris = Console.ReadLine();
            while (ucretGiris != "ç")
            {
                ucret = Convert.ToDouble(ucretGiris); // ondalık sayılarda işletim sisteminin bölgesel ayarına dikkat edilmelidir, bu şekilde bilgisayarın bölgesel ayarı kullanılacaktır
                                                      // eğer bölgesel ayar Türkçe ise ondalık ayracı , İngilizce ise . kullanılmalıdır
                                                      // dikkat edilmezse ondalık ve basamak gruplama ayraçları karışabilir
                toplamUcret = ucret + ucret * kdv; // çarpmanın toplamaya göre önceliği olduğundan parantezle gruplamaya gerek yoktur
                Console.WriteLine("Ücret: " + ucret);
                Console.WriteLine("KDV: " + kdv);
                Console.WriteLine("Toplam Ücret: " + toplamUcret);
                Console.Write("Ücret giriniz (ç: çıkış) ");
                ucretGiris = Console.ReadLine();
            }
        }



        #region Algoritma örnek 1: Faktoriyel
        static byte SayiAl()
        {
            byte sayi;
            string giris;
            Console.Write("0 ile 10 arasında bir tam sayı giriniz: ");
            giris = Console.ReadLine();
            sayi = Convert.ToByte(giris);
            return sayi;
        }

        static long FaktoriyelHesapla(byte sayi)
        {
            long sonuc = 1;
            int i;
            if (sayi != 0) // sayi değişkeninin 0 olması durumunda sonuc değişkeni yukarıda 1'e atandı
            {
                i = 2;
                while (i <= sayi)
                {
                    sonuc = sonuc * i;
                    i++;
                }
            }
            return sonuc;
        }
        #endregion



        // Algoritma örnek 2: Üs Alma
        static long UsAl(long taban, long us)
        {
            long sonuc = 1; // çarpmada etkisiz eleman olduğu için sonuc'un ilk değerine 1 atadık
            long j = 1;
            while (j <= us)
            {
                sonuc *= taban;
                j++;
            }
            return sonuc;
        }
    }
}