namespace Bai02
{
    internal class Program
    {
        public static bool isPrime(int x)
        {
            if (x < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static int getSum(int n) {
            int sum = 0;
            for(int i = 0; i < n; i++) {
                if (isPrime(i)) sum += i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tong cac so nguyen to <n: {getSum(n)}");
        }
    }
}
