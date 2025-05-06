namespace Assignment_5._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int target = int.Parse(Console.ReadLine());
        }

        public static int Sum(int target)
        {
            int sum = 0;

            while (target > 0)
            {
                sum = sum + target % 10;
                target = target / 10;
            }


            return sum;
            Console.WriteLine(sum);
        }


    }
}
