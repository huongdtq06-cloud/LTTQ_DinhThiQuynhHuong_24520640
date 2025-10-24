namespace Bai01
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

                int m = int.Parse(str[0]);
                int y = int.Parse(str[1]);

                if (y < 1) return false;
                if (m > 12 || m < 1) return false;


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
        public static int count(int d, int m, int y)
        {
            int count = 0;
            for (int i = 1; i < y; i++)
            {
                if (isLeapYear(i)) count += 366;
                else count += 365;
            }
            for (int i = 1; i < m; i++)
            {
                count += getDaysInMonth(i, y);
            }
            count += d;
            return count;
        }

        public static int getDayOfWeek(int d, int m, int y)
        {
            
            int tmp = count(d, m, y) % 7;
            return tmp;           
        }

        public static void print( int m, int y) {
            Console.WriteLine($"Month: {m}/{y}");
            Console.WriteLine($"{"SUN",4}{"MON",4}{"TUE",4}{"WED",4}{"THU",4}{"FRI",4}{"SAT",4}");
            int days = getDaysInMonth(m, y);
            int DayOfWeek=getDayOfWeek(1,m,y);
            int begin=DayOfWeek;
            
            while (begin>0) {
                Console.Write($"{" ",4}");
                begin--;
            }
            for (int i = 1; i <= days; i++) {
                if (DayOfWeek == 0) Console.WriteLine();
                Console.Write($"{i,4}");
                DayOfWeek = (DayOfWeek+1)%7;
                
            }         


        }

        static void Main(string[] args)
        {
            Console.Write("Nhap thang nam (mm/yyyy): ");
            var date = Console.ReadLine();

            int d, m, y;
            try
            {
                string[] str = date.Split('/');


                m = int.Parse(str[0]);
                y = int.Parse(str[1]);
                if (!check(date)) {
                    Console.WriteLine("khong hop le.");
                    return;
                }
                
            }
            catch
            {
                Console.WriteLine( "khong hop le.");
                return;
            }

            print( m, y);
        }
    }
}
