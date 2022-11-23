// Ternary Conditional Operator (? :)

namespace _08_TernaryConditionalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Algoritma Örnek 1: Sayı Pozitif, Negatif veya Nötr
            /*
            1. başla
            2. kullanıcıya -32000 ile 32000 aralığında bir tam sayı sorulur
            3. kullanıcıdan tam sayı alınır
            4. sayıyı kontrol edecek bir methodda eğer sayı sıfırdan büyük ise bir sonuç değişkenine sayı pozitif
            5. eğer sayı sıfırdan küçük ise bir sonuç değişkenine sayı negatif
            6. eğer sayı sıfıra eşitse bir sonuç değişkenine sayı nötr atanır
            7. atanan sonuç methoddan geri döndürülerek ekrana yazdırılır
            8. bitiş
            */
            short sayi;
            string sonuc;
            Console.Write("-32.000 ile 32.000 arasında bir tam sayı giriniz: ");
            //sayi = Convert.ToInt16(Console.ReadLine());
            sayi = short.Parse(Console.ReadLine()); // Convert.To methodlarına alternatif olarak string sayı dönüşümleri için sayısal tiplerin (int, long, double, vb.) Parse methodu da kullanılabilir
            sonuc = KontrolEt(sayi);
            Console.WriteLine(sonuc);



            // Algoritma Örnek 2: Tek Sayı, Çift Sayı
            /*
            1. başla
            2. kullanıcıya 1 ile 100 aralığında bir tam sayı sorulur
            3. kullanıcıdan tam sayı alınır
            4. sayıyı kontrol edecek bir methodda sayının 1 ile 100 aralığında olup olmadığı kontrol edilir
            5. eğer sayı 1 ile 100 aralığında değilse sonuç değişkenine sayı aralık dışı
            6. eğer sayı 1 ile 100 aralığında ise ve eğer sayının ikiye bölümünden kalan sıfır ise sonuç değişkenine çift sayı
            7. eğer sayının ikiye bölümünden kalan sıfır değil ise sonuç değişkenine tek sayı atanır
            8. atanan sonuç methoddan geri döndürülerek ekrana yazdırılır
            9. bitiş
            */
            string input, output;
            Console.Write("Enter a number (between 1 and 100): ");
            input = Console.ReadLine();
            Console.WriteLine(CheckNumber(input));
        }



        // Algoritma Örnek 1: Sayı Pozitif, Negatif veya Nötr
        static string KontrolEt(short sayi)
        {
            string sonuc = sayi > 0 ? "Sayı pozitif." : sayi < 0 ? "Sayı negatif." : "Sayı nötr."; // ? if, : else if veya else gibi düşünülebilir
            return sonuc;
        }



        // Algoritma Örnek 2: Tek Sayı, Çift Sayı
        static string CheckNumber(string input)
        {
            long number = long.Parse(input);

            // 1. yöntem:
            //string result;
            //if (!(number >= 1 && number <= 100))
            //    result = "Number out of range.";
            //else
            //    result = number % 2 == 0 ? "Even number." : "Odd number.";
            //return result;

            // 2. yöntem:
            if (!(number >= 1 && number <= 100))
                return "Number out of range."; // belirtilen koşul sağlandığı an aşağıdaki kodların çalıştırılmaması için return ile method sonlandırılabilir, 1. yönteme göre daha kısa ve iyi bir yöntem
            return number % 2 == 0 ? "Even number." : "Odd number.";
        }
    }
}