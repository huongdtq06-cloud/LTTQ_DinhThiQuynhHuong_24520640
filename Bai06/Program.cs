using System;
using System.Numerics;

namespace Bai06
{
    internal class Program
    {
        //cau a
        public static void Print(int[,] matrix) 
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        //cau b
        public static (int,int) GetMax(int[,] matrix) {
            var max =(0,0);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i,j]>matrix[max.Item1,max.Item2]) {
                        max.Item1 = i; max.Item2 = j;
                    }                    
                }                
            }
            return max;
        }
        public static (int, int) GetMin(int[,] matrix)
        {
            var min = (0, 0);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < matrix[min.Item1, min.Item2])
                    {
                        min.Item1 = i; min.Item2 = j;
                    }
                }
            }
            return min;
        }

        //cau c
        public static int GetSumOfRow(int[,] matrix) {
            int sum1 = 0,sum2=0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {               
                sum1 = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum1+= matrix[i, j];
                }
                if (sum1 > sum2) sum2 = sum1;
            }
            return sum2;
        }

        //cau d
        public static bool isPrime(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }

        public static int GetSum(int[,] matrix) {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {                
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (!isPrime(matrix[i, j])) sum += matrix[i, j];
                }                
            }
            return sum;
        }

        //cau e
        public static void RemoveRow(ref int[,] matrix, int k) {
            try {                 
                int[,] NewMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (i == k) continue;
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (i > k) NewMatrix[i - 1, j] = matrix[i, j];
                        else NewMatrix[i, j] = matrix[i, j];                    
                    }
                }
                matrix = NewMatrix;
            } catch {
                Console.WriteLine($"Ma tran khong co dong {k+1}.");
            }
        }

        //cau f
        public static void RemoveCol(ref int[,] matrix)
        {
            var pos=GetMax(matrix);
            int k = pos.Item2;
            int[,] NewMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)-1];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == k) continue;
                    if (j > k) NewMatrix[i, j-1] = matrix[i, j];
                    else NewMatrix[i, j] = matrix[i, j];
                }
            }
            matrix = NewMatrix;
        }


        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n=int.Parse(Console.ReadLine());
            Console.Write("Nhap m: ");
            int m= int.Parse(Console.ReadLine());         
            var matrix = new int[n, m];
            for(int i = 0; i < n; i++) {
                for(int j = 0; j < m; j++) {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Nhap k: ");
            int k = int.Parse(Console.ReadLine());
            k--;
            Console.WriteLine("Ma tran: ");
            Print(matrix);

            var tmp = GetMax(matrix);
            Console.WriteLine($"Max: {matrix[tmp.Item1,tmp.Item2]}");
            tmp = GetMin(matrix);
            Console.WriteLine($"Min: {matrix[tmp.Item1, tmp.Item2]}");

            Console.WriteLine($"Tong cac so khong phai so nguyen to: {GetSum(matrix)}");
            
            RemoveRow(ref matrix, k);
            Console.WriteLine($"Ma tran sau khi xoa hang {k+1}: ");
            Print(matrix);

            RemoveCol(ref matrix);
            Console.WriteLine("Ma tran sau khi xoa cot co phan tu lon nhat: ");
            Print(matrix);

        }
        
    }
}
