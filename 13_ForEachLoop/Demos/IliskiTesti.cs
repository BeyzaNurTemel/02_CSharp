namespace _13_ForEachLoop.Demos
{
    public class IliskiTesti
    {
        public static void Calistir()
        {
            string[] sorular = new string[]
            {
                "Kıskanç mısın? (1: hayır, 2: evet)",
                "Aşk mı para mı? (1: aşk, 2: para)",
                "Köpek mi kedi mi? (1: köpek, 2: kedi)",
                "Marka takıntılı mısın? (1: hayır, 2: evet)",
                "Zeka mı tip mi? (1: zeka, 2: tip)"
            };
            string[] cevaplar = new string[sorular.Length];
            for (int i = 0; i < sorular.Length; i = i + 1)
            {
                Console.Write(sorular[i] + " ");
                cevaplar[i] = Console.ReadLine();
            }
            int sonuc = 0;
            foreach (string cevap in cevaplar)
            {
                if (cevap == "1")
                {
                    sonuc = sonuc + 20;
                }
            }
            if (sonuc > 70)
            {
                Console.WriteLine("Harika bir ilişkiniz olabilir.");
            }
            else if (sonuc >= 30 && sonuc <= 70)
            {
                Console.WriteLine("İlişkiye bir şans verilebilir.");
            }
            else
            {
                Console.WriteLine("Vazgeçsen bu ilişkiden iyi olur.");
            }
        }
    }
}
