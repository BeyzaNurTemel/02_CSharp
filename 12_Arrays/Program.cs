// Arrays (Diziler)

namespace _12_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array'ler içerisinde hiç eleman olmayan, bir veya daha fazla eleman olan bir kolleksiyon olarak değerlendirilebilir
            // array'lerin oluşturuldukları eleman sayıları sabittir, değiştirilemez,
            // array'ler referans tiptir



            #region One-Dimensional Arrays (Tek Boyutlu Diziler)
            string[] ogrenciler = new string[3]; // hafızada bir ogrenciler adında array tipinde ([]) değişken tanımladık, bir de new'leme işlemi üzerinden 3 elemanlı bir dizi oluşturduk,
                                                 // ogrenciler değişkeni artık bu 3 elemanlı diziyi göstermektedir (refere etmektedir),
                                                 // refere edilen bu dizinin eleman sayısı her zaman 3 olacaktır, değiştirilemez

            ogrenciler[0] = "Çağıl"; // [0]: dizinin elemanlarına ulaşmak için 0'dan başlayarak her bir eleman için otomatik birer birer artan değer verilir (index),
                                     // C#'ta bütün kolleksiyon yapılarının index'i 0'dan başlar, dizinin ilk elemanına Çağıl değerini atadık
            ogrenciler[1] = "Leo"; // dizinin ikinci elemanına Leo değerini atadık
            ogrenciler[2] = "Angel"; // dizinin üçüncü elemanına Angel değerini atadık

            Console.WriteLine(ogrenciler[1]); // konsola Leo yazdıracaktır, 0 index'i üzerinden Çağıl, 2 index'i üzerinden de Angel yazdırılabilir

            //Console.WriteLine(ogrenciler[3]); // index out of bounds exception (hata) fırlatacaktır çünkü dizide bu index'te bir eleman bulunmamaktadır, hata vermemesi için comment'e aldık,
                                                // bu hata bir Run Time Error'dır (çalışma zamanı hatası) çünkü uygulama çalıştıktan sonra bu hata ortaya çıkar

            //for (int i = 0; i < 3; i++)
            for (int i = 0; i < ogrenciler.Length; i++) // bir üst satırdaki döngüde olduğu gibi dizinin eleman sayısını 3 yazmak yerine dizinin eleman sayısına dizinin Length özelliği ile ulaşmak doğrudur
                                                        // for döngüsü genelde index'li kolleksiyonlarda her bir elemana index üzerinden ulaşmak için daha çok tercih edilir
            {
                Console.WriteLine(ogrenciler[i]); // her bir öğrenciyi sırasıyla döngü üzerinden konsola yazdırır
            }

            // bir dizideki son index = dizinin eleman sayısı - 1



            int[] sayilar; // int dizisi tipinde sayilar değişkenini tanımladık (declaration)
            sayilar = new int[4]; // sayilar değişkeninin refere ettiği diziyi 4 elemanlı olarak oluşturduk (initialization)
            sayilar[0] = 11;
            sayilar[1] = 22;
            sayilar[2] = 33;
            sayilar[3] = 11; // dizilerde farklı index'lerdeki elemanlar aynı değeri taşıyabilir

            //for (int i = 0; i < sayilar.Length; i++)
            for (int i = 0; i <= sayilar.Length - 1; i++) // döngünün bitme koşulu (i <= sayilar.Length - 1) istenirse bir üst satırdaki yerine bu satırdaki gibi de yazılabilir, bu kullanım pek tercih edilmez
            {
                Console.WriteLine($"{i + 1}. sayı: {sayilar[i]}");
            }



            //decimal[] ondalikSayilar = new decimal[5] // diziler new'lenirken elemanları süslü parantez içerisinde doldurulabilir
            decimal[] ondalikSayilar = new decimal[] // burada elemanlar new'lenirken doldurulduğundan dizinin eleman sayısını yazmak zorunlu değildir
            {
                9.9M,
                8.8M,
                7.7M,
                6.6M,
                5.5M
            };

            for (int i = 0; i < ondalikSayilar.Length; i++)
            {
                Console.WriteLine(ondalikSayilar[i]);
            }



            char[] karakterler = { 'Ç', 'A', 'Ğ', 'I', 'L' }; // diziler new yazılmadan da elemanları doldurulacak şekilde oluşturulabilir,
                                                              // burada arka planda yine new'leme işlemi yapılmaktadır

            for (int karakterIndex = 0; karakterIndex < karakterler.Length; karakterIndex++)
            {
                Console.Write(karakterler[karakterIndex]);
            }
            Console.WriteLine(); // aşağıdaki kodların çalışmaya bir alt satırdan devam etmesi için



            // bir dizideki sayısal elemanların toplamı
            double[] numbers = new double[9]
            {
                10.1,
                20.2,
                30.3,
                40.4,
                50.5,
                60.6,
                70.7,
                80.8,
                90.9
            };

            // 1. yöntem:
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Sum is " + sum);

            // 2. yöntem:
            Console.WriteLine("Sum is: " + numbers.Sum()); // kolleksiyonların çoğunda ki diziler de buna dahil tanımlı olan Sum methodu üzerinden o kolleksiyonun elemanları toplanabilir
            #endregion



            #region Multi-Dimensional Arrays (Çok Boyutlu Diziler)
            // 2 Boyutlu Diziler

            // bölgeler ve şehirler:
            /*
            Marmara     İstanbul
            İç Anadolu  Ankara
            Ege         İzmir
            */
            string[,] bolgelerVeSehirler = new string[3, 2] // bir yukarıdaki tabloya bakıldığında 3 satır, 2 sütun sayısını gösterir
            {
                { "Marmara", "İstanbul" }, // eleman index'leri: Marmara: 0, 0; İstanbul: 0, 1
                { "İç Anadolu", "Ankara" }, // İç Anadolu: 1, 0; Ankara: 1, 1
                { "Ege", "İzmir" } // Ege: 2, 0; İzmir: 2, 1
            };

            // İç Anadolu - Ankara satırını yazdıralım
            Console.WriteLine(bolgelerVeSehirler[1, 0] + " - " + bolgelerVeSehirler[1, 1]);

            // tüm bölge ve şehirleri satır satır yazdıralım
            for (int satirIndex = 0; satirIndex <= bolgelerVeSehirler.GetUpperBound(0); satirIndex++) // GetUpperBounds(0) en son satır index'ini yani 2'yi döner, methoddaki 0 parametresi 1. boyut parametresidir
            {
                for (int sutunIndex = 0; sutunIndex <= bolgelerVeSehirler.GetUpperBound(1); sutunIndex++) // GetUpperBounds(1) en son sütun index'ini yani 1'i döner, methoddaki 1 parametresi 2. boyut parametresidir
                {
                    Console.Write(bolgelerVeSehirler[satirIndex, sutunIndex] + " ");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}