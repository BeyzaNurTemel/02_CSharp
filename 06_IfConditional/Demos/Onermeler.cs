namespace _06_IfConditional.Demos
{
    public class Onermeler
    {
        public static void Calistir()
        {
            Console.WriteLine("*** Logical Operators ***");
            bool p, q, result;
            p = true;
            q = true;
            result = p && q;
            Console.WriteLine("p: " + p + " && (and) q: " + q + " = " + result);
            result = p || q;
            Console.WriteLine("p: " + p + " || (or) q: " + q + " = " + result);
            p = false;
            q = true;
            result = p && q;
            Console.WriteLine("p: " + p + " && (and) q: " + q + " = " + result);
            result = p || q;
            Console.WriteLine("p: " + p + " || (or) q: " + q + " = " + result);
            p = true;
            q = false;
            result = p && q;
            Console.WriteLine("p: " + p + " && (and) q: " + q + " = " + result);
            result = p || q;
            Console.WriteLine("p: " + p + " || (or) q: " + q + " = " + result);
            p = false;
            q = false;
            result = p && q;
            Console.WriteLine("p: " + p + " && (and) q: " + q + " = " + result);
            result = p || q;
            Console.WriteLine("p: " + p + " || (or) q: " + q + " = " + result);
        }
    }
}
