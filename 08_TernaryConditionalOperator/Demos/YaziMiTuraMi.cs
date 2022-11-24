namespace _08_TernaryConditionalOperator.Demos
{
    public class YaziMiTuraMi
    {
        public static void Calistir()
        {
            int number;
            Console.Write("Yazı (y) mı tura (t) mı? ");
            string input = Console.ReadLine();
            if (input == "t")
                number = 1; // tura
            else
                number = 0; // yazı
            Random random = new Random();
            int randomNumber = random.Next(0, 2); // 2 dahil değil, 0 veya 1 döner sadece. tura 1 yazı 0 olsun
            if (number == randomNumber)
                Console.WriteLine(number == 1 ? "Tura geldi, bildiniz." : "Yazı geldi, bildiniz.");
            else
                Console.WriteLine(randomNumber == 1 ? "Tura geldi, bilemediniz." : "Yazı geldi, bilemediniz.");
        }
    }
}
