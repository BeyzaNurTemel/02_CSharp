namespace _14_String.Demos
{
    public class ListedeIsimAramaVeBulunanlariListeleme
    {
        public static void Calistir()
        {
            // verilen bir isim soyisim listesi içerisinde kullanıcı tarafından girilen değere göre bulunan isimleri listeleme (case insensitive ve baştaki veya sondaki boşlukları dikkate almadan arama). "çıkış" string'i girilerek programdan çıkılır
            string[] isimList = new string[5]
            {
                "Robert DeNiro",
                "Jennifer Lopez",
                "Robert Downey Jr.",
                "Al Pacino",
                "Kate Beckinsale"
            };
            Console.WriteLine("İsim listesi:");
            foreach (var isimItem in isimList)
            {
                Console.WriteLine(isimItem);
            }
            Console.Write("Aranacak ismi giriniz ('ç' ile çıkabilirsiniz): ");
            string aranacakIsim = Console.ReadLine();
            string[] bulunanIsimList;
            int bulunanIsimSayisi;
            int bulunanIsimIndex;
            while (!aranacakIsim.Equals("ç"))
            {
                Console.WriteLine("Bulunan isimler:");
                bulunanIsimSayisi = 0;
                foreach (string isimItem in isimList)
                {
                    if (isimItem.ToLower().Contains(aranacakIsim.ToLower().Trim()))
                        bulunanIsimSayisi++;
                }
                if (bulunanIsimSayisi > 0)
                {
                    bulunanIsimList = new string[bulunanIsimSayisi];
                    bulunanIsimIndex = 0;
                    for (int isimIndex = 0; isimIndex < isimList.Length; isimIndex++)
                    {
                        if (isimList[isimIndex].ToLower().Contains(aranacakIsim.ToLower().Trim()))
                        {
                            bulunanIsimList[bulunanIsimIndex] = isimList[isimIndex];
                            bulunanIsimIndex++;
                        }
                    }
                    foreach (string bulunanIsimItem in bulunanIsimList)
                    {
                        Console.WriteLine(bulunanIsimItem);
                    }
                }
                else
                {
                    Console.WriteLine("Aranan isim bulunamadı.");
                }
                Console.Write("Aranacak ismi giriniz ('ç' ile çıkabilirsiniz): ");
                aranacakIsim = Console.ReadLine();
            }
        }
    }
}
