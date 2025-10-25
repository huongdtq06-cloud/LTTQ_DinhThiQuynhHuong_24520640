namespace Bai04
{
    internal class Program
    {
        class PhanSo
        {
            public int Tu { get;private set; }
            public int Mau { get; private set; }
            public double GiaTri => (double)Tu / Mau;

            public PhanSo(int tu = 0, int mau = 1)
            {
                if (mau == 0) throw new ArgumentException("Mau so khong duoc la 0");
                Tu = tu;
                Mau = mau;            
                
            }
            public static implicit operator PhanSo(int tu)
            {
                return new PhanSo(tu, 1);
            }

            public static PhanSo NhapPhanSo()
            {
                Console.WriteLine("Nhap tu so: ");                
                int tu = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap mau so: ");
                int mau = int.Parse(Console.ReadLine());
                while (mau == 0) {
                    Console.WriteLine("Mau so khong duoc bang 0");
                    Console.WriteLine("Nhap mau so: ");
                    mau = int.Parse(Console.ReadLine());
                };

                return RutGon(new PhanSo(tu, mau));
            }


            private static PhanSo RutGon(PhanSo a)
            {
                int ucln = UCLN(Math.Abs(a.Tu), Math.Abs(a.Mau));
                a.Tu /= ucln;
                a.Mau /= ucln;
                if (a.Mau < 0)
                {
                    a.Tu = -a.Tu;
                    a.Mau = -a.Mau;
                }
                return new PhanSo(a.Tu, a.Mau);
            }

            private static int UCLN(int a, int b)
            {
                while (b != 0)
                {
                    int r = a % b;
                    a = b;
                    b = r;
                }
                return a;
            }
                        
            public static PhanSo operator +(PhanSo a, PhanSo b)
            {
                return RutGon(new PhanSo(a.Tu * b.Mau + b.Tu * a.Mau, a.Mau * b.Mau));
            }

            
            public static PhanSo operator -(PhanSo a, PhanSo b)
            {
                return RutGon(new PhanSo(a.Tu * b.Mau - b.Tu * a.Mau, a.Mau * b.Mau));
            }

            
            public static PhanSo operator *(PhanSo a, PhanSo b)
            {
                return RutGon(new PhanSo(a.Tu * b.Tu, a.Mau * b.Mau));
            }

            
            public static PhanSo operator /(PhanSo a, PhanSo b)
            {
                if (b.Tu == 0) throw new DivideByZeroException("Không thể chia cho 0");
                return RutGon(new PhanSo(a.Tu * b.Mau, a.Mau * b.Tu));
            }
                        
            

            public override string ToString()
            {

                return $"{Tu}/{Mau}";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap phan so 1: ");
            PhanSo ps1 = PhanSo.NhapPhanSo();
            Console.WriteLine("Nhap phan so 2: ");
            PhanSo ps2 = PhanSo.NhapPhanSo();
            Console.WriteLine($"{ps1} + {ps2} = {ps1 + ps2}");
            Console.WriteLine($"{ps1} - {ps2} = {ps1 - ps2}");
            Console.WriteLine($"{ps1} * {ps2} = {ps1 * ps2}");
            Console.WriteLine($"{ps1} / {ps2} = {ps1 / ps2}");
                        
            Console.WriteLine("Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            List<PhanSo> list = new List<PhanSo>();
            for(int i=0; i<n; i++) {
                Console.WriteLine($"Nhap phan so thu {i+1}");
                list.Add(PhanSo.NhapPhanSo());
            }

            Console.Write("Phan so lon nhat: ");
            PhanSo max = list.OrderByDescending(x => x.GiaTri).First();
            Console.WriteLine(max);

            Console.WriteLine("Danh sach phan so sau khi sap xep: ");
            var newlist =list.OrderBy(x => x.GiaTri).ToList();
            Console.WriteLine(string.Join(", ", newlist));
        }
    }
}
