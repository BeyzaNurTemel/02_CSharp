namespace _06_IfConditional.Demos
{
    // Burak
    public static class VucutKutleEndeksi
    {
        public static void Calistir()
        {
            BaslikYaz();
            double boy = Giris("Boy giriniz (m): ");
            double kilo = Giris("Kilo giriniz (kg): ");
            double endeks = EndeksHesapla(boy, kilo);
            Console.WriteLine($"Endeks: {endeks}");
            HesapSonucunuYazdir(endeks);
        }

        /// <summary>
        /// Gönderilen boy ve kiloya göre endeks hesaplar.
        /// </summary>
        /// <param name="boy"></param>
        /// <param name="kilo"></param>
        /// <returns>double</returns>
        static double EndeksHesapla(double boy, double kilo)
        {
            double endeks = kilo / (boy * boy);
            return endeks;
        }

        static void HesapSonucunuYazdir(double endeks)
        {
            Console.Write("Vücut Kütle Endeksiniz: ");
            if (endeks < 18)
                Console.WriteLine("Zayıf");
            else if (endeks >= 18 && endeks < 25)
                Console.WriteLine("Normal");
            else if (endeks >= 25 && endeks < 30)
                Console.WriteLine("Kilolu");
            else if (endeks >= 30 && endeks < 35)
                Console.WriteLine("Obez");
            else
                Console.WriteLine("Ultra Obez");
        }

        static void BaslikYaz()
        {
            Console.WriteLine("*** Vücut Kütle Endeksi Hesaplama ***");
        }

        static double Giris(string mesaj)
        {
            double giris;
            Console.Write(mesaj);
            giris = Convert.ToDouble(Console.ReadLine());
            return giris;
        }
    }
}
