// params Keyword in Methods (Methodlarda params Kullanımı)

namespace _05_ParamsKeywordInMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Method Çağrımları
            decimal toplam = Topla(0.5M, 1.5M, 2.5M); // params kullanıldığı için istenilen sayıda parametre virgülle ayrılarak gönderilebilir, decimal veriler için M yerine m de kullanılabilir
            Console.WriteLine(toplam); // konsola 4,5 yazdıracaktır



            SumAndDisplay("Sum", 1, 2, 3, 4); // konsola 10 yazdıracaktır
            #endregion
        }



        #region Methodlar
        static decimal Topla(params decimal[] sayilar)
        {
            return sayilar.Sum(); // [] sayilar parametresinin bir kolleksiyon olduğunu belirtir, Sum methodu ise o kolleksiyondaki elemanların toplanmasını sağlar
        }



        static void SumAndDisplay(string message, params int[] numbers) // params ile belirtilen parametre en sonda olmalıdır
        {
            Console.WriteLine(message + ": " + numbers.Sum());
        }
        #endregion
    }
}