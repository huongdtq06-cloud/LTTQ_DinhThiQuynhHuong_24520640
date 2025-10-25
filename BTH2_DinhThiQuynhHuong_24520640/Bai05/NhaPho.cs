namespace Bai05
{
    class NhaPho : KhuDat
    {
        public int NamXayDung { get;private set; }
        public int SoTang { get;private set; }

        public NhaPho(string diaDiem = "unknown", double giaBan = 0, double dienTich = 0,int namXayDung=0, int soTang=0)
            : base(diaDiem,giaBan,dienTich) 
        {            
            NamXayDung = namXayDung;
            SoTang = soTang;
            loai = 2;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap nam xay dung: ");
            NamXayDung = int.Parse(Console.ReadLine());
            Console.Write("Nhap so tang: ");
            SoTang = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.Write($"{NamXayDung,10} {SoTang,4}");
        }
    }

}
