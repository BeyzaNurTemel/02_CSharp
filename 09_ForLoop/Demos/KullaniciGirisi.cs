namespace _09_Loops.Demos
{
    public class KullaniciGirisi
    {
        public static void Calistir()
        {
            /*
            1. başla
            2. kullanıcı adı alınır
            3. şifre alınır
            4. iki boyutlu diziyi tarayarak girilen kullanıcı adı ve şifreli satır var mı bakılır
            5. eğer varsa hoşgeldin kullanıcı yazdırılır
            6. yoksa kullanıcı adı veya şifre hatalı yazdırılır
            7.bitir
            */

            string[,] kullanicilar = new string[3, 2]
            {
                { "çağıl", "123" },
                { "leo", "456" },
                { "luna", "987" }
            };
            Console.Write("Kullanıcı Adı: ");
            string kullaniciAdi = Console.ReadLine();
            Console.Write("Şifre: ");
            string sifre = Console.ReadLine();
            bool bulundu = false; // flag
            for (int r = 0; r <= kullanicilar.GetUpperBound(0); r++)
            {
                if (kullanicilar[r, 0] == kullaniciAdi && kullanicilar[r, 1] == sifre)
                {
                    bulundu = true;
                    break;
                }
            }
            if (bulundu)
                Console.WriteLine($"Hoşgeldin {kullaniciAdi}!");
            else
                Console.WriteLine("Kullanıcı adı veya şifre hatalı!");
        }
    }
}
