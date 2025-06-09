namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(1.5m, 2.6m));
            Console.WriteLine(Add(1,0,false));
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        static string? Add(int a, int b, bool c)
        {
            if (c)
            {
                return a + b == 1 ? "1 dollar" : $"{a + b} dollars";
            }
            else
            {
                return null;
            }
        }
    }
}
