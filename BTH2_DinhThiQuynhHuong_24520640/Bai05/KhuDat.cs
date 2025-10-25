class KhuDat
{
    public string DiaDiem { get; protected set; }
    public double GiaBan { get; protected set; }
    public double DienTich { get;protected set; }
    public int loai { get;protected set; }

    public KhuDat(string diaDiem="unknown", double giaBan=0, double dienTich=0)
    {
        DiaDiem = diaDiem;
        GiaBan = giaBan;
        DienTich = dienTich;
        loai = 1;
    }

    public virtual void Nhap()
    {
        Console.Write("Nhap dia diem: ");
        DiaDiem = Console.ReadLine();
        Console.Write("Nhap gia ban (VND): ");
        GiaBan = double.Parse(Console.ReadLine());
        Console.Write("Nhap dien tich (m2): ");
        DienTich = double.Parse(Console.ReadLine());
    }

    public virtual void Xuat()
    {
        Console.Write($"\n{DiaDiem,12} {GiaBan,15} VND {DienTich,12} m2");
    }
}
