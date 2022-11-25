// for Loop (for Döngüsü)

using _09_Loops.Demos;

namespace _09_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // belirli bir sayıda veya belirli bir koşul sağlandığı sürece veya bir veri kümesini (collection) dolaşmak (iterate) için döngüler kullanılır 


            
            // 1'den 10'a kadar (10 dahil) sayıları ekrana yazdıralım
            for (int i = 1; i <= 10; i++) // döngü i 1'den başlasın (döngüdeki değişkenin başlangıç değeri),
                                          // i 10'a kadar (10 olduğunda da) devam etsin (döngünün değişken üzerinden çalışma koşulu),
                                          // her tur sonunda da i 1 arttırılsın (döngüyü sonlandırabilmek için yukarıdaki koşulda kullanılan değişkeni güncelleme)
            {
                Console.WriteLine(i); // her bir tur için buradaki kodlar çalıştırılır
            }



            // 1'den 20'ye kadar (20 dahil) çift sayıları ekrana yazdıralım
            for (int i = 2; i <= 20; i = i + 2) // i değişkeni int i olarak bu döngü için tanımlanmıştır ve bu döngüde geçerlidir, dolayısıyla yukarıdaki döngüdeki i değişkeninden bağımsızdır
            {
                Console.WriteLine(i);
            }



            // 30'dan 1'e kadar (1 dahil) tek sayıları ekrana yazdıralım
            int j; // istenirse önce değişken tanımlanarak aşağıdaki döngüde döngü içerisinde tip tanımlanmadan da kullanılabilir
            for (j = 29; j >= 1; j -= 2) // döngü j 29'dan başlasın, j 1'e kadar (1 olduğunda da) devam etsin, her tur sonunda da j 2 azaltılsın
            {
                Console.WriteLine(j); // ekrana en son 1 yazdırır
            }
            Console.WriteLine(j); // bu satırda döngü sona ermiştir ve döngünün en son turundan sonra j yine 2 azaltacağı için ekrana -1 yazdırır



            // Algoritma örnek 1: Tek Sayılar, Çift Sayılar Toplamları
            /*
            1. başla
            2. kullanıcıdan başlangıç tam sayısı istenir
            3. kullanıcıdan bitiş tam sayısı istenir
            4. kullanıya başlangıç ve bitiş sayıları arasındaki (bitiş sayısı dahil değil) tek sayıların mı (t), çift sayıların mı (ç) toplanacağı sorulur
            5. girilenlere göre sayılar toplanır
            6. toplam sonucu ekrana yazdırılır
            7. bitiş
            */
            int toplam = 0; // toplam'a ilk değer 0 (toplamada etkisiz eleman) olarak atanır ki her bir döngü turunda toplam'a turdaki sayı eklensin
            Console.Write("Başlangıç sayısı giriniz: ");
            int baslangic = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitiş sayısı giriniz (bitiş sayısı toplamaya dahil edilmeyecek): ");
            int bitis = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tek sayıların toplamı için 't', çift sayıların toplamı içinse 'ç' giriniz: ");
            string tip = Console.ReadLine();
            for (int sayi = baslangic; sayi < bitis; sayi++)
            {
                if (tip == "t" && sayi % 2 != 0) // sadece sayı tipinin tek ve sayının ikiye bölümünden kalanın sıfır olmadığı koşulda toplama yapılsın
                    toplam += sayi;
                else if (tip == "ç" && sayi % 2 == 0) // sadece sayı tipinin çift ve sayının ikiye bölümünden kalanın sıfır olduğu koşulda toplama yapılsın
                    toplam += sayi;
            }
            Console.WriteLine($"Toplam: {toplam}");



            // Algoritma örnek 2: Asal Sayı
            /*
            1. başla
            2. kullanıcıdan 1 dışında pozitif bir tam sayı girilmesi istenir
            3. bir method içerisinde sayının asal olduğu işaretlenir
            4. bir sayaç 2'den başlayarak kullanıcının girdiği sayıya kadar döndürülür
            5. eğer kullanıcının girdiği sayının sayacın döngüdeki değerine bölümünden kalan 0 ise sayının asal olmadığı işaretlenir ve döngü sonlandırılır
            6. döngü bittikten sonra eğer sayı asal olarak işaretlendiyse methoddan sayı asaldır, asal olarak işaretlenmediyse methoddan sayı asal değildir dönülür
            7. dönen sonuç ekrana yazdırılır
            8. bitiş
            */
            int girisSayisi;
            Console.Write("1 dışında pozitif bir tam sayı giriniz: ");
            girisSayisi = int.Parse(Console.ReadLine());
            string asalMiSonucu = AsalMi(girisSayisi);
            Console.WriteLine(asalMiSonucu);



            #region Demos
            KullaniciGirisi.Calistir();
            Faktoriyel.Calistir();
            IngilizceAlfabe.Calistir();
            #endregion
        }



        // Algoritma örnek 2: Asal Sayı
        static string AsalMi(int sayi)
        {
            string sonuc = $"{sayi} asaldır.";
            bool asalMi = true; // flag (işaret), kullanım amacı herhangi bir döngüden önce bir ilk değer üzerinden işaretleme yapmak,
                                // döngüde herhangi bir koşula göre değerini güncellemek ve döngü sonunda da bu işaretin değerine göre işlem yaptırmaktır
            for (int sayac = 2; sayac < sayi; sayac++)
            {
                if (sayi % sayac == 0)
                {
                    asalMi = false;
                    break; // switch'te olduğu gibi döngülerde de break kullanılabilir, döngülerdeki görevi döngüyü sonlandırmaktır,
                           // döngüyü sonlandırmamızın nedeni ise sayının asal olmadığını yakaladıktan sonra gereksiz yere döngünün devam edip diğer sayıları kontrol etmesini engellemektir
                }
            }

            //if (asalMi == false)
            if (!asalMi) // bir üst satırdaki gibi boolean değişkenleri == ile kontrol etmek yerine bu satırdaki gibi yazmak zaten boolean değişkenler true veya false olabildikleri için daha uygundur
                sonuc = $"{sayi} asal değildir.";
           return sonuc;
        }
    }
}