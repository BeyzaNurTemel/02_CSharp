namespace _14_String.Demos
{
    public class SehirArama
    {
        public static void Calistir()
        {
            /* şehir kolleksiyonunda kullanıcıdan alınan 2 seçeneğe göre (1: başlayan, 2: içeren)
             * girilen veriye göre başlayanları veya içerenleri sonuç olarak dönen örnek
            */

            string[] sehirler = SehirleriDoldur();
            Console.Write("Arama tipi (1: başlayan, 2: içeren): ");
            string aramaTipi = Console.ReadLine();
            Console.Write("Aranacak şehir: ");
            string aranacakSehir = Console.ReadLine();
            string[] bulunanSehirler = SehirAra(sehirler, aranacakSehir, aramaTipi);
            BulunanSehirleriYazdir(bulunanSehirler);
        }

        static void BulunanSehirleriYazdir(string[] bulunanSehirler)
        {
            Console.WriteLine("Bulunan şehirler:");
            foreach (string bulunanSehir in bulunanSehirler)
                Console.WriteLine(bulunanSehir);
        }

        static string[] SehirAra(string[] sehirler, string aranacakSehir, string aramaTipi)
        {
            string[] sonucSehirler;
            int sayac = 0; // counter
            foreach (string sehir in sehirler)
            {
                if (aramaTipi == "1" && sehir.StartsWith(aranacakSehir, StringComparison.OrdinalIgnoreCase)) // başlayan
                    sayac++;
                else if (aramaTipi == "2" && sehir.ToUpper().Contains(aranacakSehir.ToUpper())) // içeren
                    sayac++;
            }
            sonucSehirler = new string[sayac];
            int j = 0;
            for (int i = 0; i < sehirler.Length; i++)
            {
                if ((aramaTipi == "1" && sehirler[i].ToLower().StartsWith(aranacakSehir.ToLower())) || (aramaTipi == "2" && sehirler[i].ToLower().Contains(aranacakSehir.ToLower()))) // başlayan veya içeren
                    sonucSehirler[j++] = sehirler[i];
            }
            return sonucSehirler;
        }

        static string[] SehirleriDoldur()
        {
            string[] sehirler = new string[]
            {
                "İstanbul",
                "İzmir",
                "Antalya",
                "Gaziantep",
                "Van",
                "Samsun",
                "Ankara"
            };
            return sehirler;
        }
    }
}
