namespace _14_String.Demos
{
    public class AdamAsmaca
    {
        public static void Calistir()
        {
            // Konfigürasyon başlangıç
            string testIsim = ""; // testi devre dışı bırakmak için testIsim = "" yapılmalıdır. test için testIsim değişkenine herhangi bir isim verilebilir
            string cikisDegeri = "0";
            char sorudaGosterilecekKarakter = '*';
            string[] isimListesi = IsimleriOlustur();
            // Konfigürasyon bitiş

            string rasgeleIsim;
            if (testIsim != "")
                rasgeleIsim = testIsim;
            else
                rasgeleIsim = RasgeleIsimGetir(isimListesi);
            RasgeleIsmeGoreSoruyuGetir(rasgeleIsim, cikisDegeri, sorudaGosterilecekKarakter, testIsim);
            OyunSonucuEnum oyunSonucu = OyunuBaslat(rasgeleIsim, cikisDegeri, sorudaGosterilecekKarakter);
            OyunuSonlandir(oyunSonucu);
        }

        static string[] IsimleriOlustur()
        {
            string[] isimler = new string[20]
            {
                "ALİ",
                "AHMET",
                "BÜŞRA",
                "BELİZ",
                "CEM",
                "DENİZ",
                "ENGİN",
                "FATİH",
                "FERHAT",
                "GAMZE",
                "HALE",
                "JALE",
                "UFUK",
                "ÜSTÜN",
                "YASEMİN",
                "TEKİN",
                "MUHİTTİN",
                "MERT",
                "ZAFER",
                "TANSU"
            };
            return isimler;
        }

        static string RasgeleIsimGetir(string[] isimler)
        {
            Random random = new Random();
            int randomIndex = random.Next(0, isimler.Length);
            string randomIsim = isimler[randomIndex];
            return randomIsim;
        }

        static void RasgeleIsmeGoreSoruyuGetir(string isim, string cikisDegeri, char sorudaGosterilecekKarakter, string testIsim)
        {
            string soru = "";
            Console.WriteLine("Aşağıdaki ismi bulun (Çıkmak için '" + cikisDegeri + "' basılmalıdır):");
            foreach (var randomKarakter in isim)
            {
                soru += sorudaGosterilecekKarakter;
            }
            soru = soru.Trim();
            if (!testIsim.Equals(""))
                soru = soru + " (Test için: " + testIsim + ")";
            Console.WriteLine(soru);
        }

        static OyunSonucuEnum OyunuBaslat(string isim, string cikisDegeri, char sorudaGosterilecekKarakter)
        {
            char[] karakterler = new char[isim.Length];
            for (int i = 0; i < karakterler.Length; i++)
            {
                karakterler[i] = sorudaGosterilecekKarakter;
            }
            string input = GetInput();
            String output = "";
            int foundIndex;
            int length = 0;
            while (karakterler.Length != length && input != cikisDegeri)
            {
                foundIndex = FindIndex(isim, input);
                while (foundIndex != -1 && !output.Contains(input))
                {
                    karakterler[foundIndex] = isim[foundIndex];
                    foundIndex = FindIndex(isim, input, foundIndex);
                    length++;
                }
                output = new String(karakterler);
                Console.WriteLine(output);
                if (karakterler.Length != length)
                    input = GetInput();
            }
            if (karakterler.Length == length)
                return OyunSonucuEnum.Basarili;
            else
                return OyunSonucuEnum.Basarisiz;
        }

        static int FindIndex(string isim, string input, int foundIndex = -1)
        {
            bool found = false;
            for (int i = foundIndex + 1; i < isim.Length && !found; i++)
            {
                if (isim[i] == Convert.ToChar(input))
                {
                    foundIndex = i;
                    found = true;
                }
            }
            if (found)
                return foundIndex;
            else
                return -1;
        }

        static string GetInput()
        {
            string input = Console.ReadLine();
            input = input.ToUpper();
            while (input.Length != 1)
            {
                Console.WriteLine("Hatalı giriş!");
                input = Console.ReadLine();
                input = input.ToUpper();
            }
            return input;
        }

        static void OyunuSonlandir(OyunSonucuEnum oyunSonucu)
        {
            if (oyunSonucu == OyunSonucuEnum.Basarili)
                Console.WriteLine("Tebrikler, ismi buldun. :)");
            else
                Console.WriteLine("Vazgeçtin, olsun bir dahaki sefere. :(");
        }

        enum OyunSonucuEnum
        {
            Basarili = 1,
            Basarisiz = 0
        }
    }
}
