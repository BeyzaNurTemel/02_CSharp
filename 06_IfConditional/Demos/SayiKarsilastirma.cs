namespace _06_IfConditional.Demos
{
    // Mert
    public class SayiKarsilastirma
    {
        public static void Calistir()
        {
            IkiSayiKarsilastir();
            UcSayiKarsilastir();
        }

        public static void IkiSayiKarsilastir() // Girilen iki sayıdan hangisi daha büyük
        {
            Console.WriteLine("*** Girilen İki Sayıdan Hangisi Daha Büyük ***");
            Console.Write("1. sayı: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayı: ");
            int sayi2 = int.Parse(Console.ReadLine()); // Convert.ToInt32(Console.ReadLine());
            if (sayi1 > sayi2)
                Console.WriteLine("1. sayı (" + sayi1 + ") 2. sayıdan (" + sayi2 + ") büyüktür.");
            else if (sayi2 > sayi1)
                Console.WriteLine("2. sayı (" + sayi2 + ") 1. sayıdan (" + sayi1 + ") büyüktür.");
            else
                Console.WriteLine("1. sayı (" + sayi1 + ") ile 2. sayı (" + sayi2 + ") birbirine eşittir.");
        }

        public static void UcSayiKarsilastir() // Girilen üç sayıdan hangisi daha büyük
        {
            Console.WriteLine("*** Girilen Üç Sayıdan Hangisi Daha Büyük ***");
            Console.Write("1. sayı: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayı: ");
            int sayi2 = int.Parse(Console.ReadLine()); // Convert.ToInt32(Console.ReadLine());
            Console.Write("3. sayı: ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            if (sayi1 == sayi2 && sayi1 == sayi3 && sayi2 == sayi3)
            {
                Console.WriteLine("Girilen tüm sayılar birbirine eşittir.");
            }
            else
            {
                int enBuyukSayi = sayi1;
                if (sayi2 >= sayi1)
                {
                    if (sayi2 >= sayi3)
                    {
                        enBuyukSayi = sayi2;
                    }
                }
                if (sayi3 >= sayi1)
                {
                    if (sayi3 >= sayi2)
                    {
                        enBuyukSayi = sayi3;
                    }
                }
                Console.WriteLine("Girilen en büyük sayı: " + enBuyukSayi);
            }
        }
    }
}
