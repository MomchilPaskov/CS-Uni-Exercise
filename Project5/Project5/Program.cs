using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Program
{
    class Program
    {
        private static int Sum(int x, int y) 
        {
            return x + y; 
        }

        private static void printMyName(string firstName, string lastName)
        {
            string name = String.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(name);
        }

        static void Swap(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;
        }
        private static void MyDivide(int a, int b, out int result, out int reminder)
        {
            result = a / b;
            reminder = a % b;
        }

        static int InputInteger(string text = "Input int.")
        {
            int n;
            bool isInteger;
            do
            {
                Console.WriteLine(text);
                isInteger = int.TryParse(Console.ReadLine(), out n);
                if (!isInteger)
                    Console.WriteLine("Invalid value!!!");
            }
            while (!isInteger);

            return n;
        }

        static int Factorial( int n )
        {
            if (n <= 1)
                return 1;
            return n * Factorial(n - 1);
        }

        static int InputPositiveInteger(string text = "Input positive int.")
        {
            int n;
            bool isPositiveInteger;
            do
            {
                Console.WriteLine(text);
                isPositiveInteger = int.TryParse(Console.ReadLine(), out n) && n > 0;
                if (!isPositiveInteger)
                    Console.WriteLine("Invalid value!!!");
            }
            while (!isPositiveInteger);
            
            return n;
        }


        static void Main(string[] args)
        {
            int k = InputPositiveInteger();
            int result = Factorial(k);
            Console.WriteLine("{0}! = {1}", k, result);
        }
    }
}