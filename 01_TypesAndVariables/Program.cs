// Types and Variables (Tipler ve Değişkenler)

namespace _02_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Comments (Yorumlar)
            // bu bir yorumdur, kodlar derkenirken (build işlemi) dikkate alınmaz

            /* 
                bu da bir yorumdur 
            */
            #endregion



            #region Kodları Derleme (Build) ve Çalıştırma (Run, Execute)
            // Build (derleme) işlemi kodların derlenmesini yani makine diline dönüştürülüp çalıştırılabilir bir dosya (.exe) veya diğer uygulamalarda kullanılabilecek bir kütüphane (.dll) oluşturulmasını sağlar.
            // Syntax (söz dizimi kuralları) hatası varsa build edilemez, derleme hatası (Compile Time Error) meydana gelir.

            // Run (execute) işleminde yine öncelikle kodlar syntax hatası yoksa build edilir, uygulama tipine göre örneğin bu solution'da olanlar gibi konsol uygulamalarında derlenen kodlar
            // .exe dosyası üzerinden çalıştırılır.
            #endregion



            #region Konsola Değer Yazdırma
            Console.WriteLine("Hello, World!"); // Konsola Hello, World! yazdırır.
            #endregion



            #region Value Types (Değer Tipler):
            // 1 byte = 8 bits
            #region Integer (Tam Sayı Veri Tipi)
            int number1 = 10; // 32 bits. -2 billion to 2 billion (billion: milyar)
                              // değişken (number1) tanımlama ve değişkene ilk değer (10) atama işlemi,
                              // değişken tanımlama bir kere yapılır, aynı ad ile başka değişken tanımlanamaz, tanımlanan değişkene atama işlemi istenildiği kadar yapılabilir,
                              // örneğin 10 verisinin default (varsayılan) veri tipi int'tir
            Console.WriteLine("Number 1 is {0}", number1); // metinsel veri oluşturma 1. yöntem, {0}: placeholder (yer tutucu), {0} yer tutucusuna number1'in değeri (10) yazdırılır

            Console.WriteLine("Integer minimum value: {0}, maximum value: {1}", int.MinValue, int.MaxValue); // {0} yer tutucusuna int.MinValue, {1} yer tutucusuna ise int.MaxValue değerleri yazdırılır

            int sayi1; // variable declaration (değişken tanımlama)
            sayi1 = 1; // variable value assignment (değişkene değer atama)
            Console.WriteLine("Sayı 1: " + sayi1); // +: concatenation operator (arka arkaya metinsel veri ile birleştirme operatörü),
                                                   // metinsel veri oluşturma 2. yöntem

            sayi1 = 11; // sayi1 değişkeninin son güncel değeri 1 yerine 11 olur
            Console.WriteLine($"Sayı 1: {sayi1}"); // metinsel veri oluşturma 3. yöntem



            uint number2 = 20; // 32 bits. 0 to 4 billion (u: unsigned, yani - işaretsiz)
            Console.WriteLine("Number 2: " + number2);
            #endregion



            #region Long (Tam Sayı Veri Tipi)
            long number3 = 2147483648; // 64 bits. -9 quintillion to 9 quintillion (quintillion: kentilyon)
            Console.WriteLine("Number 3 is " + number3);



            ulong number4 = 40; // 64 bits. 0 to 18 quintillion
            Console.WriteLine("Number 4: " + number4);
            #endregion



            #region Short (Tam Sayı Veri Tipi)
            short number5 = -19; // 16 bits. -32,768 to 32,767
            Console.WriteLine("Number 5: " + number5);



            ushort number6 = 19; // 16 bits. 0 to 65,535
            Console.WriteLine("Number 6: " + number6);
            #endregion



            #region Byte (Tam Sayı Veri Tipi)
            byte number7 = 255; // 8 bits. 0 to 255
            Console.WriteLine("Number 7: " + number7);



            sbyte number8 = -128; // 8 bits. -128 to 127
            Console.WriteLine("Number 8: " + number8);
            #endregion



            #region Boolean (Tam Sayı Veri Tipi: true = 1, false = 0 olduğu için, ancak Mantıksal (Doğruluk) Veri Tipi olarak da adlandırılır)
            bool condition = true; // 1 bit (1 byte in C#). true (1) or false (0)
            Console.WriteLine("Condition: " + condition); // konsola Condition: True yazdırır, değişkenin verisi true olmasına rağmen konsola yazdırırken True olarak formatlar



            condition = false;
            Console.WriteLine($"New condition: {condition}"); // konsola Condition: False yazdırır
            #endregion



            #region Char (Karakter Veri Tipi)
            char character = 'A'; // ASCII characters (8 bits), Unicode characters (16 bits) in C#
                                  // İngilizce bir klavyedeki her bir karakterin ASCII tablosunda sayısal bir ondalık değeri vardır,
                                  // bu ondalık değere değişkenin başına (int) yazılarak birbirlerine uyumlu tip dönüşümü (casting) üzerinden ulaşılabilir,
                                  // A karakterinin ASCII tablosundaki ondalık sayısal değeri 65'tir,
                                  // Türkçe karakterler (Ö, ö, Ç, ç, Ş, ş, İ, ı, Ğ, ğ, Ü, ü) unicode karakterlerdir
            Console.WriteLine("Character is: " + character + ", ASCII code is: " + (int)character);
            #endregion



            #region Double (Ondalık Sayı Veri Tipi)
            double number9 = 1.7; // 64 bits. 15 significant digits. For the double datatype, positive values are 4.9 x 10^-324 to 1.8 x 10^308. Negative values are -1.8 x 10^308 to -4.9 x 10^-324
                                  // ondalık veriler için programlama dillerinde her zaman . ayracı kullanılır,
                                  // örneğin 1.7 verisinin default (varsayılan) veri tipi double'dır
            Console.WriteLine("Number 9: " + number9); // konsola eğer bilgisayarın bölgesel ayarı Türkçe ise Number 9: 1,7 İngilizce ise Number 9: 1.7 şeklinde formatlayarak yazdırır
            #endregion



            #region Float (Ondalık Sayı Veri Tipi)
            float number10 = -12.34567F; // 32 bits. 7 significant digits. For the float datatype, positive values are 1.4 x 10^-45 to 3.4 x 10^38. Negative values are -3.4 x 10^38 to -1.4 x 10^-45
            number10 = 1.2f; // sonda F veya f kullanılabilir
            Console.WriteLine("Number 10 is: " + number10 + ", minimum value: " + float.MinValue + ", maximum value: " + float.MaxValue);
            #endregion



            #region Decimal (Ondalık Sayı Veri Tipi)
            decimal number11 = 11.77M; // 24 * 8 bits. 28 to 29 significant digits. For the decimal datatype, positive values are 1.0 x 10^-28 to 7.9 x 10^28. Negative values are -7.9 x 10^28 to -1.0 x 10^-28
            number11 = -3.2m; // sonda M veya m kullanılabilir
            Console.WriteLine("Number 11: " + number11);
            #endregion



            #region Enum (Sıralı Küme Veri Tipi)
            Console.WriteLine($"Day is {Days.Monday}, day value is {(int)Days.Monday}"); // (int) ile birbirlerine uyumlu tip dönüşümü üzerinden Monday elemanının sahip olduğu 0 değerine ulaşılabilir



            Console.WriteLine("Gün: {0}, gün değeri: {1}", Gunler.Cuma, (int)Gunler.Cuma);



            Console.WriteLine("Cinsiyet: " + Cinsiyet.Kadın + ", cinsiyet değeri: " + (int)Cinsiyet.Kadın);
            #endregion
            #endregion



            #region Reference Types (Referans Tipler):
            #region String (Metinsel Veri Tipi, Karakter Dizisi)
            string characters = "Ankara"; // 4 byte address. Length up to 2 billion bytes. A string variable in C# cannot be declared as fixed length. Array of characters
            Console.WriteLine("String is: " + characters);
            #endregion
            #endregion



            #region Var (Atanan değere göre veri tipini otomatik tanımlar, yukarıdaki tüm tipler için kullanılabilir)
            var number12 = 123;
            Console.WriteLine("Number 12 is: " + number12);



            number12 = 'A';
            Console.WriteLine("New number 12 is: " + number12);



            var character12 = 'A'; // yalnızca tek karakter yazılır.
            Console.WriteLine("Character is: " + character12);



            var string12 = "Çağıl";
            Console.WriteLine("String is: " + string12);
            #endregion



            #region Veri Tiplerinin C# Yapısal Karşılıkları
            Int32 degisken1; // veri tipi karşılığı int degisken1;
            Int64 degisken2; // veri tipi karşılığı long degisken2;
            Int16 degisken3; // veri tipi karşılığı short degisken3;
            Byte degisken4; // veri tipi karşılığı byte degisken4;
            Boolean degisken5; // veri tipi karşılığı bool degisken5;
            Double degisken6; // veri tipi karşılığı double degisken6;
            Single degisken7; // veri tipi karşılığı float degisken7;
            Decimal degisken8; // veri tipi karşılığı decimal degisken8;
            Char degisken9; // veri tipi karşılığı char degisken9;
            String degisken10; // veri tipi karşılığı string degisken10;
            #endregion
        }
    }



    #region Enum (Sıralı Küme Veri Tipi)
    enum Days
    {
        Monday, // default value: 0
        Tuesday, // default value: 1
        Wednesday, // default value: 2
        Thursday, // default value: 3
        Friday, // default value: 4
        Saturday, // default value: 5
        Sunday // default value: 6
    }



    enum Gunler
    {
        Pazartesi = 1, // value: 1
        Salı, // value: 2
        Çarşamba, // value: 3
        Perşembe, // value: 4
        Cuma, // value: 5
        Cumartesi, // value: 6
        Pazar // value: 7
    }



    enum Cinsiyet
    {
        Kadın = 11, // value: 11
        Erkek = 22 // value: 22
    }
    #endregion
}