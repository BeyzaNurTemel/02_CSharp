namespace _06_IfConditional.Demos
{
    public class HesapMakinesi
    {
        public static void Calistir()
        {
            // SORU: Girilen herhangi iki sayının yine kullanıcının belirttiği işleme tabi tutularak sonucu ekrana yazın.
            Console.Write("1. sayıyı girin: ");
            double s1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2. sayıyı girin: ");
            double s2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İstediğiniz işlemi işaret olarak girin: ");
            string i = Console.ReadLine();

            double sonuc = 0.0;
            if (i == "+")
                sonuc = s1 + s2;
            else if (i == "-")
                sonuc = s1 - s2;
            else if (i == "*")
                sonuc = s1 * s2;
            else
                sonuc = s1 / s2;

            // Console.WriteLine(s1 + " " + c + " " + s2 + " = " + sonuc);
            //Console.WriteLine("{0} {1} {2} = {3}", s1, i, s2, sonuc);
            Console.WriteLine($"{s1} {i} {s2} = {sonuc}");
        }
    }
}
