// Arithmetic Operations (Aritmetik İşlemler)

namespace _02_ArithmeticOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Toplama İşlemi
            int toplam1 = 1 + 2;
            Console.WriteLine("1 + 2 = " + toplam1);



            int toplam2 = 1 + 2 + 3 + 4;
            Console.WriteLine("1 + 2 + 3 + 4 = " + toplam2);



            int no1 = 1, no2 = 2, no3 = 3, no4 = 4; // birden çok aynı tipteki değişken tek satırda tanımlanabilir ve istenirse değerleri aynı satırda atanabilir
            int toplam3 = no1 + no2 + no3 + no4;
            Console.WriteLine("No1 + No2 + No3 + No4 = " + toplam3);



            int sayi1 = 1;
            int sayi2 = 2;
            int toplam4 = sayi1 + sayi2;
            Console.WriteLine($"{sayi1} + {sayi2} = {toplam4}");



            long sayi3 = 3;
            sayi3 = sayi3 + 4; // sayi3 değişkenine 4 ekle ve değeri sayi3 değişkenine ata, son değer 7 olur
            Console.WriteLine($"Sayı 3: {sayi3}");



            sayi3 += 5; // sayi3 değişkenine 5 ekle ve değeri sayi3 değişkenine ata, son değer 12 olur, sayi3 = sayi3 + 5 ile aynı işlemi yapar
            Console.WriteLine($"Sayı 3: {sayi3}");



            short sayi4 = 6;
            sayi4++; // ++: increment (arttırma) operatörü, sayi4 değişkenine 1 ekle ve değeri sayi4 değişkenine ata, son değer 7 olur, sayi4 = sayi4 + 1 ve ++sayi4 ile aynı sonucu verir
            Console.WriteLine($"Sayı 4: {sayi4}");



            byte sayi5 = 1;
            Console.WriteLine(sayi5++); // önce sayi5'in değerini yani 1 yazdırır, sonra sayi5'in değerini 1 arttırır
            Console.WriteLine(sayi5); // 2 yazdırır



            sayi5 = 1;
            Console.WriteLine(++sayi5); // önce sayi5'in değerini 1 arttırır, sonra sayi5'in değerini yani 2 yazdırır
            Console.WriteLine(sayi5); // 2 yazdırır
            #endregion



            #region Çıkarma İşlemi
            int sayi6 = 6;
            int sayi7 = 7;
            int fark = sayi7 - sayi6;
            Console.WriteLine($"{sayi7} - {sayi6} = {fark}");



            double sayi8 = 8.9;
            sayi8 -= 0.9; // sayi8 = sayi8 - 0.9 ile aynı işlemi yapar, sayi8 değişkeninin değeri 8 olur
            Console.WriteLine($"Sayı 8: {sayi8}");



            short sayi9 = 9;
            --sayi9; // --: decrement (azaltma) operatörü, sayi9 değişkeninden 1 çıkar ve değeri sayi9 değişkenine ata, son değer 8 olur, sayi9 = sayi9 - 1 ve sayi9-- ile aynı sonucu verir
            Console.WriteLine($"Sayı 9: {sayi9}");



            long sayi10 = 1;
            Console.WriteLine(sayi10--); // önce sayi10'un değerini yani 1 yazdırır, sonra sayi10'un değerini 1 azaltır
            Console.WriteLine(sayi10); // 0 yazdırır



            sayi10 = 1;
            Console.WriteLine(--sayi10); // önce sayi10'un değerini 1 azaltır, sonra sayi10'un değerini yani 0 yazdırır
            Console.WriteLine(sayi10); // 0 yazdırır
            #endregion



            #region Çarpma İşlemi
            int sayi11 = 11;
            int sayi12 = 12;
            int carpim = sayi11 * sayi12;
            Console.WriteLine($"{sayi11} * {sayi12} = {carpim}");



            float sayi13 = 13.31f;
            sayi13 *= 2; // sayi13 = sayi13 * 2, sayi3 değeri 26.62 olur
            Console.WriteLine("Sayı 13: " + sayi13); // konsola Sayı 13: 26,62 yazdırır
            #endregion



            #region Bölme İşlemi
            int sayi14 = 14;
            int sayi15 = 5;
            int bolum1 = sayi14 / sayi15; // bolum1 değeri 2 olur, bölüm sonucu 2.8 olsa da bölme işleminin iki tarafında da int veri tipi kullanıldığından sonuçtaki ondalık hane gözardı edilir
            Console.WriteLine("Bölüm 1: " + bolum1);



            double bolum2 = sayi14 / sayi15; // bolum2 değeri 2.0 olur, bölüm sonucu 2.8 olsa da bölme işleminin iki tarafında da int veri tipi kullanıldığından sonuçtaki ondalık hane gözardı edilir,
                                             // bolum2 değişkeni double olduğundan sonuç 2.0 olur
            Console.WriteLine("Bölüm 2: " + bolum2);



            double sayi16 = 14;
            int sayi17 = 5;
            double bolum3 = sayi16 / sayi17; // bolum3 değeri 2.8 olur, bölme işleminin bir tarafında ondalık veri tipi kullanmak yeterlidir
            Console.WriteLine("Bölüm 3: " + bolum3);



            double sayi18 = 14;
            double sayi19 = 5;
            double bolum4 = sayi18 / sayi19; // bolum4 değeri 2.8 olur, bölme işleminin bir tarafında veya iki tarafında da ondalık veri tipi kullanmak yeterlidir
            Console.WriteLine("Bölüm 4: " + bolum4);



            int sayi20 = 15;
            sayi20 /= 5; // sayi20 = sayi20 / 5, sayi20 değeri 3 olur
            Console.WriteLine($"Sayı 20: {sayi20}");
            #endregion



            #region Kalan (Modulus (Mod)) İşlemi
            int sayi21 = 21;
            int sayi22 = 2;
            int kalan = sayi21 % sayi22; // sayi21'in sayi22'ye yani 21'in 2'ye bölümünden kalan 1'dir 
            Console.WriteLine("Kalan: " + kalan);



            int sayi23 = 23;
            sayi23 %= 3; // sayi23 = sayi23 % 3, sayi23 değeri 2 olur
            Console.WriteLine($"Sayı 23: {sayi23}");
            #endregion
        }
    }
}