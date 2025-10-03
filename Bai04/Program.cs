namespace Bai04
{
    internal class Program
    {

        public static bool isLeapYear(int year)
        {
            if (year % 100 == 0 && year % 400 != 0) return false;
            if (year % 4 != 0) return false;
            return true;
        }
        public static int getDay(string my) {
            try {            
                var str= my.Split('/');
                int m=int.Parse(str[0]);
                int y=int.Parse(str[1]);

                if(m >12 || m<1) return -1;
                if(y < 1) return -1;

                if (m == 4 || m == 6 || m == 9 || m == 11) return 30;
                if (m==2 && isLeapYear(y) ) return 29;
                if (m == 2) return 28;
                return 31;
            }
            catch {
                return -1;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap thang nam (mm/yyyy): ");
            string my = Console.ReadLine();
            Console.Write($"So ngay: {getDay(my)}"); 
        }
    }
}
