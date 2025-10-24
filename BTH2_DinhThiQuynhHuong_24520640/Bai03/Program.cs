using System.Runtime.Intrinsics.Arm;

namespace Bai03
{
    internal class Program
    {
        //cau a
        public static void input(ref int[,] matrix, ref int n, ref int m) {
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Nhap m: ");
            m = int.Parse(Console.ReadLine());
            matrix = new int[n, m];
            Console.WriteLine("Nhap ma tran: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public static void output(int[,] matrix, int n, int m) {
            Console.WriteLine("Xuat ma tran: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j]+" ");
                }
                Console.WriteLine();
            }
        }

        //cau b
        public static (int,int) find(int[,] matrix, int n, int m, int x) 
        {
            int s1=-1, s2=-1;
            for (int i = 0; i<n; i++)
            {
                for (int j = 0; j<m; j++)
                {
                        if (matrix[i, j] == x) 
                            return (i, j); 
                }
            }
            return (s1, s2);            
        }

            //cau c
        public static bool isPrime(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }

        public static void printPrimeElements(int[,] matrix, int n, int m) {
            Console.WriteLine("Cac phan tu la so nguyen to:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (isPrime(matrix[i, j])) Console.Write($"{matrix[i, j]} ");                        
                }
            }
            Console.WriteLine();
        }

        //cau d
        public static void GetRowWithMostPrime(int[,] matrix, int n, int m) {
            Console.WriteLine("Dong co nhieu so nguyen to nhat: ");
            (int, int) max=(0,0);
            bool found = false;
            for (int i = 0; i < n; i++)
            {
                int Count = 0;                
                for (int j = 0; j < m; j++)
                {
                    if (isPrime(matrix[i, j])) {
                        Count++;
                        found = true;
                    }
                    

                }
                if(Count>max.Item2) {
                    max.Item2 = Count;
                    max.Item1 = i;  
                }
            }
            if (!found) return;
            Console.WriteLine($"Dong {max.Item1+1}: ");
            for (int j = 0;j < m; j++) {
                Console.Write($"{matrix[max.Item1, j]} ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[,] matrix= new int[100,100];
            int n=0, m=0;
            while (true) {
                Console.WriteLine("--MENU--");
                Console.WriteLine(@"1. Nhap / xuat ma tran hai chieu cac so nguyen 
2. Tim kiem mot phan tu trong ma tran 
3. Xuat cac phan tu la so nguyen to 
4. Cho biet dong nao co nhieu so nguyen to nhat
0. Thoat chuong trinh");
                int option= int.Parse(Console.ReadLine());
                switch(option) {
                    case 0:
                        return;
                    case 1:
                        input(ref matrix, ref n, ref m);
                        output(matrix, n, m);
                        break;
                    case 2:
                        Console.WriteLine("Nhap phan tu can tim: ");
                        int k=int.Parse(Console.ReadLine());
                        Console.WriteLine($"Phan tu o vi tri {find(matrix, n, m, k)}");
                        break;
                    case 3:
                        printPrimeElements(matrix, n, m);
                        break;
                    case 4:
                        GetRowWithMostPrime(matrix, n, m);
                        break;
                }
            }
        }    
    }
}
