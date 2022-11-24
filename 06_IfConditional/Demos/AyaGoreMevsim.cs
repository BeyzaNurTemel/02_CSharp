namespace _06_IfConditional.Demos
{
    // Mert
    public class AyaGoreMevsim
    {
        public static void Calistir() // Girilen ayın sayı değerine göre mevsimi getirme
        {
            Console.WriteLine("*** Aya Göre Hangi Mevsim ***");
            Console.Write("Sayısal olarak ay giriniz (1 - 12): ");
            int ay = Convert.ToInt32(Console.ReadLine());
            if (ay == 0) // 0 girilirse hata mesajı verip metottan çıkalım
            {
                Console.WriteLine("1 (Ocak) ile 12 (Aralık) aralığında bir sayı giriniz!");
                return;
            }
            if (ay == 12) // Aralık ayı kış mevsiminde olduğu için 12 girilmesi durumunda ay değerini 0 kabul ediyoruz ki 0 ile 2 arası ayları kış mevsimi olarak kolayca yazdıralım
            {
                ay = 0;
            }
            if (ay >= 0 && ay <= 2)
            {
                Console.WriteLine("Kış mevsimi");
            }
            else if (ay > 2 && ay <= 5)
            {
                Console.WriteLine("İlkbahar mevsimi");
            }
            else if (ay > 5 && ay <= 8)
            {
                Console.WriteLine("Yaz mevsimi");
            }
            else if (ay > 8 && ay <= 11)
            {
                Console.WriteLine("Sonbahar mevsimi");
            }
            else
            {
                Console.WriteLine("1 (Ocak) ile 12 (Aralık) aralığında bir sayı giriniz!");
            }
        }
    }
}
