using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai12
{
    class SinhVien
    {
        string maSinhVien;
        string hoTen;
        string diaChi;
        int namThu;

        public void Nhap()
        {
            Console.Write("Nhap ma sinh vien: ");
            maSinhVien = Console.ReadLine();

            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap dia chi: ");
            diaChi = Console.ReadLine();

            Console.Write("Nhap sinh vien nam thu may: ");
            namThu = Convert.ToInt32(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Ma sinh vien: " + maSinhVien);
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Dia chi: " + diaChi);
            Console.WriteLine("Sinh vien nam thu: " + namThu);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();

            sv.Nhap();

            Console.WriteLine("\n--- THONG TIN SINH VIEN ---");
            sv.Xuat();

            Console.ReadLine();
        }
    }
}