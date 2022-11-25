namespace _10_WhileLoop.Demos
{
    public class Palindrom
    {
        public static void Calistir()
        {
            string duzKelime;
            string tersKelime;
            Console.Write("Palindrom kontrolü için kelime (ç: Çıkış): ");
            duzKelime = Console.ReadLine();
            while (duzKelime != "ç")
            {
                if (duzKelime.Length >= 3)
                {
                    tersKelime = "";
                    for (int i = duzKelime.Length - 1; i >= 0; i--)
                    {
                        tersKelime += duzKelime[i];
                    }
                    if (duzKelime == tersKelime)
                        Console.WriteLine(duzKelime + " ile " + tersKelime + " palindromdur.");
                    else
                        Console.WriteLine(duzKelime + " ile " + tersKelime + " palindrom değildir.");
                }
                else
                {
                    Console.WriteLine("Kelime en az 3 karakter olmalıdır!");
                }
                Console.Write("Palindrom kontrolü için kelime (ç: Çıkış): ");
                duzKelime = Console.ReadLine();
            }
        }
    }
}
