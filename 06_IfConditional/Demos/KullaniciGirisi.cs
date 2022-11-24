namespace _06_IfConditional.Demos
{
    // Mert
    public class KullaniciGirisi
    {
        public static void Calistir() // Kullanıcı bilgileri kontrolü
        {
            string correctUsername = "cagil";
            string correctPassword = "123";
            Console.WriteLine("*** Kullanıcı Girişi ***");
            Console.Write("Kullanıcı Adı: ");
            string username = Console.ReadLine();
            Console.Write("Şifre: ");
            string password = Console.ReadLine();
            if (username == correctUsername)
            {
                if (password == correctPassword)
                {
                    Console.Write("Kullanıcı adı ve şifreniz doğrudur, ");
                    Console.WriteLine("hoşgeldiniz!");
                }
                else
                {
                    Console.WriteLine("Şifreniz yanlıştır, lütfen tekrar deneyiniz...");
                }
            }
            else
            {
                Console.Write("Kullanıcı adınız yanlıştır, ");
                Console.WriteLine("lütfen tekrar deneyiniz...");
            }
        }
    }
}
