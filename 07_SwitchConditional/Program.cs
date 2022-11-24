// switch Conditional (switch Şart Yapısı)

using _07_SwitchConditional.Demos;

namespace _07_SwitchConditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region switch Şart Yapısı
            // Algoritma Örnek 1: Hesap Makinesi
            /*
            1. başla
            2. kullanıcıdan birinci sayı girmesi istenir
            3. kullanıcı ilk sayıyı girer
            4. kullanıcıdan ikinci sayı girmesi istenir
            5. kullanıcı ikinci sayıyı girer
            6. kullanıcıdan işlem girmesi istenir (+, -, *, /, %)
            7. kullanıcı işlem girer
            8. kullanıcıdan alınan sayılar ile işlem bir hesaplama methoduna gönderilir
            9. hesaplama methodundan dönen sonuç birinci sayı işlem ikinci sayı eşittir hesap sonucu şeklinde yazdırılır
            10. bitiş
            */
            double sayi1; // değişkenleri en başta tanımlayıp aşağıda değerlerini atamak kod okumayı daha kolaylaştırır
            double sayi2;
            string islem;
            Console.Write("Sayı 1: ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sayı 2: ");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İşlem (+, -, *, /, %): ");
            islem = Console.ReadLine();
            double sonuc = Hesapla(sayi1, sayi2, islem);
            Console.WriteLine($"{sayi1} {islem} {sayi2} = {sonuc}");



            // Algoritma örnek 2: Kısaltma Karşılıkları
            /*
            1. başla
            2. kullanıcından oyun adı kısaltması istenir (HL, CS, GTA, RDR)
            3. kullanıcıdan kısaltma girişi alınır
            4. bir methoda bu kısaltma gönderilerek istenilen kısaltmalardan biri değilse kullanıcı bu kısaltmalardan birini girmesi için uyarılır
            5. eğer kısaltma HL ise Half Life
            6. eğer kısaltma CS ise Counter Strike
            7. eğer kısaltma GTA ise Grand Theft Auto
            8. eğer kısaltma RDR ise Red Dead Redemption sonucu method içerisinde ekrana yazdırılır
            9. bitiş
            */
            Console.Write("Oyun adı kısaltması giriniz (HL, CS, GTA veya RDR): ");
            string kisaltma = Console.ReadLine();
            KisaltmayaGoreOyunYazdir(kisaltma);
            #endregion



            #region Demos
            HaftaninGunleri.Calistir();
            PlakaVeSehirler.Calistir();
            TlDovizHesaplama.Calistir();
            #endregion
        }



        // Algoritma Örnek 1: Hesap Makinesi
        static double Hesapla(double sayi1, double sayi2, string islem)
        {
            double sonuc; // methoddan dönecek sonuc değişkenini en başta tanımlayıp method sonunda return etmek kod okumayı daha kolaylaştırır
                          // aşağıdaki her durum için sonuc değişkeni atanmalıdır, aşağıda case "%" kullanıldığında her durum için bu değişken atanamadığından
                          // sonuc değişkenine double sonuc = 0 şeklinde bir ilk değer ataması gereklidir,
                          // aşağıda case "%" yerine default kullanıldığında her durum için sonuc değişkeni atandığından burada olduğu gibi ilk değer atamasına gerek yoktur 
            switch (islem) // switch operatörüne parametre olarak if'te olduğu gibi bir koşul değil değer gönderilir
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break; // bu case (durum) sağlandığında aşağıdaki durumların çalışmaması için switch break ile sonlandırılır
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    break;
                //case "%":
                default: // yukarıdaki durumlar dışındaki tüm durumlar için default kullanılabilir (else gibi düşünülebilir), burada zaten tek % işlemi kaldığından case "%" yerine default kullanmak daha uygundur
                    sonuc = sayi1 % sayi2;
                    break;
            }
            return sonuc;
        }



        // Algoritma örnek 2: Kısaltma Karşılıkları
        static void KisaltmayaGoreOyunYazdir(string oyunKisaltma)
        {
            string sonuc = "HL, CS, GTA veya RDR girilmelidir!"; // switch'deki case'lere uymuyan bir durum olabileceğinden (mesela COD), bu durumdan dolayı ilk değer ataması mutlaka yapılmalıdır
            switch (oyunKisaltma)
            {
                case "HL": sonuc = "Half Life";
                    break;
                case "CS": sonuc = "Counter Strike";
                    break;
                case "GTA": sonuc = "Grand Theft Auto";
                    break;
                case "RDR": sonuc = "Red Dead Redemption";
                    break;
            }
            Console.WriteLine(sonuc);
        }
    }
}