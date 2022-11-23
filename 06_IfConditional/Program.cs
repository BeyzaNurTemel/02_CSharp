// if Conditional (if Şart Yapısı)

namespace _06_Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Konsoldan Değer Okuma
            Console.Write("Adınızı ve soyadınızı giriniz: "); // Write methodu değeri yazdırdıktan sonra WriteLine gibi bir alt satıra geçmez
            string adSoyad = Console.ReadLine(); // konsoldan değer okunur ve adSoyad değişkenine atanır
            Console.WriteLine("Adınız ve soyadınız: " + adSoyad);
            #endregion



            #region Operatörler
            // Logical operators (Mantıksal operatörler): && (and), || (or), ! (not)
            // Relational operators (İlişkisel operatörler): ==, !=, >=, <=, >, <
            // Arithmetic operators (Aritmetik operatörler): +, -, *, /, %
            // Assignment operator (Atama operatörü): =
            #endregion



            #region Logical Operators (Mantıksal Operatörler)
            /* Önermeler: 1 = true, 0 = false
             * p    q       ve (&&)
             * --------------------
             * 0    0       0
             * 0    1       0
             * 1    0       0
             * 1    1       1
             * 
             * p    q     veya (||)
             * --------------------
             * 0    0       0
             * 0    1       1
             * 1    0       1
             * 1    1       1
            */
            #endregion



            #region if Şart Yapısı ve Algoritmalar

            // Algoritma: Bir problemin çözümü için oluşturulan iyi tanımlanmış adımlardır. Amaç problemi parçalara ayırıp her bir parçayı ayrı ayrı çözerek problemin çözülmesini sağlamaktır.
            // Algoritma oluşturmak için istenirse kağıt üzerinde istenirse de Akış Diyagramları (Flow Chart) kullanılabilir. Algoritma oluşturulduktan sonra kod üzerinde uygulanır.



            int sayi = 10;
            if (sayi == 10)
                Console.WriteLine("On");
            // sayi == 10 true sonucunu vereceği için if içerisindeki satırlar çalıştırılarak ekrana On yazdırılır. eğer ; ile biten tek kod bloğu kullanılacaksa süslü parantez ({, }) kullanmak şart değildir



            sayi = 20;
            if (sayi == 10)
            {
                Console.WriteLine("On");
            }
            // sayi == 10 false sonucunu vereceği için if içerisindeki satırlar çalıştırılmayacaktır ve ekranda herhangi bir çıktı olmayacaktır



            sayi = 30;
            if (sayi == 10)
            {
                Console.WriteLine("On");
            }
            else // yukarıdaki if koşulunun değili yani sayi != 10 veya !(sayi == 10)
            {
                Console.WriteLine("On değil");
            }
            // sayi == 10 false sonucunu vereceği için else içerisindeki satırlar çalıştırılarak konsola On değil yazdırılacaktır



            // Algoritma Örnek 1: Yaş Grubu
            /*
            1. başla
            2. kullanıcıya yaş sorulur
            3. kullanıcıdan yaşı alınır
            4. eğer kullanıcının yaşı 0 ile 30 arasında ise genç
            5. eğer kullanıcının yaşı 31 ile 60 arasında ise orta yaşlı
            6. eğer kullanıcının yaşı 60'tan büyük ise yaşlı olarak belirlenip
            7. ekrana kullanıcının yaşı ile yaş karşılığı yazdırılır
            8. bitiş
            */
            string yasSonucu; // aşağıdaki tüm kodlar çalıştırıldıktan sonra ekrana yazdıracağımız yaşın karşılığı, tüm if, else if ve else içerisinde değeri mutlaka atanmalıdır
            Console.Write("Yaşınız: ");
            string giris = Console.ReadLine();
            int yas = Convert.ToInt32(giris); // yaş sayısal bir veri olduğu için kullanıcından Console.ReadLine ile metinsel veri (string) alındıktan sonra
                                              // Convert.ToInt32 methodu ile integer'a dönüştürülüp yas değişkenine atanır
            if (yas >= 0 && yas <= 30) // yas 0 ve 30 aralığında ise (0 ve 30 dahil),
                                       // örnek 1: yas 15 için yas >= 0 = true, yas <= 30 = true, true && true = true sonucunu verir ve if içerisindeki kodlar çalıştırılır,
                                       // örnek 2: yas 35 için yas => 0 = true, yas <= 30 = false, true && false = false sonucunu verir ve if atlanır
            {
                yasSonucu = "Genç";
            }
            else if (yas >= 31 && yas <= 60) // yas 31 ve 60 aralığında ise (31 ve 60 dahil),
                                             // aralık kesişmelerine dikkat edilmelidir yani kesişme olmamalıdır, yukarıdaki if koşulunda üst sınır 30, bu satırdaki else if koşulunda alt sınır 31 olmalıdır
            {
                yasSonucu = "Orta yaşlı";
            }
            else // yukarıdaki if ve else if koşullarının değili yani yas < 0 || yas > 60
            {
                yasSonucu = "Yaşlı";
            }
            Console.WriteLine($"Yaşınız: {yas} ({yasSonucu})");



            // Algoritma Örnek 2: Not Sonucu
            /*
            1. başla
            2. kullanıcıya 0 ile 100 arasında not sorulur
            3. kullanıcından not alınır
            4. eğer kullanıcının notu 0'dan küçük veya 100'den büyükse ekrana geçersiz not yazdırılır
            5. eğer kullanıcının notu 0 ile 59 arasında ise ekrana kaldı yazdırılır,
            6. eğer kullanıcının notu 60 ile 100 arasında ise ekrana geçti yazdırılır
            7. bitiş
            */
            Console.Write("Not giriniz: ");
            int not = Convert.ToInt32(Console.ReadLine()); // Console.ReadLine methodu ile kullanıcıdan giriş aldındıktan sonra Convert.ToInt32 methodu ile integer'a dönüştürülüp sonucu değişkene atanabilir

            // 1. yöntem:
            //if (not < 0 || not > 100)
            //    Console.WriteLine("Geçersiz not");
            //else if (not >= 0 && not < 60)
            //    Console.WriteLine("Kaldı");
            //else
            //    Console.WriteLine("Geçti");

            // 2. yöntem:
            if (not < 0 || not > 100)
            {
                Console.WriteLine("Geçersiz not");
            }
            else // yukarıdaki if koşulu yani (not < 0 || not > 100)'ün değili: !(not < 0 || not > 100): (not >= 0 && not <= 100)
                 // herhangi bir koşulun değili alınırken &&: ||, ||: &&, =: !=, !=: =, >: <=, <: >=, >=: <, <=: > olarak dönüştürülür
            {
                if (not >= 0 && not < 60) // herhangi bir if veya else içerisinde istenildiği kadar if veya if else blokları kullanılabilir
                {
                    Console.WriteLine("Kaldı");
                }
                else // yukarıdaki if koşulu yani (not => 0 && not < 60)'ın değili: !(not => 0 && not < 60): (not < 0 || not >= 60)
                {
                    Console.WriteLine("Geçti");
                }
            }

            #endregion
        }
    }
}