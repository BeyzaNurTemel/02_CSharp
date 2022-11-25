namespace _10_WhileLoop.Demos
{
    // Mert
    public class MulakatSorusu1
    {
        public static void Calistir()
        {
            // Write an algorithm that calculates and returns the following sum:
            // (1 x 2 - 3 x 4) + (5 x 6 - 7 x 8) + ... + (997 x 998 - 999 x 1000)

            int result = 0;

            //int a = 1;
            //int b = 2;
            //int c = 3;
            //int d = 4;
            //while (a <= 997)
            //{
            //    result += a * b - c * d;
            //    a += 4;
            //    b += 4;
            //    c += 4;
            //    d += 4;
            //}
            int a = 1;
            while (a <= 997)
            {
                result = result + (a * (a + 1) - (a + 2) * (a + 3));
                a += 4;
            }

            Console.WriteLine("Sonuç: " + result);
        }
    }
}
