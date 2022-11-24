namespace _06_IfConditional.Demos
{
    public class OgrenciNotOrtalamasi
    {
        public static void Calistir()
        {
            /* Algoritma:
            1-basla
            2-vize1 gir
            3-vize2 gir
            4-final gir
            5-ortalama=(vize1+vize2)*0.2+final*0.6
            6-eger ortalama<60 kaldi
            7-eger ortalama>=60 geçti
            8-bitir
            */

            string ogrenciAdi;
            double vize1;
            double vize2;
            double final;
            double ortalama;
            const double vizeCarpan = 0.2; // constant
            const double finalCarpan = 0.6; // constant
            //vizeCarpan = 0.1; // hata verecektir sabit olduğu için, sabitler değiştirilemez

            Console.Write("Öğrenci adı: ");
            ogrenciAdi = Console.ReadLine();

            Console.Write("1. Vize: ");
            vize1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2. Vize: ");
            vize2 = double.Parse(Console.ReadLine());

            Console.Write("Final: ");
            final = double.Parse(Console.ReadLine());

            //ortalama = (vize1 + vize2) * 0.2 + final * 0.6;
            ortalama = (vize1 + vize2) * vizeCarpan + final * finalCarpan;
            if (ortalama >= 60)
                Console.WriteLine(ogrenciAdi + " ortalaması: " + ortalama + " - Geçti!");
            else
                Console.WriteLine("{0} ortalaması: " + ortalama + " - Kaldı!", ogrenciAdi);
        }
    }
}
