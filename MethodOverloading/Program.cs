namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5, 5, true));
            Console.WriteLine(Add(3, 3));
            Console.WriteLine(Add(5.5, 5.5));
        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static double Add(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }

        public static string Add(int numOne, int numTwo, bool isTrue)
        {
            var sum = numOne + numTwo;
            if (isTrue && sum == 1)
            {
                return $"{sum} dollar";
            }

            return $"{sum} dollars";
        }
    }
}
