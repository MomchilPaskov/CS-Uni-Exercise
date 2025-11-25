using System.Globalization;

namespace Program 
{
    class Program 
    {

        static int PowerR(int m, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n == 1)
            {
                return m;
            }
            return m * PowerR(m, n-1);
        }

        static int PowerI(int m, int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
                result *= m;
            return result;
        }

        static int Fibonacci(int n)
        {
            if (n == 1)
            {
                return 0;
            }
            if (n == 2)
            {
                return 1;
            }
            if (n <= 2)
                return -1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }





        static void Main(string[] args)
        {
            //int x = 2;
            //int y = 31;
            //var beforeCall = DateTime.Now;
            //int result = PowerI(x, y);
            //var timeElapsed = DateTime.Now - beforeCall;
            //Console.WriteLine($"{x}^{y} = {result}");
            //Console.WriteLine(timeElapsed);

            //beforeCall = DateTime.Now;
            //result = PowerI(x, y);
            //timeElapsed = DateTime.Now - beforeCall;
            //Console.WriteLine(timeElapsed);

            int a = 9;

            int result = Fibonacci(a);
            Console.WriteLine(result);

        }
    }
}