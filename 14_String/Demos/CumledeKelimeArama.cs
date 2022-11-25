namespace _14_String.Demos
{
    public class CumledeKelimeArama
    {
        public static void Calistir()
        {
            // bir cümle içerisinde girilen kelimeyi case insensitive şekilde ve girilen kelimenin başındaki veya sonundaki boşlukları dikkate almayarak bulalım
            string cumle = "Merhaba benim adım Çağıl";
            Console.WriteLine("Cümle: " + cumle);
            Console.Write("Aranacak kelime: ");
            string kelime = Console.ReadLine();
            // 1. yöntem: Yanlış yöntem çünkü kelime yerine cümlenin içerisindeki girilen herhangi bir ifadeyi arıyor.
            //if (cumle.ToUpper().Contains(kelime.ToUpper().Trim()))
            //{
            //    Console.WriteLine("\"" + cumle + "\" cümlesi içerisinde \"" + kelime + "\" kelimesi bulundu.");
            //}
            //else
            //{
            //    Console.WriteLine("\"" + cumle + "\" cümlesi içerisinde \"" + kelime + "\" kelimesi bulunamadı.");
            //}
            // 2. yöntem: Doğru yöntem çünkü cümle içerisinde girilen kelimeyi arıyoruz.
            bool bulundu = false;
            string[] cumleKelimeleri = cumle.Split(' ');
            foreach (string cumleKelime in cumleKelimeleri)
            {
                //if (cumleKelime.ToUpper().Equals(kelime.ToUpper().Trim()))
                if (cumleKelime.ToUpper() == kelime.ToUpper().Trim())
                {
                    bulundu = true;
                    break;
                }
            }
            if (bulundu)
                Console.WriteLine("\"" + cumle + "\" cümlesi içerisinde \"" + kelime + "\" kelimesi bulundu.");
            else
                Console.WriteLine("\"" + cumle + "\" cümlesi içerisinde \"" + kelime + "\" kelimesi bulunamadı.");
        }
    }
}
