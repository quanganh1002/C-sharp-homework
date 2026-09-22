using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai13
{
    class NhanVien
    {
        string hoTen;
        double mucLuong;
        int soNgayVang;

        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap muc luong: ");
            mucLuong = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap so ngay vang: ");
            soNgayVang = Convert.ToInt32(Console.ReadLine());
        }

        public double TinhLuong()
        {
            return mucLuong - soNgayVang * 100000;
        }

        public void Xuat()
        {
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Muc luong: " + mucLuong);
            Console.WriteLine("So ngay vang: " + soNgayVang);
            Console.WriteLine("Luong thuc nhan: " + TinhLuong() + " VNĐ");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            NhanVien nv = new NhanVien();

            nv.Nhap();

            Console.WriteLine("\n--- THONG TIN NHAN VIEN ---");
            nv.Xuat();

            Console.ReadLine();
        }
    }
}