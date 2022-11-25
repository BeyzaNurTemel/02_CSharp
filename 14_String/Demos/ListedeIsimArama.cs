namespace _14_String.Demos
{
    public class ListedeIsimArama
    {
        public static void Calistir()
        {
            // verilen bir isim soyisim listesi içerisinde kullanıcı tarafından girilen değer var mı (case insensitive ve baştaki veya sondaki boşlukları dikkate almadan arama). "çıkış" string'i girilerek programdan çıkılır
            string[] isimler = new string[5]
            {
                "Robert DeNiro",
                "Jennifer Lopez",
                "Robert Downey Jr.",
                "Al Pacino",
                "Kate Beckinsale"
            };
            Console.WriteLine("İsim listesi:");
            foreach (var isim in isimler)
            {
                Console.WriteLine(isim);
            }
            string[] caseInsensitiveIsimler = new string[5];
            int i = 0;
            foreach (var isim in isimler)
            {
                caseInsensitiveIsimler[i++] = isim.ToLower();
            }
            Console.Write("Aranacak ismi giriniz (\"çıkış\" yazarak çıkabilirsiniz): ");
            string input = Console.ReadLine();
            input = input.ToLower().Trim();
            bool found;
            while (!input.Equals("çıkış"))
            {
                found = false;
                for (i = 0; i < caseInsensitiveIsimler.Length && !found; i++)
                {
                    if (caseInsensitiveIsimler[i].Contains(input))
                        found = true;
                }
                if (found)
                    Console.WriteLine("\"" + input + "\" bulundu.");
                else
                    Console.WriteLine("\"" + input + "\" bulunamadı.");
                Console.Write("Aranacak ismi giriniz (\"çıkış\" yazarak çıkabilirsiniz): ");
                input = Console.ReadLine();
                input = input.ToLower().Trim();
            }
        }
    }
}
