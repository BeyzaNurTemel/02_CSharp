namespace _10_WhileLoop.Demos
{
    public class AritmetikOrtalama
    {
        public static void Calistir()
        {
            Console.WriteLine("Pozitif sayıların aritmetik ortalaması hesaplaması:");
            int l = 0; // Toplam sayı
            double sayi = 0;
            double sayilarinToplami = 0;
            while (sayi != -1)
            {
                Console.Write((l + 1) + ". sayıyı girin (-1 = Çıkış): ");
                sayi = Convert.ToDouble(Console.ReadLine());
                if (sayi != -1)
                {
                    sayilarinToplami += sayi;
                    l++;
                }
            }
            Console.WriteLine("Aritmetik ortalama: " + sayilarinToplami / l);
        }
    }
}
