using System.ComponentModel;
using System.Transactions;

namespace Program
{
    class Program
    {


        static bool minEven(int[] arr)
        {
            bool haveEven = false;
            int minEven = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    if (!haveEven)
                    {
                        haveEven = true;
                        minEven = arr[i];
                    }else
                    {
                        if (arr[i] < minEven)
                        {
                            minEven = arr[i];
                        }
                    }
                }
            }
            return haveEven;
        }



        static int LowestNumber(int[] arr)
        {
            int LowestNum = arr[0];
            int indexMin = 0;
            for (int i = 1; i < arr.Length; i++) {
                
                if (arr[i] <= LowestNum)
                {
                    LowestNum = arr[i];
                    indexMin = i;

                }
                
            }
            Console.WriteLine($"The index of the lowest number is {indexMin}");
            return LowestNum;
        }


        static int[,] TransponateMatrix(int[,] matrix) 
        {
            var tmatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    tmatrix[c, r]= matrix[r, c];
                }
            }
            return tmatrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1);c++)
                {
                    Console.Write($"{matrix[r, c]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void InputMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.WriteLine($"Enter value for [{row}, {col}]");
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
        }
        static int SumOfMatrix(int[,] matrix)
        {
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            { 
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                }
            }
            return sum;
        }


        static int[] SumByRows(int[,] matrix)
        {
            int[] sums = new int[matrix.GetLength(0)];
            for (int row = 0;row < matrix.GetLength(1); row++)
            {
                for (int col = 0;col < matrix.GetLength(2); col++)
                {
                    sums[row] += matrix[row, col];
                }
            }
            return sums;
        }

        static int[] SomeSums(int[,] matrix)
        {
            int[] sums = new int[matrix.GetLength(1)];
            for (int c = 0;  c < matrix.GetLength(1); c++)
            {
                for (int r = 0; r < matrix.GetLength(0); r++)
                {
                    if( (c % 2 == 0 && matrix[r,c] % 2 == 0)||(c % 2 != 0 && matrix[r,c] % 2 != 0) ){
                        sums[c] += matrix[r, c];
                    }
                }
            }
            return sums;
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        static void PrintArray(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }


        static double[] AvarageByCols(int[,] matrix)
        {
            double[] avr = new double[matrix.GetLength(1)];
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                int counter = 0;
                for (int r = 0;r < matrix.GetLength(0); r++)
                {
                    if ((c % 2 == 0 && matrix[r, c] % 2 == 0) || (c % 2 != 0 && matrix[r,c] % 2 != 0))
                    {
                        avr[c] += matrix[r, c];
                        counter++;
                    }
                }
                avr[c] /= counter;
            }
            return avr;
        }


        static void Main(string[] args)
        {
            /*int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            InputMatrix(matrix);
            PrintMatrix(matrix);*/


            int[,] matrix = new int[,] { { 16, 2, 6 }, { 9, 5, 7 }, { 2, 8, 14 } };

            var avrs = AvarageByCols(matrix);
            PrintArray(avrs);
        }
    }
}