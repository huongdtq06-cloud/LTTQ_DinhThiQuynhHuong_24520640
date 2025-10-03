namespace Bai05
{
    internal class Program
    {
        public static bool isLeapYear(int year)
        {
            return (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0));
            
        }
        public static bool check(string date)
        {
            try
            {
                string[] str = date.Split('/');

                int d = int.Parse(str[0]);
                int m = int.Parse(str[1]);
                int y = int.Parse(str[2]);

                if (y < 1) return false;
                if (m > 12 || m < 1) return false;
                if (d > 31 || d < 1) return false;

                if (!isLeapYear(y) && m == 2 && d > 28) return false;
                if (m == 2 && d > 29) return false;
                if (d == 31 && (m == 4 || m == 6 || m == 9 || m == 11)) return false;


                return true;

            }
            catch
            {
                return false;
            }
        }
        public static int getDaysInMonth(int m, int y)
        {            
            if (m == 4 || m == 6 || m == 9 || m == 11) return 30;
            if (m == 2 && isLeapYear(y)) return 29;
            if (m == 2) return 28;
            return 31;            
        }
        public static int count(int d, int m, int y) {
            int count = 0;
            for (int i = 1; i < y; i++) {
                if(isLeapYear(i)) count+=366;
                else count+=365;
            }
            for (int i = 1;i < m; i++) {
                count += getDaysInMonth(i, y);
            }
            count += d;
            return count;
        }
        
        public static string getDayOfWeek(string date) {
            int d, m, y;
            try
            {
                string[] str = date.Split('/');

                d = int.Parse(str[0]);
                m = int.Parse(str[1]);
                y = int.Parse(str[2]);


                if (!check(date)) return "khong hop le.";
            }
            catch
            {
                return "khong hop le.";
            }
            int tmp=count(d, m, y)%7;
            switch(tmp) {
                case 1:
                    return "Thu hai";
                case 2:
                    return "Thu ba";
                case 3:
                    return "Thu tu";
                case 4:
                    return "Thu nam";
                case 5:
                    return "Thu sau";
                case 6:
                    return "Thu bay";
                case 0:
                    return "Chu nhat";
                default:
                    return "Khong hop le";
            }
            
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap ngay thang nam (dd/mm/yyyy): ");
            var date=Console.ReadLine();

            Console.WriteLine(getDayOfWeek(date));
        }
    }
}
