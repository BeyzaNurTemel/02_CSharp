namespace _09_Loops.Demos
{
    public class IngilizceAlfabe
    {
        public static void Calistir()
        {
            // A'dan Z'ye İngilizce büyük harfleri yazdıralım.

            // ASCII tablosu üzerinden 1. çözüm:
            //for (int i = 65; i <= 90; i++)
            //{
            //    Console.Write((char)i + " ");
            //}

            // ASCII tablosu üzerinden 2. çözüm:
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
            // A'dan Z'ye İngilizce büyük ve küçük harfleri yazdıralım.

            for (char c = 'A'; c <= 'z'; c++)
            {
                // 1. çözüm:
                //if (c <= 'Z' || c >= 'a')
                //    Console.Write(c + " ");

                // 2. çözüm:
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                    Console.Write(c + " ");
            }
        }
    }
}
