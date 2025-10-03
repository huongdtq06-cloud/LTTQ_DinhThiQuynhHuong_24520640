namespace Bai03
{
    internal class Program
    {
        public static bool isLeapYear(int year) {
            if(year % 100 == 0 && year % 400!=0) return false;
            if(year %4!=0) return false;
            return true;
        }
        public static bool check(string date) {
            try {
                string[] str= date.Split('/');
            
                int d = int.Parse(str[0]);
                int m = int.Parse(str[1]);
                int y = int.Parse(str[2]);
                
                if(y<1) return false;
                if (m>12 || m<1) return false ;
                if(d >31 || d<1) return false;

                if (!isLeapYear(y) && m == 2 && d > 28) return false;
                if(m==2 && d >29) return false;
                if (d == 31 && (m == 4 || m == 6 || m == 9 || m == 11)) return false;
            

                return true ;

            }
            catch
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap ngay thang nam (dd/mm/yyyy): ");
            string date =Console.ReadLine();
            if(check(date) )  Console.WriteLine("Hop le.");
            else Console.WriteLine("Khong hop le.");
        }
    }
}
