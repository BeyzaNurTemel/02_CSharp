// foreach Loop (foreach Döngüsü)

using _13_ForEachLoop.Demos;

namespace _13_ForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // herhangi bir kolleksiyonun index'ten bağımsız tüm elemanlarını turlayabilmek için kullanılır
            string[] sehirler = { "Ankara", "İstanbul", "İzmir", "Adana", "Bursa", "Diyarbakır" };
            foreach (string sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }



            // Algoritma örnek 1: Kolleksiyonda Veri Arama
            // 1. başla
            // 2. içinde bilgisayar, araba, müzik, köpek ve kahve kelimelerinin bulunduğu bir dizi oluşturulur
            // 3. kullanıcıdan herhangi bir kelime girilmesi istenir
            // 4. bir methodda girilen kelime kolleksiyonda aranır ve bulunursa bulundu olarak işaretlenir
            // 5. eğer kelime bulundu olarak işaretlendiyse ekrana aranan kelime bulundu
            // 6. eğer kelime bulundu olarak işaretlenmediyse aranan kelime bulunamadı yazdırılır
            // 7. bitiş
            string[] kelimeler = new string[5]
            {
                "bilgisayar",
                "araba",
                "müzik",
                "köpek",
                "kahve"
            };
            Console.Write("Aranacak kelime: ");
            string aranacakKelime = Console.ReadLine();
            Ara(aranacakKelime, kelimeler);



            #region Demos
            PlakalaraGoreSehirler.Calistir();
            IliskiTesti.Calistir();
            #endregion
        }



        // Algoritma örnek 1: Kolleksiyonda Veri Arama
        static void Ara(string aranacakKelime, string[] kelimeler)
        {
            bool bulundu = false; // flag (işaret), ilk başta kelime bulunamadı olarak işaretliyoruz
            foreach (string kelime in kelimeler)
            {
                if (kelime == aranacakKelime)
                {
                    bulundu = true; // eğer aranan kelime döngünün bu turundaki kelimeye eşitse flag'i bulundu olarak işaretliyoruz
                    break; // kolleksiyondaki bu kelimeden sonraki elemanların turlanmasına gerek olmadığı için döngüyü break ile kırıyoruz yani sonlandırıyoruz
                }
            }
            if (bulundu) // döngü bittikten sonra bulundu true olarak işaretlendiyse konsola aranan kelime bulundu, false olarak işaretlendiyse konsola aranan kelime bulunamadı yazdırıyoruz
                Console.WriteLine(aranacakKelime + " bulundu.");
            else
                Console.WriteLine(aranacakKelime + " bulunamadı.");
        }
    }
}