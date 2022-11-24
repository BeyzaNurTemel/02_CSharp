namespace _06_IfConditional.Demos
{
    public class SayiPozitifNegatif
    {
        public static void Calistir()
        {
            // Sayı pozitif mi negatif mi kontrolü (İç içe if blokları):
            Console.WriteLine("Bir sayı girin:");
            int demoNumber = Convert.ToInt32(Console.ReadLine());
            if (demoNumber == 0)
            {
                Console.WriteLine("Sayı sıfıra eşit");
            }
            else
            {
                if (demoNumber > 0)
                    Console.WriteLine("Sayı pozitif");
                else
                    Console.WriteLine("Sayı negatif");
            }
        }
    }
}
