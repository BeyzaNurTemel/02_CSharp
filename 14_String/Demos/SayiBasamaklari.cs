namespace _14_String.Demos
{
    public class SayiBasamaklari
    {
        public static void Calistir()
        {
            // 1234: Binler: 1, Yüzler: 2, Onlar: 3, Birler: 4
            string[] basamaklar = new string[]
            {
                "Binler", "Yüzler", "Onlar", "Birler"
            };
            string ustSinir = "";
            foreach (string basamak in basamaklar)
            {
                ustSinir += "9";
            }
            Console.Write($"{ustSinir}'a kadar bir pozitif tam sayı giriniz: ");
            string giris = Console.ReadLine();
            string sonuc = "";
            for (int i = 0; i < giris.Length; i++)
            {
                sonuc += basamaklar[i + basamaklar.Length - giris.Length] + " basamağı: " + giris[i] + "\n";
            }
            Console.WriteLine(sonuc);
        }
    }
}
