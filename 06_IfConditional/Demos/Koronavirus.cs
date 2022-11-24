namespace _06_IfConditional.Demos
{
    public class Koronavirus
    {
        public static void Calistir()
        {
            BelirtiTespitEt();
            YuzdeTespitEt();
        }

        static void BelirtiTespitEt()
        {
            Console.WriteLine("*** Koronavirüs Belirti Tespit ***");
            Console.Write("Ateş var mı? Evet (e), Hayır (h): ");
            string ates = Console.ReadLine();
            if (!(ates == "e" || ates == "h")) // ates != "e" && ates != "h"
            {
                Console.WriteLine("Lütfen Evet için e, Hayır için h giriniz...");
            }
            else // ates == "e" || ates == "h"
            {
                Console.Write("Öksürük var mı? Evet (e), Hayır (h): ");
                string oksuruk = Console.ReadLine();
                if (oksuruk != "e" && oksuruk != "h") // !(oksuruk == "e" || oksuruk == "h")
                {
                    Console.WriteLine("Lütfen Evet için e, Hayır için h giriniz...");
                }
                else // oksuruk == "e" || oksuruk == "h"
                {
                    Console.Write("Boğaz ağrısı var mı? Evet (e), Hayır (h): ");
                    string bogazAgrisi = Console.ReadLine();
                    if (!(bogazAgrisi == "e" || bogazAgrisi == "h")) // bogazAgrisi != "e" && bogazAgrisi != "h" 
                    {
                        Console.WriteLine("Lütfen Evet için e, Hayır için h giriniz...");
                    }
                    else // bogazAgrisi == "e" || bogazAgrisi == "h"
                    {
                        if (ates == "e" || oksuruk == "e" || bogazAgrisi == "e")
                        {
                            Console.WriteLine("Belirtilerden herhangi biri olduğundan dolayı Koronavirüs taşıyor olabilirsiniz.");
                        }
                        else // ates != "e" && oksuruk != "e" && bogazAgrisi != "e"
                        {
                            Console.WriteLine("Hiçbir belirti taşımadığınızdan Koronavirüs olma ihtimaliniz çok azdır.");
                        }
                    }
                }
            }
        }

        static void YuzdeTespitEt()
        {
            Console.WriteLine("*** Koronavirüs Yüzde Tespit ***");
            int sonucYuzde = 0;
            int atesYuzde = 60;
            int oksurukYuzde = 30;
            int bogazAgrisiYuzde = 10;
            string hataliGirisMesaji = "Lütfen Evet için e, Hayır için h giriniz...";
            Console.Write("Ateş var mı? Evet (e), Hayır (h): ");
            string ates = Console.ReadLine();
            if (!(ates == "e" || ates == "h")) // ates != "e" && ates != "h"
            {
                Console.WriteLine(hataliGirisMesaji);
                return;
            }
            if (ates == "e")
            {
                sonucYuzde = sonucYuzde + atesYuzde; // sonucYuzde += atesYuzde;
            }
            Console.Write("Öksürük var mı? Evet (e), Hayır (h): ");
            string oksuruk = Console.ReadLine();
            if (oksuruk != "e" && oksuruk != "h") // !(oksuruk == "e" || oksuruk == "h")
            {
                Console.WriteLine(hataliGirisMesaji);
                return;
            }
            if (oksuruk == "e")
            {
                sonucYuzde += oksurukYuzde; // sonucYuzde = sonucYuzde + oksurukYuzde
            }
            Console.Write("Boğaz ağrısı var mı? Evet (e), Hayır (h): ");
            string bogazAgrisi = Console.ReadLine();
            if (!(bogazAgrisi == "e" || bogazAgrisi == "h")) // bogazAgrisi != "e" && bogazAgrisi != "h" 
            {
                Console.WriteLine(hataliGirisMesaji);
                return;
            }
            if (bogazAgrisi == "e")
            {
                sonucYuzde = sonucYuzde + bogazAgrisiYuzde; // sonucYuzde += bogazAgrisiYuzde
            }
            Console.WriteLine("Koronavirüs olma ihtimaliniz: %" + sonucYuzde);
        }
    }
}
