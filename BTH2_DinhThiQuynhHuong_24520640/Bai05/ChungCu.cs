
namespace Bai05
{
    class ChungCu : KhuDat
    {
        public int Tang { get; set; }
        public ChungCu(string diaDiem = "unknown", double giaBan = 0, double dienTich = 0,int tang=0)
            :base(diaDiem,giaBan,dienTich) 
        {
            Tang= tang;
            loai = 3;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so tang: ");
            Tang = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.Write($"{" ",11}{Tang,4}");
        }
    }

}
