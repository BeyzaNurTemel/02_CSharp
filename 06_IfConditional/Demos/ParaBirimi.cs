namespace _06_IfConditional.Demos
{
    public class ParaBirimi
    {
        public static void Calistir()
        {
            Console.Write("Para birimi giriniz (TL, AUD, CAD, NZD, JPY, CHF, GBP, EUR, USD): ");
            string input = Console.ReadLine();
            if (input == "TL") // Türkiye'de olduğumuzdan en çok TL girilecektir tahmininde bulunuyoruz. Bu şekilde TL'yi ilk sıraya taşıyarak performans kazanmış olduk
                Console.WriteLine("Türk Lirası (TL)");
            else if (input == "AUD")
                Console.WriteLine("Avusturalya Doları (AUD)");
            else if (input == "CAD")
                Console.WriteLine("Kanada Doları (CAD)");
            else if (input == "NZD")
                Console.WriteLine("Yeni Zelanda Doları (NZD)");
            else if (input == "JPY")
                Console.WriteLine("Japon Yeni (JPY)");
            else if (input == "CHF")
                Console.WriteLine("İsviçre Frangı (CHF)");
            else if (input == "GBP")
                Console.WriteLine("İngiliz Sterlini (GBP)");
            else if (input == "EUR")
                Console.WriteLine("Euro (EUR)");
            else if (input == "USD")
                Console.WriteLine("Amerikan Doları (USD)");
            else
                Console.WriteLine("Giriş uygun değil!");
        }
    }
}
