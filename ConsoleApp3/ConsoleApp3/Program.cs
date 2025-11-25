using System.Transactions;

namespace Program
{
    class Program
    {


        static void InputArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter value for [{i}]");
                arr[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"value for [{i}] is changed to {arr[i]}");

            }
        }

        static void PrintArray(int[] arr)
        {
            Console.WriteLine("Your array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }



        static int[] ReverseArray(int[] arr) 
        {
            int[] rarr = new int[arr.Length];
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                rarr[n-i-1] = arr[i];
            }
            return rarr;
        }


        static void ReverseArrayInplace(int[] arr)
        {
            int n = arr.Length;

            for(int i = 0; i < n/2;  i++)
            {
                int t = arr[i];
                arr[i] = arr[n-1-i];
                arr[n - 1 - i] = t;
            }
        }


        static void Main(string[] args)
        {
            int n = 5;
            
            int[] array = new int[n];
            InputArray(array);
            PrintArray(array);
            
            ReverseArrayInplace(array);
            
            PrintArray(array);
            
            
        }
    }
}