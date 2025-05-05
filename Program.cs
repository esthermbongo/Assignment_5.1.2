namespace Assignment_5._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Sum(a, b);
            Console.WriteLine(Sum(a, b));
        }

        public static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
