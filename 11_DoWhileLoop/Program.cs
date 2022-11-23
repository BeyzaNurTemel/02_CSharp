// do while Loop (do while Döngüsü)

namespace _11_DoWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // do while, while ve for döngüleri duruma göre birbirlerine alternatif olarak kullanılabilir



            // 1'den 10'a kadar (10 dahil) sayıları ekrana yazdıralım
            int i = 1; // döngüdeki değişkenin başlangıç değeri
            do
            {
                // her bir tur için buradaki kodlar çalıştırılır
                Console.WriteLine(i);
                i++; // döngüyü sonlandırabilmek için yukarıdaki koşulda kullanılan değişkeni güncelleme, eğer unutulursa döngü sürekli çalışır ve sonsuz döngü meydana gelir
            }
            while (i <= 10); // döngünün değişken üzerinden çalışma koşulu



            /* do while ile while arasındaki fark:
            do while'da do içerisindeki kodlar mutlaka bir kez çalıştırılır, sonrasında while içerisindeki koşula bakılarak döngü çalışmaya devam eder veya sonlandırılır.
            while'da ise önce while içerisindeki koşula bakılır, eğer koşul sağlanıyorsa while içerisindeki kodlar çalıştırılır, sağlanmıyorsa while içerisindeki kodlar hiç çalıştırılmaz.
            */



            // Algoritma örnek 1: Tüm Sayı Toplamları
            /* 
            1. başla
            2. kullanıcıdan başlangıç tam sayısı istenir
            3. kullanıcıdan bitiş tam sayısı istenir
            4. başlangıç ve bitiş sayıları (bitiş sayısı dahil) toplanır ve bir sonuç değişkenine atanır
            5. sonuç değişkeni ekrana yazdırılır
            6. bitiş
            */
            Console.Write("Başlangıç sayısı giriniz: ");
            int baslangic = int.Parse(Console.ReadLine());
            Console.Write("Bitiş sayısı giriniz: ");
            int bitis = int.Parse(Console.ReadLine());
            int toplam = 0;
            do
            {
                toplam += baslangic;
                baslangic++;
            }
            while (baslangic <= bitis);
            Console.WriteLine($"Toplam: {toplam}");



            // A'dan Z'ye, sonrasında da a'dan z'ye harfleri yazdıralım
            // 1. yöntem: ASCII Tablosu kullanarak
            const int buyukA = 65;
            const int buyukZ = 90;
            const int kucukA = 97;
            const int kucukZ = 122;
            int harf = buyukA;
            do
            {
                if ((harf >= buyukA && harf <= buyukZ) || (harf >= kucukA && harf <= kucukZ))
                {
                    Console.Write((char)harf + " "); // (char)harf: casting (birbirlerine uyumlu veri tipleri üzerinden tip dönüşümü) ile harf sayısının ASCII Tablosu'ndaki karşılığı olan harfi kullanıyoruz
                }
                harf++;
            }
            while (harf <= kucukZ);

            // 2. yöntem:
            Console.WriteLine(); // yukarıdaki kodlar çalıştıktan sonra bir alt satırdan devam etmesi için
            char karakter = 'A'; // C# otomatik olarak karakterin ASCII Tablosu'ndaki integer değeri üzerinden aşağıdaki kodları çalıştırıyor
            do
            {
                if ((karakter >= 'A' && karakter <= 'Z') || (karakter >= 'a' && karakter <= 'z'))
                {
                    Console.Write(karakter + " ");
                }
                karakter++;
            }
            while (karakter <= 'z');
        }
    }
}