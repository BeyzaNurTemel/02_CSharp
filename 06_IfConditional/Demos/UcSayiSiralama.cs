namespace _06_IfConditional.Demos
{
    public class UcSayiSiralama
    {
        public static void Calistir()
        {
            int sayi1 = Giris("Sayı 1:");
            int sayi2 = Giris("Sayı 2:");
            int sayi3 = Giris("Sayı 3:");
            string sira = Sirala(sayi1, sayi2, sayi3);
            Console.WriteLine(sira);
        }

        static int Giris(string mesaj)
        {
            Console.Write(mesaj + " ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static string Sirala(int sayi1, int sayi2, int sayi3)
        {
            int buyuk = sayi1;
            int orta = sayi2;
            int kucuk = sayi3;
            if (sayi1 == sayi2 || sayi1 == sayi3 || sayi2 == sayi3)
            {
                return "Sayılar eşit girilmemelidir!";
            }
            else
            {
                if (sayi3 > sayi1 && sayi3 > sayi2)
                {
                    buyuk = sayi3;
                    orta = sayi2;
                    kucuk = sayi1;
                    if (sayi1 > sayi2)
                    {
                        orta = sayi1;
                        kucuk = sayi2;
                    }
                }
                else if (sayi2 > sayi1 && sayi2 > sayi3)
                {
                    buyuk = sayi2;
                    orta = sayi1;
                    kucuk = sayi3;
                    if (sayi3 > sayi1)
                    {
                        orta = sayi3;
                        kucuk = sayi1;
                    }
                }
                else
                {
                    if (sayi3 > sayi2)
                    {
                        orta = sayi3;
                        kucuk = sayi2;
                    }
                }
                return $"{buyuk} > {orta} > {kucuk}";
            }
        }
    }
}
