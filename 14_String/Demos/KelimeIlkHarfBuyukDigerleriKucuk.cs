namespace _14_String.Demos
{
    public class KelimeIlkHarfBuyukDigerleriKucuk
    {
        public static void Calistir()
        {
            string sonuc;
            string adSoyad;
            string ad;
            string soyad;
            string[] kelimeler;
            int indexOfBosluk;

            Console.Write("Ad soyad girin: ");
            adSoyad = Console.ReadLine();

            // 1) İki kelime için:
            //indexOfBosluk = adSoyad.IndexOf(" ");
            //ad = adSoyad.Substring(0, indexOfBosluk);
            //soyad = adSoyad.Substring(indexOfBosluk + 1);
            //sonuc = FirstLetterToUpperOthersToLower(ad) + " " + FirstLetterToUpperOthersToLower(soyad);

            // 2) Sınırsız kelime için:
            sonuc = "";
            kelimeler = adSoyad.Split(' ');
            foreach (string kelime in kelimeler)
            {
                sonuc += FirstLetterToUpperOthersToLower(kelime) + " ";
            }
            sonuc = sonuc.TrimEnd();

            Console.WriteLine(sonuc);
        }

        static string FirstLetterToUpperOthersToLower(string input)
        {
            string result = "";
            if (input.Length > 0)
            {
                char[] inputCharArray;

                // 1. yöntem:
                //inputCharArray = new char[input.Length];
                //for (int i = 0; i < inputCharArray.Length; i++)
                //{
                //    inputCharArray[i] = input[i];
                //}

                // 2. yöntem:
                inputCharArray = input.ToCharArray();

                for (int i = 0; i < inputCharArray.Length; i++)
                {
                    if (i == 0)
                    {
                        inputCharArray[i] = inputCharArray[i].ToString().ToUpper()[0];
                    }
                    else
                    {
                        inputCharArray[i] = inputCharArray[i].ToString().ToLower()[0];
                    }
                }

                // 1. yöntem:
                //foreach (char item in inputCharArray)
                //{
                //    result += item;
                //}

                // 2. yöntem:
                result = new string(inputCharArray);

            }
            return result;
        }
    }
}
