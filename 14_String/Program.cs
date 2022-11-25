// string data type (string veri tipi)

using _14_String.Demos;
using System.Reflection.Metadata;

namespace _14_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string metinsel verileri tutumak için kullanılır, karakter dizisidir (char[]), referans tiptir.
            // tüm string methodları büyük küçük harf duyarlıdır.



            #region Karakter Dizisi, Concatenation ve Format (Metinsel Verileri Ard Arda Ekleme ve Formatlama)
            string sehir1 = "Ankara";
            Console.WriteLine(sehir1[0]); // konsola A yazdırır
            foreach (char s in sehir1) // konsola Ankara yazdırır
            {
                Console.Write(s);
            }

            // Bir metinsel veriyi tersine çevirme:
            Console.WriteLine();
            string word = "YAZILIM";
            string reversedWord = ""; // içinde hiç bir karakter olmayan (boş) metinsel veri
            for (int i = 6; i >= 0; i--) // 6: karakter sayısı - 1 = son index
            {
                reversedWord += word[i];
            }
            Console.WriteLine(reversedWord); // konsola MILIZAY yazdırır

            string sehir2 = "İstanbul";
            string sehir3 = sehir1 + " " + sehir2; // string concatenation (metinsel verileri ard arda ekleme)
            Console.WriteLine(sehir3); // konsola "Ankara İstanbul" yazdırır

            string sehir4 = string.Format("{0} {1}", sehir2, sehir1); // {0} ve {1} placeholder (yer tutucu), {0}: İstanbul, {1}: Ankara olacak
            Console.WriteLine(sehir4); // konsola "İstanbul Ankara" yazdırır

            string sehir5 = "İzmir";
            Console.WriteLine($"Ege'nin incisi: {sehir5}"); // konsola "Ege'nin incisi: İzmir" yazdırır
                                                            // placeholder'lar yerine string verinin başına $ eklenerek istenilen değişkenler süslü parantez içerisine gönderilebilir
            #endregion



            #region Length (Metinsel Veri Karakter Sayısı) ve Replace (Değiştirme) Methodu
            string isim1 = "Çağıl Alsaç";
            int isim1Length = isim1.Length; // string tipindeki verinin karakter sayısını (uzunluğunu) dönen özellik
            Console.WriteLine(isim1Length); // konsola 11 yazdırır

            string isim2 = isim1.Replace("Çağıl", "Leo");
            Console.WriteLine(isim2); // konsola "Leo Alsaç" yazdırır
            #endregion



            #region StartsWith (Başlayan), EndsWith (Biten) ve Contains (İçeren) Methodları
            string isim3 = "Bill Gates";

            // bu üç method da case sensitive (büyük küçük harf duyarlı) ve bool sonuç döner

            if (isim3.StartsWith("B")) // eğer parametre "b" olsaydı StartsWith methodu false dönecekti,
                                       // bu örnekte true dönecek ve konsola "İsim B ile başlıyor." yazdıracak
                Console.WriteLine("İsim B ile başlıyor.");
            else
                Console.WriteLine("İsim B ile başlamıyor.");

            Console.WriteLine(isim3.EndsWith("Jobs") ? "İsim Jobs ile bitiyor." : "İsim Jobs ile bitmiyor."); // konsola "İsim Jobs ile bitmiyor." yazdırır

            if (isim3.Contains("ga")) // konsola "İsim ga içermiyor." yazdırır
                Console.WriteLine("İsim ga içeriyor.");
            else
                Console.WriteLine("İsim ga içermiyor.");

            if (isim3.Contains("ate"))  // konsola "İsim ate içeriyor." yazdırır
                Console.WriteLine("İsim ate içeriyor.");
            else
                Console.WriteLine("İsim ate içermiyor.");
            #endregion



            #region IndexOf (İçerdiği Metin Index'i) ve LastIndexOf (İçerdiği Metin Son Index'i) Methodları
            // Bir metinsel veride girilen karakterin tekil olup olmadığını bulma:
            Console.Write("Kelime: ");
            string kelime = Console.ReadLine();
            Console.Write("Tekil olup olmadığı bulunacak harf: ");
            string harf = Console.ReadLine();
            int harfIndex = kelime.IndexOf(harf); // kelimenin ilk harfinden başlayarak girilen harfi bulduğu index'i döner
            int harfLastIndex = kelime.LastIndexOf(harf); // kelimenin ilk harfinden başlayarak girilen harfi bulduğu son index'i döner
            if (harfIndex == harfLastIndex)
                Console.WriteLine("Harf kelimede tekildir.");
            else
                Console.WriteLine("Harf kelimede tekil değildir.");
            // ankara kelimesi için a harfi girilirse IndexOf methodu: 0, LastIndexOf methodu 5 döner, eşit olmadıkları için harf tekil değildir
            // ankara kelimesi için r harfi girilirse IndexOf methodu: 4, LastIndexOf methodu 4 döner, eşit oldukları için harf tekildir
            #endregion



            #region Insert (Ekleme) ve Remove (Çıkarma) Methodları
            string mesaj = "Dünya";
            mesaj = mesaj.Insert(5, "!");
            Console.WriteLine(mesaj); // "Dünya" sonuna 5. index üzerinden "!" ekler ve konsola "Dünya!" yazdırır
            mesaj = mesaj.Insert(0, "Merhaba ");
            Console.WriteLine(mesaj); // "Dünya!" başına 0. index üzerinden "Merhaba " ekler ve konsola "Merhaba Dünya!" yazdırır
            mesaj = mesaj.Insert(8, "Güzel ");
            Console.WriteLine(mesaj); // "Merhaba Dünya!" içerisine 8. index üzerinden "Güzel " ekler ve konsola "Merhaba Güzel Dünya!" yazdırır

            mesaj = mesaj.Remove(8, 6);
            Console.WriteLine(mesaj); // "Merhaba Güzel Dünya!" içerisinde 8. index'ten başlayıp 6 karakteri çıkarır ve konsola "Merhaba Dünya!" yazdırır
            mesaj = mesaj.Remove(7);
            Console.WriteLine(mesaj); // "Merhaba Dünya!" içerisinde 7. index'ten başlar ve sona kadar tüm karakterleri çıkarır, konsola da "Merhaba" yazdırır
            #endregion



            #region Substring Methodu
            // bir string (karakter kümesi) içerisinde bulunan herhangi bir alt string'i (alt karakter kümesini) bulmak için kullanılır

            // Bir abone numarası üzerinden abone tipi, bina ve daire numaralarını bulma:
            // Örnek abone numarası: A123456-7; Abone tipi: A (bireysel), B (kurumsal); Bina numarası: 123456; Daire numarası: 7
            Console.Write("Abone numarası giriniz: ");
            string aboneNo = Console.ReadLine();
            string aboneTipi = aboneNo.Substring(0, 1) == "A" ? "Bireysel" : "Kurumsal"; // 0. index'ten başla 1 karakter al
            string binaNo = aboneNo.Substring(1, 6); // 1. index'ten başla 6 karakter al
            string daireNo = aboneNo.Substring(8); // 8. index'ten başla sona kadar tüm karakterleri al
            Console.WriteLine($"Abone Tipi: {aboneTipi}, Bina No: {binaNo}, Daire No: {daireNo}"); // konsola örnek üzerinden "Abone Tipi: Bireysel, Bina No: 123456, Daire No: 7" yazdırır
            #endregion



            #region ToLower (Tüm Harfleri Küçültme) ve ToUpper (Tüm Harfleri Büyültme) Methodları
            string ulke = "Türkiye";
            Console.WriteLine($"Tümü küçük harf: {ulke.ToLower()}, tümü büyük harf: {ulke.ToUpper()}"); // konsola "Tümü küçük harf: türkiye, tümü büyük harf: TÜRKİYE" yazdırır
            #endregion



            #region Split (Parçalama) Methodu
            // Bir cümleyi boşluk karakterine göre kelimelerine parçalama:
            Console.Write("Cümle giriniz: ");
            string cumle = Console.ReadLine();
            string[] kelimeler = cumle.Split(' '); // cumle verisini boşluk karakterine göre parçalar ve geriye bir string dizisi döner
            for (int i = 0; i < kelimeler.Length; i++) // Çağıl Alsaç örneği için konsola alt alta "1. kelime: Çağıl", "2. kelime: Alsaç" yazdırır
            {
                Console.WriteLine((i + 1) + ". kelime: " + kelimeler[i]);
            }
            #endregion



            #region Equals (Eşitlik) Methodu
            // Equals methodu sadece string için değil diğer veri tipleri için de kullanılabilir
            string test1 = "Test1";
            string test2 = "Test2";

            if (test1.Equals(test2)) // konsola "Test1 eşit değildir Test2" yazdırır
                Console.WriteLine($"{test1} eşittir {test2}");
            else
                Console.WriteLine($"{test1} eşit değildir {test2}");

            // Equals methodu yerine eşitlik operatörü kullanmak daha uygundur
            test2 = "Test1";
            if (test1 == test2) // konsola "Test1 eşittir Test2" yazdırır
                Console.WriteLine($"{test1} eşittir {test2}");
            else
                Console.WriteLine($"{test1} eşit değildir {test2}");
            #endregion



            #region Escape Sequences (Metinsel Veri İçerisinde Kaçış Karakterleri Kullanımı)
            string ad = "Çağıl";
            string soyad = "Alsaç";
            string escapeSequenceSonucu;

            // \" (çift tırnak) kullanımı:
            escapeSequenceSonucu = "\"" + ad + "\""; // "Çağıl"
            Console.WriteLine(escapeSequenceSonucu); // konsola "Çağıl" (çift tırnak içerisinde) yazdırır

            // \n (yeni satır) kullanımı:
            escapeSequenceSonucu = ad + "\n" + soyad;
            Console.WriteLine(escapeSequenceSonucu); // konsola Çağıl yazdırdıktan sonra \n ile alt satıra geçerek Alsaç yazdırır

            // \r (satır başı) kullanımı: genelde \n ile birlikte kullanılır, eğer alt satıra geçildiğinde satır başından devam etmiyorsa ihtiyaca göre kullanılabilir
            escapeSequenceSonucu = ad + "\r\n" + soyad;
            Console.WriteLine(escapeSequenceSonucu); // konsola Çağıl yazdırdıktan sonra \n ile alt satıra geçerek ve \r ile de satır başına giderek Alsaç yazdırır

            // \t (tab) kullanımı:
            escapeSequenceSonucu = ad + "\t" + soyad;
            Console.WriteLine(escapeSequenceSonucu); // konsola \t ile belli bir miktar boşluk bırakarak "Çağıl  Alsaç" yazdırır

            // \\ (ters slash) kullanımı:
            string dosyaYolu1 = "C:\\Users\\Cagil\\cv.docx";
            Console.WriteLine(dosyaYolu1); // konsola "C:\Users\Cagil\cv.docx" yazdırır
            string dosyaYolu2 = @"C:\Users\Cagil\cv.docx"; // bu kullanım daha çok tercih edilir
            Console.WriteLine(dosyaYolu2); // konsola "C:\Users\Cagil\cv.docx" yazdırır

            // \' (tek tırnak) kullanımı:
            char karakter = '\'';
            Console.WriteLine(karakter); // konsola ' yazdırır
            #endregion



            #region Trim, TrimStart ve TrimEnd (Karakter Traşlama) Methodları
            string tamAd = " Çağıl Alsaç   ";
            Console.WriteLine("\"" + tamAd + "\""); // konsola " Çağıl Alsaç   " yazdırır
            Console.WriteLine("\"" + tamAd.Trim() + "\""); // konsola "Çağıl Alsaç" yazdırır, baştaki ve sondaki boşluk karakterlerini temizler
            Console.WriteLine("\"" + tamAd.TrimStart() + "\""); // konsola "Çağıl Alsaç   " yazdırır, baştaki boşluk karakterlerini temizler
            Console.WriteLine("\"" + tamAd.TrimEnd() + "\""); // konsola " Çağıl Alsaç" yazdırır, sondaki boşluk karakterlerini temizler

            string diller = "C#, Java, Python, ";
            string trimlenmisDiller = diller.TrimEnd(',', ' '); // Trim methodları ile birden çok karakter parametre olarak kullanılarak karakterlerin temizlenme işlemi yapılabilir
            Console.WriteLine(trimlenmisDiller); // konsola "C#, Java, Python" yazdırır
            #endregion



            #region ToString Methodu (Değer tip verilerinin string karşılıklarını, string dışındaki referans tip verilerinin ise tiplerini dönen method)
            int ogrenciNo = 123456;
            string ogrenciNoYazi = ogrenciNo.ToString(); // int tipindeki ogrenciNo'nun string karşılığını ("123456") oluşturur ve ogrenciNoYazi değişkenine atar
            Console.WriteLine(ogrenciNoYazi); // konsola 123456 yazdırır

            bool dogruMu = true;
            Console.WriteLine(dogruMu.ToString()); // bool tipindeki dogruMu'nun string karşılığını ("True") oluşturur ve konsola True yazdırır

            int[] sayilar = new int[] { 1, 2, 3 };
            Console.WriteLine(sayilar.ToString()); // sayilar referans tip olduğu için konsola System.Int32[] yazdırır yani ToString methodu değişkenin tipini döner
            #endregion



            #region PadLeft ve PadRight Methodları
            int ajanNo = 7;
            string ajanNoYazi = ajanNo.ToString().PadLeft(3, '0'); // ajanNo string'inin soluna eğer string tek karakterse 2 tane 0 ekleyerek,
                                                                   // iki karakterse 1 tane 0 ekleyerek, 3 karakterse 0 eklemeden toplam karakter sayısını 3'e tamamlar (007) 
            Console.WriteLine(ajanNoYazi); // konsola 007 yazdırır

            string saat = "18";
            Console.WriteLine(saat.PadLeft(2, '0')); // saat iki karakter olduğundan ve PadLeft methodunda iki karaktere '0' ile tamamla dediğimiz için konsola 18 yazdırır
            saat = "6";
            Console.WriteLine(saat.PadLeft(2, '0')); // saat tek karakter olduğundan ve PadLeft methodunda iki karaktere '0' ile tamamla dediğimiz için konsola 06 yazdırır

            string message = "To be continued"; // length: 15
            Console.WriteLine(message.PadRight(18, '.')); // sona üç nokta eklemek için 18 karaktere '.' ile tamamlayarak konsola "To be continued..." yazdırır
            #endregion



            #region Demos
            AdamAsmaca.Calistir();
            KelimeIlkHarfBuyukDigerleriKucuk.Calistir();
            SayiBasamaklari.Calistir();
            SehirArama.Calistir();
            CumledeKelimeArama.Calistir();
            ListedeIsimArama.Calistir();
            ListedeIsimAramaVeBulunanlariListeleme.Calistir();
            TcKimlikNoDogrulama.Calistir();
            SesliSessizHarfBulma.Calistir();
            #endregion
        }
    }
}