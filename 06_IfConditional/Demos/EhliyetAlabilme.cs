namespace _06_IfConditional.Demos
{
    // Mert
    public class EhliyetAlabilme
    {
        public static void Calistir() // Yaşı 18'den büyük veya eşit, eğitim durumu lise veya üstü olan kişiler ehliyet alabilir
        {
            Console.WriteLine("*** Yaş ve Eğitim Durumuna Göre Ehliyet Alabilme ***");
            Console.Write("Ad Soyad: ");
            string adSoyad = Console.ReadLine();
            Console.Write("Yaş: ");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Eğitim Durumu (i: ilkokul veya altı, o: ortaokul, l: lise, ü: üniversite veya üstü): ");
            string egitim = Console.ReadLine();
            if (yas >= 18 && (egitim == "l" || egitim == "ü"))
            {
                Console.WriteLine("Tebrikler " + adSoyad + ", ehliyet alabilirsiniz.");
            }
            else
            {
                Console.WriteLine("Üzgünüz " + adSoyad + ", ehliyet alamazsınız.");
            }
        }
    }
}
