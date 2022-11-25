namespace _14_String.Demos
{
    public class SesliSessizHarfBulma
    {
        public static void Calistir()
        {
            Console.Write("Kelime (çıkış için 0): ");
            string kelime = Console.ReadLine().ToLower();
            string sesliSessiz;
            string sonuc;
            string[] sesliler = new string[]
            {
                "a", "e", "ı", "i", "o", "ö", "u", "ü"
            };
            while (kelime != "0")
            {
                Console.Write("Sesli harf (1), sessiz harf (2): ");
                sesliSessiz = Console.ReadLine();
                if (sesliSessiz == "1")
                    sonuc = "Sesli harfler: " + SesliBul(kelime, sesliler);
                else
                    sonuc = "Sessiz harfler: " + SessizBul(kelime, sesliler);
                Console.WriteLine(sonuc);
                Console.Write("Kelime (çıkış için 0): ");
                kelime = Console.ReadLine().ToLower();
            }
        }

        static string SessizBul(string kelime, string[] sesliler)
        {
            string sonuc = "";
            bool sessizMi;
            int sessizSayisi = 0;
            foreach (char harf in kelime)
            {
                sessizMi = true;
                foreach (string sesli in sesliler)
                {
                    if (harf.ToString() == sesli)
                    {
                        sessizMi = false;
                        break;
                    }
                }
                if (sessizMi)
                {
                    sessizSayisi++;
                    if (!sonuc.Contains(harf))
                        sonuc += harf + " (" + KelimedeHarfleriSay(harf, kelime) + "), ";
                }
            }
            return sonuc.Trim(',', ' ') + ", toplam sessiz: " + sessizSayisi;
        }

        static string SesliBul(string kelime, string[] sesliler)
        {
            string sonuc = "";
            bool sesliMi;
            int sesliSayisi = 0;
            foreach (char harf in kelime)
            {
                sesliMi = false;
                foreach (string sesli in sesliler)
                {
                    if (harf.ToString() == sesli)
                    {
                        sesliMi = true;
                        break;
                    }
                }
                if (sesliMi)
                {
                    sesliSayisi++;
                    if (!sonuc.Contains(harf))
                        sonuc += harf + " (" + KelimedeHarfleriSay(harf, kelime) + ") ";
                }
            }
            return sonuc.Trim(',', ' ') + ", toplam sesli: " + sesliSayisi;
        }

        static int KelimedeHarfleriSay(char sayilacakHarf, string kelime)
        {
            int sayi = 0;
            foreach (char harf in kelime)
            {
                if (sayilacakHarf == harf)
                    sayi++;
            }
            return sayi;
        }
    }
}
