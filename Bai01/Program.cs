using System;

internal class Program {
    //cau a
    public static bool isOddNum(int x) {
        if(x % 2==0) return false;
        return true;
    }
    public static int getSumOfOddNums(int[] arr) {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (isOddNum(arr[i])) sum += arr[i];
        }
        return sum;
    }

    //cau b
    public static bool isPrime(int x) {
        if (x<2 ) return false;
        for (int i = 2;i <=Math.Sqrt(x);i++) {
            if(x%i==0) return false;
        }
        return true;
    }
    public static int countPrime(int[] arr) {
        int count = 0;
        for(int i = 0;i<arr.Length;i++) {
            if(isPrime(arr[i])) count++;
        }
        return count;
    }

    //cau c
    public static bool isPerfectSquare(int x) {
        if(x<0) return false;
        int a= (int)Math.Sqrt(x);
        return a * a == x;
    }
    public static int getSmallestPerfectSquare(int[] arr) {
        int smallestPS=int.MaxValue;
        
        for (int i=0; i<arr.Length; i++) {
            if(arr[i]<smallestPS && isPerfectSquare(arr[i])) {
                smallestPS = arr[i];
            }
        }
        if (smallestPS == int.MaxValue) return -1;
        return smallestPS;
    }
    public static void Main(string[] args) {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        var arr = new int[n];
        
        for (int i = 0; i < n; i++) {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int sum = getSumOfOddNums(arr);
        int numberOfPrimes = countPrime(arr);
        int smallestPS = getSmallestPerfectSquare(arr);

        Console.WriteLine($"Tong cac so le trong mang: {sum}");
        Console.WriteLine($"So nguyen to trong mang: {numberOfPrimes}");
        Console.WriteLine($"So chinh phuong nho nhat: {smallestPS}");

    }
}