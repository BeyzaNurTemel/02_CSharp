namespace _13_ForEachLoop.Demos
{
    public class PlakalaraGoreSehirler
    {
        public static void Calistir()
        {
            Console.WriteLine("*** Plakalara Göre Şehirler ***");
            string[,] plakalaraGoreSehirler = new string[3, 2]
            {
                { "06", "Ankara" },
                { "34", "İstanbul" },
                { "35", "İzmir" }
            };
            foreach (string s in plakalaraGoreSehirler)
            {
                Console.WriteLine(s);
            }
            for (int i = 0; i <= plakalaraGoreSehirler.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= plakalaraGoreSehirler.GetUpperBound(1); j++)
                {
                    Console.Write(plakalaraGoreSehirler[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
