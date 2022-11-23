// Methods (Methodlar)

namespace _03_Methods
{
    internal class Program
    {
        static void Main(string[] args) // Main de bir methoddur
        {
            #region Method Çağrımları
            DisplayHello(); // 1, DisplayHello üzerine cursor konduktan sonra klavyede F12 tuşuna basılarak veya farenin sağ tuşuna tıklayıp Go To Implementation denilerek aşağıdaki DisplayHello methoduna gidilebilir



            Sum(1, 2); // 2



            Console.WriteLine("PI: " + GetPi()); // 3, WriteLine da bir methoddur ve method içerisinde başka bir method çağrılabilir, içeride çağrılan methodun sonucu dışarıdaki methodda kullanılır



            int number1 = 7;
            short number2 = 4;
            long subtractResult = Subtract(number1, number2); // 4, genelde methodlar çağrıldıktan sonra dönen sonuç methodun dönüş tipi ile aynı tipte olan bir değişkende saklanır ve daha sonra kullanılır
            Console.WriteLine("Subtract Result: " + subtractResult);



            string calisan = KurumaGoreCalisanGetir("Çağıl", "Alsaç"); // 5
            Console.WriteLine(calisan);



            calisan = KurumaGoreCalisanGetir("Leo", "Alsaç", "Apple"); // 5, eğer default olarak tanımlanan parametreye değer gönderilirse method içerisinde gönderilen değer kullanılır
            Console.WriteLine(calisan);



            Console.WriteLine(DepartmanaGoreCalisanGetir("Çağıl", "Alsaç")); // 5
            Console.WriteLine(DepartmanaGoreCalisanGetir("Çağıl", "Alsaç", "Yazılım")); // 5



            Console.WriteLine(DepartmanaGoreCalisanGetir("Leo", "Alsaç", "Apple", "İletişim")); // 5
            #endregion
        }



        #region Methodlar
        // 1) Parantez içerisine herhangi bir parametre almayan ve geriye herhangi bir sonuç dönmeyen methodlar, genelde ekrana veri yazdırma için kullanılır
        static void DisplayHello() // Bazı durumlar hariç static yazmaya gerek yoktur, yukarıdaki Main methodu static olduğu için burada yazmamız gerekiyor
        {
            Console.WriteLine("Hello!");
        }



        // 2) Parantez içerisine bir veya birden fazla parametre alan ve geriye herhangi bir sonuç dönmeyen methodlar
        static void Sum(int number1, int number2) // parametre adlarının (number1 ve number2) bir önemi yoktur, önemli olan parametrelerin sırası ve tipleridir, parametre tipleri farklı olabilir
        {
            int result = number1 + number2;
            Console.WriteLine($"{number1} + {number2} = {result}");
        }



        // 3) Parantez içerisine herhangi bir parametre almayan ve geriye herhangi bir tipte sonuç dönen methodlar
        static double GetPi() // methoddan geriye veri dönebilmek için return yazılır ve method başında dönülecek verinin tipi belirtilir
        {
            return 3.14;
        }



        // 4) Parantez içerisine bir veya birden fazla parametre alan ve geriye herhangi bir tipte sonuç dönen methodlar
        static long Subtract(int number1, short number2) // Sum ve Main methodlarındaki number1 ve number2 parametreleri ile Subtract methodundaki number1 ve number2 parametrelerinin birbirleriyle bağlantısı yoktur,
                                                         // bu parametreler sadece içerisinde kullanıldıkları methodda geçerlidir
        {
            return number1 - number2;
        }



        // 5) Default (varsayılan) parametreli methodlar
        static string KurumaGoreCalisanGetir(string ad, string soyad, string kurum = "Microsoft") // default değerler her zaman methodun en son parametrelerine verilir, istenirse tüm parametrelere default değer atanabilir
        {
            return ad + " " + soyad + " isimli çalışan " + kurum + " kurumunda çalışmaktadır.";
        }



        static string DepartmanaGoreCalisanGetir(string ad, string soyad, string kurum = "Microsoft", string departman = "Eğitim")
        {
            return ad + " " + soyad + " isimli çalışan " + kurum + " kurumunda " + departman + " departmanında çalışmaktadır.";
        }
        #endregion
    }
}