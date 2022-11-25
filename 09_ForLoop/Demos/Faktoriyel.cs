namespace _09_Loops.Demos
{
    public class Faktoriyel
    {
        public static void Calistir()
        {
            int sayi;
            int sonuc;
            Console.Write("Bir sayı girin: ");
            sayi = Int32.Parse(Console.ReadLine());
            sonuc = sayi;
            for (int i = 0; i < sayi; i++)
            {
                sonuc = sonuc * (sayi - 1);
                sayi--;
            }
            Console.WriteLine("Sayının faktöriyeli: " + sonuc);
        }
    }
}
