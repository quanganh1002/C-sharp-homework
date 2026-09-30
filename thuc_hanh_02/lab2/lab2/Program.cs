using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    // BÀI 1.1: TÍNH TUỔI 1 SINH VIÊN
    class SinhVien
    {
        // Field
        private string hoTen;
        private int namSinh;

        // Constructor
        public SinhVien(string hoTen, int namSinh)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
        }

        // Property
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public int NamSinh
        {
            get { return namSinh; }
            set { namSinh = value; }
        }

        // Method
        public int TinhTuoi()
        {
            return DateTime.Now.Year - namSinh;
        }
    }


    // BÀI 1.2: LỚP POINT
    class Point
    {
        // Field
        private double x;
        private double y;

        // Constructor mặc định
        public Point()
        {
            x = 0;
            y = 0;
        }

        // Constructor có tham số
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Property
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        // Method Input
        public void Input()
        {
            Console.Write("Nhap x: ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Nhap y: ");
            y = double.Parse(Console.ReadLine());
        }

        // Method Output
        public void Output()
        {
            Console.WriteLine("(" + x + ", " + y + ")");
        }

        // Override ToString
        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }

        // Phép cộng 2 Point
        public static Point operator +(Point a, Point b)
        {
            return new Point(a.x + b.x, a.y + b.y);
        }

        // Phép trừ 2 Point
        public static Point operator -(Point a, Point b)
        {
            return new Point(a.x - b.x, a.y - b.y);
        }

        // Phép lấy âm
        public static Point operator -(Point a)
        {
            return new Point(-a.x, -a.y);
        }

        // Khoảng cách - phương thức thành viên
        public double KhoangCach(Point b)
        {
            double dx = x - b.x;
            double dy = y - b.y;

            return Math.Sqrt(dx * dx + dy * dy);
        }

        // Khoảng cách - phương thức tĩnh
        public static double KhoangCach(Point a, Point b)
        {
            double dx = a.x - b.x;
            double dy = a.y - b.y;

            return Math.Sqrt(dx * dx + dy * dy);
        }

        // Trung điểm - phương thức thành viên
        public Point TrungDiem(Point b)
        {
            return new Point((x + b.x) / 2, (y + b.y) / 2);
        }

        // Trung điểm - phương thức tĩnh
        public static Point TrungDiem(Point a, Point b)
        {
            return new Point((a.x + b.x) / 2, (a.y + b.y) / 2);
        }
    }


    // BÀI 1.3: LỚP PERSON
    class Person
    {
        // Field
        private int id;
        private string name;
        private int yob;
        private int yod;

        // Default Constructor
        public Person()
        {
            id = 0;
            name = "";
            yob = 0;
            yod = 0;
        }

        // Copy Constructor
        public Person(Person p)
        {
            id = p.id;
            name = p.name;
            yob = p.yob;
            yod = p.yod;
        }

        // Constructor có tham số
        public Person(int id, string name, int yob, int yod)
        {
            this.id = id;
            this.name = name;
            this.yob = yob;
            this.yod = yod;
        }

        // Property
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Yob
        {
            get { return yob; }
            set { yob = value; }
        }

        public int Yod
        {
            get { return yod; }
            set { yod = value; }
        }

        // Method Input
        public void Input()
        {
            Console.Write("Nhap ID: ");
            id = int.Parse(Console.ReadLine());

            Console.Write("Nhap ten: ");
            name = Console.ReadLine();

            Console.Write("Nhap nam sinh: ");
            yob = int.Parse(Console.ReadLine());

            Console.Write("Nhap nam mat: ");
            yod = int.Parse(Console.ReadLine());
        }

        // Method Output
        public void Output()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Nam sinh: " + yob);
            Console.WriteLine("Nam mat: " + yod);
        }

        // Kiểm tra còn sống
        public bool IsLiving()
        {
            return yod == 0;
        }
    }


    // BÀI 1.4: LỚP PHÂN SỐ
    class PhanSo
    {
        // Field
        private int tu;
        private int mau;

        //Input
        public void Input()
        {
            Console.Write("Nhap tu so: ");
            tu = int.Parse(Console.ReadLine());

            Console.Write("Nhap mau so: ");
            mau = int.Parse(Console.ReadLine());
        }

        // Constructor mặc định
        public PhanSo()
        {
            tu = 0;
            mau = 1;
        }

        // Constructor có tham số
        public PhanSo(int tu, int mau)
        {
            this.tu = tu;
            this.mau = mau;
        }

        // Constructor chỉ có tử
        public PhanSo(int tu)
        {
            this.tu = tu;
            mau = 1;
        }

        // Copy Constructor
        public PhanSo(PhanSo p)
        {
            tu = p.tu;
            mau = p.mau;
        }

        // Property
        public int Tu
        {
            get { return tu; }
            set { tu = value; }
        }

        public int Mau
        {
            get { return mau; }
            set { mau = value; }
        }

        // Rút gọn phân số
        private void RutGon()
        {
            int a = Math.Abs(tu);
            int b = Math.Abs(mau);

            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }

            if (a != 0)
            {
                tu /= a;
                mau /= a;
            }

            if (mau < 0)
            {
                tu = -tu;
                mau = -mau;
            }
        }

        // Override ToString
        public override string ToString()
        {
            RutGon();

            if (mau == 1)
                return tu.ToString();

            return tu + "/" + mau;
        }

        // Phép + một ngôi
        public static PhanSo operator +(PhanSo a)
        {
            return new PhanSo(a.tu, a.mau);
        }

        // Phép - một ngôi
        public static PhanSo operator -(PhanSo a)
        {
            return new PhanSo(-a.tu, a.mau);
        }

        // Phép cộng
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            return new PhanSo(
                a.tu * b.mau + b.tu * a.mau,
                a.mau * b.mau
            );
        }

        // Phép trừ
        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            return new PhanSo(
                a.tu * b.mau - b.tu * a.mau,
                a.mau * b.mau
            );
        }

        // Phép nhân
        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            return new PhanSo(
                a.tu * b.tu,
                a.mau * b.mau
            );
        }

        // Phép chia
        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            return new PhanSo(
                a.tu * b.mau,
                a.mau * b.tu
            );
        }

        // So sánh >
        public static bool operator >(PhanSo a, PhanSo b)
        {
            return a.tu * b.mau > b.tu * a.mau;
        }

        // So sánh <
        public static bool operator <(PhanSo a, PhanSo b)
        {
            return a.tu * b.mau < b.tu * a.mau;
        }

        // So sánh >=
        public static bool operator >=(PhanSo a, PhanSo b)
        {
            return a.tu * b.mau >= b.tu * a.mau;
        }

        // So sánh <=
        public static bool operator <=(PhanSo a, PhanSo b)
        {
            return a.tu * b.mau <= b.tu * a.mau;
        }

        // So sánh ==
        public static bool operator ==(PhanSo a, PhanSo b)
        {
            return a.tu * b.mau == b.tu * a.mau;
        }

        // So sánh !=
        public static bool operator !=(PhanSo a, PhanSo b)
        {
            return a.tu * b.mau != b.tu * a.mau;
        }

        public override bool Equals(object obj)
        {
            if (obj is PhanSo p)
                return this == p;

            return false;
        }

        public override int GetHashCode()
        {
            return tu ^ mau;
        }
    }


    // BÀI 1.5: LỚP ĐƠN THỨC
    class DonThuc
    {
        // Field
        private double a;
        private int n;

        // Constructor mặc định
        public DonThuc()
        {
            a = 0;
            n = 0;
        }

        // Constructor có tham số
        public DonThuc(double a, int n)
        {
            this.a = a;
            this.n = n;
        }

        // Copy Constructor
        public DonThuc(DonThuc p)
        {
            a = p.a;
            n = p.n;
        }

        // Property
        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public int N
        {
            get { return n; }
            set { n = value; }
        }

        // Tính giá trị P(x)
        public double TinhGiaTri(double x)
        {
            return a * Math.Pow(x, n);
        }

        // Đạo hàm đơn thức
        public DonThuc DaoHam()
        {
            if (n == 0)
            {
                return new DonThuc(0, 0);
            }

            return new DonThuc(a * n, n - 1);
        }

        // Override ToString
        public override string ToString()
        {
            if (n == 0)
                return a.ToString();

            if (n == 1)
                return a + "x";

            return a + "x^" + n;
        }
    }

    // BÀI 2.1: LỚP ARRAYPOINT
    class ArrayPoint
    {
        // Field
        private ArrayList list = new ArrayList();

        // Số phần tử
        public int Count
        {
            get { return list.Count; }
        }

        // Indexer truy cập Point thứ i
        public Point this[int i]
        {
            get { return (Point)list[i]; }
            set { list[i] = value; }
        }

        // Thêm Point
        public void Add(Point p)
        {
            list.Add(p);
        }

        // Method Output
        public void Output()
        {
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine("Point " + i + ": " + list[i]);
        }
    }


    // BÀI 2.2: LỚP PERSONLIST
    class PersonList
    {
        // Field
        private List<Person> list;

        // Default Constructor
        public PersonList()
        {
            list = new List<Person>();
        }

        // Copy Constructor (sao chép sâu từng Person)
        public PersonList(PersonList pl)
        {
            list = new List<Person>();
            foreach (Person p in pl.list)
                list.Add(new Person(p));
        }

        // Method Input
        public void Input()
        {
            Console.Write("Nhap so nguoi: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap nguoi thu " + (i + 1) + ":");
                Person p = new Person();
                p.Input();
                list.Add(p);
            }
        }

        // Method Output
        public void Output()
        {
            foreach (Person p in list)
            {
                p.Output();
                Console.WriteLine();
            }
        }

        // Thêm một Person
        public void Add(Person x)
        {
            list.Add(x);
        }

        // Trả về PersonList những người còn sống
        public PersonList LivingPeople()
        {
            PersonList kq = new PersonList();
            foreach (Person p in list)
            {
                if (p.IsLiving())
                    kq.Add(p);
            }
            return kq;
        }
    }


    // BÀI 2.3: LỚP DÃY SỐ (MẢNG 1 CHIỀU)
    class DaySo
    {
        // Field
        private int[] a;
        private int n;

        // Constructor mặc định
        public DaySo()
        {
            n = 0;
            a = new int[0];
        }

        // Constructor có n phần tử
        public DaySo(int n)
        {
            this.n = n;
            a = new int[n];
        }

        // Constructor từ mảng có sẵn
        public DaySo(int[] arr)
        {
            n = arr.Length;
            a = (int[])arr.Clone();
        }

        // Copy Constructor
        public DaySo(DaySo d)
        {
            n = d.n;
            a = (int[])d.a.Clone();
        }

        // Indexer
        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }

        public int N
        {
            get { return n; }
        }

        // Method Input
        public void Input()
        {
            Console.Write("Nhap so phan tu: ");
            n = int.Parse(Console.ReadLine());
            a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        // Method Output
        public void Output()
        {
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }

        // Tìm các số chẵn
        public DaySo TimSoChan()
        {
            List<int> kq = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                    kq.Add(a[i]);
            }
            return new DaySo(kq.ToArray());
        }
    }


    // BÀI 2.4: LỚP MẢNG 2 CHIỀU
    class Mang2Chieu
    {
        // Field
        private int[,] a;
        private int n;  // số dòng
        private int m;  // số cột

        // Constructor mặc định
        public Mang2Chieu()
        {
            n = 0;
            m = 0;
            a = new int[0, 0];
        }

        // Constructor có kích thước n x m
        public Mang2Chieu(int n, int m)
        {
            this.n = n;
            this.m = m;
            a = new int[n, m];
        }

        // Copy Constructor
        public Mang2Chieu(Mang2Chieu b)
        {
            n = b.n;
            m = b.m;
            a = (int[,])b.a.Clone();
        }

        // Indexer (i, j)
        public int this[int i, int j]
        {
            get { return a[i, j]; }
            set { a[i, j] = value; }
        }

        // Method Input
        public void Input()
        {
            Console.Write("Nhap so dong: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            m = int.Parse(Console.ReadLine());
            a = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("a[" + i + "," + j + "] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        // Method Output
        public void Output()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
        }

        // Kiểm tra số nguyên tố
        private bool LaNguyenTo(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i * i <= x; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }

        // Tìm các số nguyên tố trong mảng
        public List<int> TimSoNguyenTo()
        {
            List<int> kq = new List<int>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (LaNguyenTo(a[i, j]))
                        kq.Add(a[i, j]);
                }
            }
            return kq;
        }
    }


    // BÀI 2.3 (thứ hai): LỚP ĐA THỨC
    class DaThuc
    {
        // Field: hệ số a[i] của x^i, gồm n+1 đơn thức
        private double[] a;
        private int n;

        // Constructor mặc định
        public DaThuc()
        {
            n = 0;
            a = new double[1];
        }

        // Constructor có bậc n
        public DaThuc(int n)
        {
            this.n = n;
            a = new double[n + 1];
        }

        // Constructor từ mảng hệ số
        public DaThuc(double[] heSo)
        {
            n = heSo.Length - 1;
            a = (double[])heSo.Clone();
        }

        // Copy Constructor
        public DaThuc(DaThuc p)
        {
            n = p.n;
            a = (double[])p.a.Clone();
        }

        // Indexer: hệ số đơn thức thứ i
        public double this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }

        // Method Input
        public void Input()
        {
            Console.Write("Nhap bac n: ");
            n = int.Parse(Console.ReadLine());
            a = new double[n + 1];

            for (int i = 0; i <= n; i++)
            {
                Console.Write("He so a" + i + " = ");
                a[i] = double.Parse(Console.ReadLine());
            }
        }

        // Method Output
        public void Output()
        {
            Console.WriteLine("P(x) = " + this);
        }

        // Override ToString
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i <= n; i++)
            {
                if (a[i] == 0) continue;
                if (s != "") s += " + ";

                if (i == 0) s += a[i];
                else if (i == 1) s += a[i] + "x";
                else s += a[i] + "x^" + i;
            }
            return s == "" ? "0" : s;
        }

        // Tính giá trị P(x)
        public double TinhGiaTri(double x)
        {
            double kq = 0;
            for (int i = 0; i <= n; i++)
                kq += a[i] * Math.Pow(x, i);
            return kq;
        }
    }


    // BÀI 2.4 (thứ hai): LỚP DÃY PHÂN SỐ
    class DayPhanSo
    {
        // Field
        private PhanSo[] ds;
        private int n;

        // Constructor mặc định
        public DayPhanSo()
        {
            n = 0;
            ds = new PhanSo[0];
        }

        // Constructor có n phân số
        public DayPhanSo(int n)
        {
            this.n = n;
            ds = new PhanSo[n];
            for (int i = 0; i < n; i++)
                ds[i] = new PhanSo();
        }

        // Indexer
        public PhanSo this[int i]
        {
            get { return ds[i]; }
            set { ds[i] = value; }
        }

        // Method Input
        public void Input()
        {
            Console.Write("Nhap so phan so: ");
            n = int.Parse(Console.ReadLine());
            ds = new PhanSo[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan so thu " + (i + 1) + ":");
                ds[i] = new PhanSo();
                ds[i].Input();
            }
        }

        // Method Output
        public void Output()
        {
            for (int i = 0; i < n; i++)
                Console.Write(ds[i] + "  ");
            Console.WriteLine();
        }

        // Tính tổng n phân số
        public PhanSo Tong()
        {
            PhanSo tong = new PhanSo(0, 1);
            for (int i = 0; i < n; i++)
                tong = tong + ds[i];
            return tong;
        }
    }


    // BÀI 2.5: TÍNH LƯƠNG NHÂN VIÊN
    class NhanVien
    {
        // Field
        private string hoTen;
        private double luong;
        private int ngayVang;

        // Constructor mặc định
        public NhanVien()
        {
            hoTen = "";
            luong = 0;
            ngayVang = 0;
        }

        // Constructor có tham số
        public NhanVien(string hoTen, double luong, int ngayVang)
        {
            this.hoTen = hoTen;
            this.luong = luong;
            this.ngayVang = ngayVang;
        }

        // Property
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public double Luong
        {
            get { return luong; }
            set { luong = value; }
        }

        public int NgayVang
        {
            get { return ngayVang; }
            set { ngayVang = value; }
        }

        // Method Input
        public void Input()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap muc luong: ");
            luong = double.Parse(Console.ReadLine());

            Console.Write("Nhap so ngay vang: ");
            ngayVang = int.Parse(Console.ReadLine());
        }

        // Lương thực nhận (mỗi ngày vắng trừ 100.000)
        public double LuongThucNhan()
        {
            return luong - ngayVang * 100000;
        }
    }

    class PhongBan
    {
        // Field
        private List<NhanVien> ds = new List<NhanVien>();

        // Method Input
        public void Input()
        {
            Console.Write("Nhap so nhan vien: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap nhan vien thu " + (i + 1) + ":");
                NhanVien nv = new NhanVien();
                nv.Input();
                ds.Add(nv);
            }
        }

        // Tổng lương phòng ban
        public double TongLuong()
        {
            double tong = 0;
            foreach (NhanVien nv in ds)
                tong += nv.LuongThucNhan();
            return tong;
        }
    }

    // BÀI 3.1: LỚP HỌC SINH - IMPLEMENT IComparable ĐỂ DÙNG Array.Sort
    class HocSinh : IComparable
    {
        // Field
        private string ten;
        private double diem;

        // Constructor
        public HocSinh(string ten, double diem)
        {
            this.ten = ten;
            this.diem = diem;
        }

        // Property
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public double Diem
        {
            get { return diem; }
            set { diem = value; }
        }

        // So sánh theo điểm tăng dần
        public int CompareTo(object obj)
        {
            HocSinh h = (HocSinh)obj;
            return diem.CompareTo(h.diem);
        }

        // Override ToString
        public override string ToString()
        {
            return ten + " - " + diem;
        }
    }


    // BÀI 3.2 + 3.3: SẮP XẾP TỔNG QUÁT
    // Delegate so sánh 2 phần tử (dùng cho bài 3.3)
    delegate int SoSanh<T>(T a, T b);

    static class SapXep
    {
        // Bài 3.2: sắp xếp bằng interface IComparable
        public static void Sort(IComparable[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (a[j].CompareTo(a[j + 1]) > 0)
                    {
                        IComparable temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }

        // Bài 3.3: sắp xếp bằng delegate so sánh
        public static void Sort<T>(T[] a, SoSanh<T> cmp)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (cmp(a[j], a[j + 1]) > 0)
                    {
                        T temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
    }


    // BÀI 3.4: LỚP CONSOLEMENU TỔNG QUÁT
    // Delegate cho sự kiện chọn chức năng
    delegate void ChonHandler(int chon);

    class ConsoleMenu
    {
        // Field
        protected List<string> items = new List<string>();

        // Event: xảy ra khi người dùng chọn chức năng
        public event ChonHandler Choose;

        // Thêm một chức năng vào menu
        public void AddItem(string ten)
        {
            items.Add(ten);
        }

        // Hiển thị menu
        protected virtual void HienMenu()
        {
            Console.WriteLine("\nMenu");
            for (int i = 0; i < items.Count; i++)
                Console.WriteLine((i + 1) + ". " + items[i]);
            Console.WriteLine("0. Thoat chuong trinh");
        }

        // Kích hoạt event rồi gọi ThucHien
        protected virtual void OnChoose(int chon)
        {
            if (Choose != null)
                Choose(chon);

            ThucHien(chon);
        }

        // Thực hiện chức năng (lớp con override)
        protected virtual void ThucHien(int chon)
        {
            Console.WriteLine("Ban thuc hien chuc nang " + chon);
        }

        // Vòng lặp menu
        public void Run()
        {
            while (true)
            {
                HienMenu();
                Console.Write("Thuc hien: ");
                int chon = int.Parse(Console.ReadLine());

                if (chon == 0)
                    break;

                if (chon < 1 || chon > items.Count)
                {
                    Console.WriteLine("Lua chon khong hop le!");
                    continue;
                }

                OnChoose(chon);
            }
        }
    }

    // Áp dụng: giải phương trình bậc 2 (kế thừa ConsoleMenu)
    class PTBac2Console : ConsoleMenu
    {
        // Field
        private double a, b, c;

        // Constructor: thêm các chức năng
        public PTBac2Console()
        {
            AddItem("Nhap he so a, b, c");
            AddItem("Giai phuong trinh bac 2");
        }

        // Override thực hiện chức năng
        protected override void ThucHien(int chon)
        {
            switch (chon)
            {
                case 1:
                    Console.Write("Nhap a: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Nhap b: ");
                    b = double.Parse(Console.ReadLine());
                    Console.Write("Nhap c: ");
                    c = double.Parse(Console.ReadLine());
                    break;

                case 2:
                    Giai();
                    break;
            }
        }

        // Giải phương trình ax^2 + bx + c = 0
        private void Giai()
        {
            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine(c == 0 ? "Vo so nghiem" : "Vo nghiem");
                else
                    Console.WriteLine("Phuong trinh bac 1, x = " + (-c / b));
                return;
            }

            double delta = b * b - 4 * a * c;

            if (delta < 0)
                Console.WriteLine("Vo nghiem");
            else if (delta == 0)
                Console.WriteLine("Nghiem kep x = " + (-b / (2 * a)));
            else
            {
                Console.WriteLine("x1 = " + ((-b + Math.Sqrt(delta)) / (2 * a)));
                Console.WriteLine("x2 = " + ((-b - Math.Sqrt(delta)) / (2 * a)));
            }
        }
    }


    // BÀI 3.5: TÍNH LƯƠNG NHÂN VIÊN
    // Lớp cơ sở trừu tượng
    abstract class NhanVienCongTy
    {
        // Field
        protected string maNV;
        protected string hoTen;

        // Property
        public string MaNV
        {
            get { return maNV; }
        }

        public string HoTen
        {
            get { return hoTen; }
        }

        // Method Input
        public virtual void Input()
        {
            Console.Write("Nhap ma nhan vien: ");
            maNV = Console.ReadLine();

            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();
        }

        // Tính lương (mỗi lớp con tự tính)
        public abstract double TinhLuong();

        // Method Output
        public virtual void Output()
        {
            Console.WriteLine("Ma NV: " + maNV + " | Ho ten: " + hoTen + " | Luong: " + TinhLuong());
        }
    }

    // Nhân viên kinh doanh
    class NhanVienKinhDoanh : NhanVienCongTy
    {
        // Field
        private double luongCoBan;
        private int soHopDong;

        public override void Input()
        {
            base.Input();

            Console.Write("Nhap luong co ban: ");
            luongCoBan = double.Parse(Console.ReadLine());

            Console.Write("Nhap so hop dong: ");
            soHopDong = int.Parse(Console.ReadLine());
        }

        // Lương = lương cơ bản + 500.000 / hợp đồng
        public override double TinhLuong()
        {
            return luongCoBan + soHopDong * 500000;
        }
    }

    // Nhân viên sản xuất
    class NhanVienSanXuat : NhanVienCongTy
    {
        // Field
        private int soSanPham;

        public override void Input()
        {
            base.Input();

            Console.Write("Nhap so san pham: ");
            soSanPham = int.Parse(Console.ReadLine());
        }

        // Lương = số SP x 1000, trên 3000 SP thưởng 5%
        public override double TinhLuong()
        {
            double luong = soSanPham * 1000;

            if (soSanPham > 3000)
                luong *= 1.05;

            return luong;
        }
    }

    class CongTy
    {
        // Field
        private List<NhanVienCongTy> ds = new List<NhanVienCongTy>();

        // Method Input
        public void Input()
        {
            Console.Write("Nhap so nhan vien: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhan vien thu " + (i + 1) + " (1: Kinh doanh, 2: San xuat): ");
                int loai = int.Parse(Console.ReadLine());

                NhanVienCongTy nv;
                if (loai == 1)
                    nv = new NhanVienKinhDoanh();
                else
                    nv = new NhanVienSanXuat();

                nv.Input();
                ds.Add(nv);
            }
        }

        // Xuất lương từng nhân viên (đa hình)
        public void Output()
        {
            foreach (NhanVienCongTy nv in ds)
                nv.Output();
        }
    }


    // BÀI 3.6: TÍNH ĐIỂM THÍ SINH
    // Lớp cơ sở trừu tượng
    abstract class ThiSinh
    {
        // Field
        protected string sbd;
        protected string hoTen;
        protected double bai1, bai2, bai3;
        protected double tongDiem;

        // Property
        public double TongDiem
        {
            get { return tongDiem; }
        }

        // Method Input
        public virtual void Input()
        {
            Console.Write("Nhap SBD: ");
            sbd = Console.ReadLine();

            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap diem bai 1: ");
            bai1 = double.Parse(Console.ReadLine());

            Console.Write("Nhap diem bai 2: ");
            bai2 = double.Parse(Console.ReadLine());

            Console.Write("Nhap diem bai 3: ");
            bai3 = double.Parse(Console.ReadLine());
        }

        // Tính tổng điểm (mỗi lớp con tự tính)
        public abstract void TinhTongDiem();

        // Method Output
        public void Output()
        {
            Console.WriteLine("SBD: " + sbd + " | Ho ten: " + hoTen + " | Tong diem: " + tongDiem);
        }
    }

    // Thí sinh Chuyên
    class ThiSinhChuyen : ThiSinh
    {
        // Field
        private double tiengAnh;

        public override void Input()
        {
            base.Input();

            Console.Write("Nhap diem tieng Anh: ");
            tiengAnh = double.Parse(Console.ReadLine());
        }

        // Tổng 3 bài + điểm thưởng tiếng Anh
        public override void TinhTongDiem()
        {
            tongDiem = bai1 + bai2 + bai3;

            if (tiengAnh >= 9 && tiengAnh <= 10)
                tongDiem += 2;
            else if (tiengAnh >= 7 && tiengAnh <= 8)
                tongDiem += 1;
        }
    }

    // Thí sinh Siêu cúp
    class ThiSinhSieuCup : ThiSinh
    {
        // Field
        private double csdl;

        public override void Input()
        {
            base.Input();

            Console.Write("Nhap diem CSDL: ");
            csdl = double.Parse(Console.ReadLine());
        }

        // Tổng 4 bài thi
        public override void TinhTongDiem()
        {
            tongDiem = bai1 + bai2 + bai3 + csdl;
        }
    }

    class CuocThi
    {
        // Field: danh sách thí sinh
        private List<ThiSinh> ds = new List<ThiSinh>();

        // Method Input
        public void Input()
        {
            Console.Write("Nhap so thi sinh: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Thi sinh thu " + (i + 1) + " (1: Chuyen, 2: Sieu cup): ");
                int loai = int.Parse(Console.ReadLine());

                ThiSinh ts;
                if (loai == 1)
                    ts = new ThiSinhChuyen();
                else
                    ts = new ThiSinhSieuCup();

                ts.Input();
                ts.TinhTongDiem();
                ds.Add(ts);
            }
        }

        // Xuất tổng điểm từng thí sinh
        public void Output()
        {
            foreach (ThiSinh ts in ds)
                ts.Output();
        }
    }

    // ============================================================
    // PROGRAM
    internal class Program
    {
        static void Main(string[] args)
        {
            // BÀI 1.1
            Console.WriteLine("---------- BAI 1.1 ----------");

            Console.Write("Nhap ho ten: ");
            string hoTen = Console.ReadLine();

            Console.Write("Nhap nam sinh: ");
            int namSinh = int.Parse(Console.ReadLine());

            SinhVien sv = new SinhVien(hoTen, namSinh);

            Console.WriteLine("Ho ten: " + sv.HoTen);
            Console.WriteLine("Nam sinh: " + sv.NamSinh);
            Console.WriteLine("Tuoi: " + sv.TinhTuoi());


            // BÀI 1.2
            Console.WriteLine("\n---------- BAI 1.2 ----------");

            Point A = new Point();
            Point B = new Point();

            Console.WriteLine("Nhap diem A:");
            A.Input();

            Console.WriteLine("Nhap diem B:");
            B.Input();

            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);

            // Khoảng cách - phương thức thành viên
            Console.WriteLine("Khoang cach (thanh vien): " + A.KhoangCach(B));

            // Khoảng cách - phương thức tĩnh
            Console.WriteLine("Khoang cach (tinh): " + Point.KhoangCach(A, B));

            // Trung điểm - phương thức thành viên
            Point I1 = A.TrungDiem(B);
            Console.WriteLine("Trung diem (thanh vien): " + I1);

            // Trung điểm - phương thức tĩnh
            Point I2 = Point.TrungDiem(A, B);
            Console.WriteLine("Trung diem (tinh): " + I2);

            // Các phép toán
            Console.WriteLine("A + B = " + (A + B));
            Console.WriteLine("A - B = " + (A - B));
            Console.WriteLine("-A = " + (-A));


            // BÀI 1.3
            Console.WriteLine("\n---------- BAI 1.3 ----------");

            Person p = new Person();

            p.Input();

            Console.WriteLine("\nThong tin Person:");
            p.Output();

            if (p.IsLiving())
                Console.WriteLine("Trang thai: Con song");
            else
                Console.WriteLine("Trang thai: Da mat");

            // Copy Constructor
            Person p2 = new Person(p);

            Console.WriteLine("\nPerson sau khi copy:");
            p2.Output();


            // BÀI 1.4
            Console.WriteLine("\n---------- BAI 1.4 ----------");

            PhanSo ps1 = new PhanSo(1, 2);
            PhanSo ps2 = new PhanSo(2, 3);

            Console.WriteLine("Nhap phan so 1:");
            ps1.Input();

            Console.WriteLine("Nhap phan so 2:");
            ps2.Input();

            Console.WriteLine("Phan so 1: " + ps1);
            Console.WriteLine("Phan so 2: " + ps2);

            Console.WriteLine("PS1 + PS2 = " + (ps1 + ps2));
            Console.WriteLine("PS1 - PS2 = " + (ps1 - ps2));
            Console.WriteLine("PS1 * PS2 = " + (ps1 * ps2));
            Console.WriteLine("PS1 / PS2 = " + (ps1 / ps2));

            Console.WriteLine("+PS1 = " + (+ps1));
            Console.WriteLine("-PS1 = " + (-ps1));

            Console.WriteLine("PS1 > PS2: " + (ps1 > ps2));
            Console.WriteLine("PS1 < PS2: " + (ps1 < ps2));
            Console.WriteLine("PS1 >= PS2: " + (ps1 >= ps2));
            Console.WriteLine("PS1 <= PS2: " + (ps1 <= ps2));
            Console.WriteLine("PS1 == PS2: " + (ps1 == ps2));
            Console.WriteLine("PS1 != PS2: " + (ps1 != ps2));


            // BÀI 1.5
            Console.WriteLine("\n---------- BAI 1.5 ---------");

            DonThuc P = new DonThuc(3, 4);

            Console.WriteLine("Don thuc P(x) = " + P);

            Console.Write("Nhap x: ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("P(" + x + ") = " + P.TinhGiaTri(x));

            DonThuc Q = P.DaoHam();

            Console.WriteLine("Dao ham Q(x) = " + Q);

            // BÀI 2.1
            Console.WriteLine("\n---------- BAI 2.1 ----------");

            ArrayPoint ap = new ArrayPoint();
            ap.Add(new Point(1, 2));
            ap.Add(new Point(3, 4));
            ap.Add(new Point(5, 6));

            Console.WriteLine("Point thu 1: " + ap[1]);
            ap[1] = new Point(9, 9);   // gán qua indexer
            ap.Output();


            // BÀI 2.2
            Console.WriteLine("\n---------- BAI 2.2 ----------");

            PersonList pl = new PersonList();
            pl.Input();

            Console.WriteLine("\nDanh sach nguoi:");
            pl.Output();

            PersonList pl2 = new PersonList(pl);   // Copy Constructor

            Console.WriteLine("Danh sach nguoi con song:");
            pl2.LivingPeople().Output();


            // BÀI 2.3 - DÃY SỐ
            Console.WriteLine("\n---------- BAI 2.3 (Day so) ----------");

            DaySo ds = new DaySo();
            ds.Input();

            Console.Write("Day so: ");
            ds.Output();

            Console.WriteLine("Phan tu dau tien: " + ds[0]);

            Console.Write("Cac so chan: ");
            ds.TimSoChan().Output();


            // BÀI 2.4 - MẢNG 2 CHIỀU
            Console.WriteLine("\n---------- BAI 2.4 (Mang 2 chieu) ----------");

            Mang2Chieu mt = new Mang2Chieu();
            mt.Input();

            Console.WriteLine("Mang:");
            mt.Output();

            Console.WriteLine("Phan tu (0,0): " + mt[0, 0]);

            Console.Write("Cac so nguyen to: ");
            foreach (int sn in mt.TimSoNguyenTo())
                Console.Write(sn + " ");
            Console.WriteLine();


            // BÀI 2.3 - ĐA THỨC
            Console.WriteLine("\n---------- BAI 2.3 (Da thuc) ----------");

            DaThuc dt = new DaThuc();
            dt.Input();
            dt.Output();

            Console.Write("Nhap x: ");
            double xDT = double.Parse(Console.ReadLine());
            Console.WriteLine("P(" + xDT + ") = " + dt.TinhGiaTri(xDT));


            // BÀI 2.4 - DÃY PHÂN SỐ
            Console.WriteLine("\n---------- BAI 2.4 (Day phan so) ----------");

            DayPhanSo dps = new DayPhanSo();
            dps.Input();

            Console.Write("Day phan so: ");
            dps.Output();

            Console.WriteLine("Tong = " + dps.Tong());


            // BÀI 2.5
            Console.WriteLine("\n---------- BAI 2.5 ----------");

            PhongBan pb = new PhongBan();
            pb.Input();

            Console.WriteLine("Tong luong phong ban: " + pb.TongLuong() + " VND");

            // BÀI 3.1
            Console.WriteLine("\n---------- BAI 3.1 ----------");

            HocSinh[] hs = new HocSinh[]
            {
                new HocSinh("An", 8),
                new HocSinh("Binh", 5),
                new HocSinh("Cuong", 9),
                new HocSinh("Dung", 6.5)
            };

            Array.Sort(hs);   // dùng IComparable của HocSinh

            foreach (HocSinh h in hs)
                Console.WriteLine(h);


            // BÀI 3.2
            Console.WriteLine("\n---------- BAI 3.2 ----------");

            HocSinh[] hs2 = new HocSinh[]
            {
                new HocSinh("Em", 7),
                new HocSinh("Phuc", 4),
                new HocSinh("Giang", 10)
            };

            SapXep.Sort(hs2);   // sắp xếp bằng interface

            foreach (HocSinh h in hs2)
                Console.WriteLine(h);

            string[] chuoi = { "cam", "tao", "buoi", "xoai" };
            SapXep.Sort(chuoi);
            Console.WriteLine(string.Join(", ", chuoi));


            // BÀI 3.3
            Console.WriteLine("\n---------- BAI 3.3 ----------");

            int[] so = { 5, 2, 9, 1, 7 };

            // Tăng dần
            SapXep.Sort(so, (a, b) => a.CompareTo(b));
            Console.WriteLine("Tang dan: " + string.Join(" ", so));

            // Giảm dần
            SapXep.Sort(so, (a, b) => b.CompareTo(a));
            Console.WriteLine("Giam dan: " + string.Join(" ", so));

            // Sắp xếp HocSinh theo tên
            SapXep.Sort(hs2, (a, b) => a.Ten.CompareTo(b.Ten));
            Console.WriteLine("Theo ten:");
            foreach (HocSinh h in hs2)
                Console.WriteLine(h);


            // BÀI 3.4
            Console.WriteLine("\n---------- BAI 3.4 ----------");

            // Cách 1: menu mặc định + gắn sự kiện Choose
            ConsoleMenu menu = new ConsoleMenu();
            menu.AddItem("Chuc nang 1");
            menu.AddItem("Chuc nang 2");
            menu.Choose += (chon) => Console.WriteLine("[Su kien] Da chon chuc nang " + chon);
            menu.Run();

            // Cách 2: kế thừa (PTBac2Console) + gắn thêm sự kiện
            PTBac2Console app = new PTBac2Console();
            app.Choose += (chon) => Console.WriteLine("[Su kien] Da chon chuc nang " + chon);
            app.Run();


            // BÀI 3.5
            Console.WriteLine("\n---------- BAI 3.5 ----------");

            CongTy ct = new CongTy();
            ct.Input();

            Console.WriteLine("\nLuong nhan vien:");
            ct.Output();


            // BÀI 3.6
            Console.WriteLine("\n---------- BAI 3.6 ----------");

            CuocThi cuocThi = new CuocThi();
            cuocThi.Input();

            Console.WriteLine("\nKet qua cuoc thi:");
            cuocThi.Output();

            Console.ReadLine();
        }
    }
}