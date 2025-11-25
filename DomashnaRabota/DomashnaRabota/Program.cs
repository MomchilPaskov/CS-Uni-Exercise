namespace DomashnaRabota
{
    class Program
    {
        static int ntichlenIterative(int n)
        {
            int a1 = 2;
            int a2 = 4;
            int a3 = 6;
            int current = 0;
            if (n == 1) 
                return 2;
            if (n == 2) 
                return 4;
            if (n == 3) 
                return 6;

            for (int i = 4; i <= n; i++)
            {
                current = 3 * a1 + 4 * a2 - 7 * a3;
                a1 = a2;
                a2 = a3;
                a3 = current;
            }
            return current;
        }


        static int ntichlenRecursive(int n)
        {
            if (n == 1) return 2;
            if (n == 2) return 4;
            if (n == 3) return 6;

            return 3 * ntichlenRecursive(n - 3)
                 + 4 * ntichlenRecursive(n - 2)
                 - 7 * ntichlenRecursive(n - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Iterative: " + ntichlenIterative(n));
            Console.WriteLine("Recursive: " + ntichlenRecursive(n));

        }

    }
}