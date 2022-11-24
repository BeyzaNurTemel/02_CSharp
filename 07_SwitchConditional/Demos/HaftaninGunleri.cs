namespace _07_SwitchConditional.Demos
{
    public class HaftaninGunleri
    {
        public static void Calistir()
        {
            Console.Write("Sayı girin (1 - 7): ");
            string s = Console.ReadLine();
            switch (s)
            {
                case "1":
                    Console.WriteLine("P.tesi");
                    break;
                case "2":
                    Console.WriteLine("Salı");
                    break;
                case "3":
                    Console.WriteLine("Çarşamba");
                    break;
                case "4":
                    Console.WriteLine("Perşembe");
                    break;
                case "5":
                    Console.WriteLine("Cuma");
                    break;
                case "6":
                    Console.WriteLine("C.tesi");
                    break;
                case "7":
                    Console.WriteLine("Pazar");
                    break;
                default:
                    Console.WriteLine("HATA!");
                    break;
            }
            // break içinde bulunduğu scope'dan bizi dışarı atar!
        }
    }
}
