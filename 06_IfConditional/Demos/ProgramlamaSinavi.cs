namespace _06_IfConditional.Demos
{
    public class ProgramlamaSinavi
    {
        public static void Calistir()
        {
            string soru1 = "1) C# programlama dili aşağıdakilerden hangisinin resmi programlama dilidir?";
            string soru1cevap1 = "a) HP";
            string soru1cevap2 = "b) Oracle";
            string soru1cevap3 = "c) Microsoft";
            string soru1cevap4 = "d) Hiçbiri";
            string soru1dogruCevap = "c";
            string soru2 = "2) SQL aşağıdakilerden hangisinde veri yönetimi için kullanılır?";
            string soru2cevap1 = "a) Dosyalarda";
            string soru2cevap2 = "b) Veritabanlarında";
            string soru2cevap3 = "c) İşletim sistemlerinde";
            string soru2cevap4 = "d) Hiçbiri";
            string soru2dogruCevap = "b";
            string soru3 = "3) Programlama dillerinde aşağıdakilerden hangisi bir iş gerçekleştirmek için kullanılır?";
            string soru3cevap1 = "a) Method (fonksiyon)";
            string soru3cevap2 = "b) Değişken";
            string soru3cevap3 = "c) Sabit";
            string soru3cevap4 = "d) Hiçbiri";
            string soru3dogruCevap = "a";
            const int toplamPuan = 30;
            const int dogruCevapPuani = 10;
            string kullaniciCevabi;
            int kullaniciPuani = 0;
            Console.WriteLine("*** Programlama Sınavı (toplam " + toplamPuan + " puan) ***");
            Console.WriteLine(soru1);
            Console.WriteLine(soru1cevap1);
            Console.WriteLine(soru1cevap2);
            Console.WriteLine(soru1cevap3);
            Console.WriteLine(soru1cevap4);
            kullaniciCevabi = Console.ReadLine();
            if (kullaniciCevabi == soru1dogruCevap)
            {
                kullaniciPuani = kullaniciPuani + dogruCevapPuani;
            }
            Console.WriteLine(soru2);
            Console.WriteLine(soru2cevap1);
            Console.WriteLine(soru2cevap2);
            Console.WriteLine(soru2cevap3);
            Console.WriteLine(soru2cevap4);
            kullaniciCevabi = Console.ReadLine();
            if (kullaniciCevabi == soru2dogruCevap)
            {
                kullaniciPuani = kullaniciPuani + dogruCevapPuani;
            }
            Console.WriteLine(soru3);
            Console.WriteLine(soru3cevap1);
            Console.WriteLine(soru3cevap2);
            Console.WriteLine(soru3cevap3);
            Console.WriteLine(soru3cevap4);
            kullaniciCevabi = Console.ReadLine();
            if (kullaniciCevabi == soru3dogruCevap)
            {
                //kullaniciPuani = kullaniciPuani + dogruCevapPuani;
                kullaniciPuani += dogruCevapPuani;
            }
            Console.WriteLine("Toplam kullanıcı puanı: " + kullaniciPuani);
        }
    }
}
