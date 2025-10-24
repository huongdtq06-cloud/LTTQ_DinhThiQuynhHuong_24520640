namespace Bai05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<KhuDat> list = new List<KhuDat>();
            while(true) {
                Console.WriteLine("\n---MENU---");
                Console.WriteLine("1. Nhap danh sach");
                Console.WriteLine("2. Xuat danh sach");
                Console.WriteLine("3. Tong gia ban cua tung loai");
                Console.WriteLine("4. Xuat cac khu dat >100m2 hoac nha pho >60m2 và nam >=2019");
                Console.WriteLine("5. Tim kiem theo dia diem, gia, dien tich");
                Console.WriteLine("0. Thoat");
                int option = int.Parse(Console.ReadLine());
                switch (option) {
                    case 0:
                        return;
                    case 1:
                        Console.WriteLine("Nhap so luong: ");
                        int n = int.Parse(Console.ReadLine());
                        for(int i = 0;i< n; i++) {
                            Console.WriteLine($"Nhap loai khu dat {i+1}:");
                            Console.WriteLine("1. Khu Dat");
                            Console.WriteLine("2. Nha Pho");
                            Console.WriteLine("3. Chung Cu");
                            int loai=int.Parse(Console.ReadLine());
                            KhuDat khuDat;
                            if(loai==1 ) khuDat =new KhuDat();
                            else if(loai==2) khuDat = new NhaPho();
                            else if(loai==3) khuDat = new ChungCu();
                            else {
                                Console.WriteLine("Loai khong hop le. Hay nhap lai.");
                                i--;
                                continue;
                            }
                            khuDat.Nhap();
                            list.Add(khuDat);
                        }
                        break;
                    case 2:
                        Console.WriteLine("\n--DANH SACH---");
                        Console.Write($"{"DiaDiem",12} {"GiaBan(VND)",19} {"DienTich(m2)",15} {"NamXayDung",10} {"SoTang",4}");
                        foreach(var i in  list) { 
                            i.Xuat();
                        }
                        break;
                    case 3:
                        double tongKhuDat = list.Where(x=>x.loai==1).Sum(x => x.GiaBan);                        
                        double tongNhaPho = list.Where(x => x.loai == 2).Sum(x => x.GiaBan);
                        double tongChungCu = list.Where(x => x.loai == 3).Sum(x => x.GiaBan);
                        Console.WriteLine($"\nTong gia Khu Dat: {tongKhuDat}");
                        Console.WriteLine($"Tong gia Nha Pho: {tongNhaPho}");
                        Console.WriteLine($"Tong gia Chung cu: {tongChungCu}");
                        break;
                    case 4:
                        Console.WriteLine("\n--DANH SACH---");
                        Console.Write($"{"DiaDiem",12} {"GiaBan(VND)",19} {"DienTich(m2)",15} {"NamXayDung",10} {"SoTang",4}");
                        
                        foreach (var item in list)
                        {
                            if (item.GetType() == typeof(KhuDat) && item.DienTich > 100)
                            {
                                item.Xuat();
                            }
                            
                            else if (item is NhaPho a && a.DienTich > 60 && a.NamXayDung >= 2019)
                            {
                                a.Xuat();
                            }
                        }
                        break;
                    case 5:
                        Console.Write("Nhap dia diem can tim: ");
                        string dd = Console.ReadLine().ToLower();
                        Console.Write("Nhap gia toi da: ");
                        double gia = double.Parse(Console.ReadLine());
                        Console.Write("Nhap dien tich toi thieu: ");
                        double dt = double.Parse(Console.ReadLine());

                        var kq = list.Where(x =>
                            (x is NhaPho || x is ChungCu) &&
                            x.DiaDiem.ToLower().Contains(dd) &&
                            x.GiaBan <= gia &&
                            x.DienTich >= dt
                        );
                        Console.WriteLine("\n--DANH SACH---");
                        Console.Write($"{"DiaDiem",12} {"GiaBan(VND)",19} {"DienTich(m2)",15} {"NamXayDung",10} {"SoTang",4}");
                        foreach (var item in list)
                        {
                            if ((item.GetType() == typeof(NhaPho) ||item.GetType()== typeof(ChungCu)) && item.DiaDiem.ToLower().Contains(dd) && item.GiaBan <= gia && item.DienTich >= dt)
                            {
                                item.Xuat();
                            }
                        }                        
                        break;
                    
                }
            }
        }
    }
}
