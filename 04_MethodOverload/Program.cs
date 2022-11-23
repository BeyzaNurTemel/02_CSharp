// Method Overload (Aynı İsimde Fakat Farklı İmzalarda Birden Çok Method Oluşturulması)

namespace _04_MethodOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Method Çağrımları
            int sonuc1;
            double sonuc2;



            sonuc1 = Topla(1, 2);
            Console.WriteLine(sonuc1); // konsola 3 yazdıracaktır



            sonuc2 = Topla(1.1, 2.2);
            Console.WriteLine(sonuc2); // konsola 3,3 yazdıracaktır



            sonuc2 = Topla(1.1, 2.2, 3.3);
            Console.WriteLine(sonuc2); // konsola 6,6 yazdıracaktır



            sonuc2 = Topla(1.1, 2.2, 3.3, 4.4);
            Console.WriteLine(sonuc2); // konsola 11 yazdıracaktır
            #endregion
        }



        #region Methodlar
        static int Topla(int sayi1, int sayi2) // int Topla(int sayi1, int sayi2); method imzasıdır,
                                               // farklı parametre tipleri, farklı dönüş tipi ve farklı parametre sayıları üzerinden aynı isimde yeni methodlar oluşturulup çağrılabilir
        {
            return sayi1 + sayi2;
        }



        static double Topla(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }



        static double Topla(double sayi1, double sayi2, double sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }



        //static double Topla(double sayi1, double sayi2, double sayi3, double sayi4 = 4) // method overload yaparken default parametre kullanımına dikkat edilmelidir ki bu satırda yanlıştır,
                                                                                          // buradaki gibi yapıldığında çağrımda bir üstteki methodla çakışacaktır
        static double Topla(double sayi1, double sayi2, double sayi3, double sayi4)
        {
            return sayi1 + sayi2 + sayi3 + sayi4;
        }
        #endregion
    }
}