using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiThucHanhLINQ;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("===== BÀI 2.1 =====");
        Bai21_a(); Bai21_b(); Bai21_c();

        Console.WriteLine("\n===== BÀI 2.2 =====");
        Bai22_a(); Bai22_b(); Bai22_c(); Bai22_d();

        Console.WriteLine("\n===== BÀI 3.1 =====");
        Bai31_a(); Bai31_b(); Bai31_c(); Bai31_d();

        Console.WriteLine("\n===== BÀI 3.2 =====");
        Bai32_a(); Bai32_b(); Bai32_c();

        Console.WriteLine("\n===== BÀI 4.1 =====");
        Bai41();

        Console.WriteLine("\n===== BÀI 5.1 =====");
        Bai51_a(); Bai51_b(); Bai51_c(); Bai51_d();

        Console.WriteLine("\n===== BÀI 5.2 =====");
        Bai52_a(); Bai52_b(); Bai52_c(); Bai52_d(); Bai52_e(); Bai52_f();
        Bai52_g(); Bai52_h(); Bai52_i(); Bai52_j(); Bai52_k();
        
        Console.WriteLine("\n===== BÀI 6.2 =====");
        Bai62_a(); Bai62_b(); Bai62_c(); Bai62_d(); Bai62_e();
        Bai62_f(); Bai62_g(); Bai62_h(); Bai62_i();
    }

    // DỮ LIỆU
    static readonly int[] mangSo2 = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };
    static readonly int[] mangSo3 = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };
    static readonly List<MonHoc> dsMon = DuLieu.DS_Mon();
    static readonly List<He> dsHe = DuLieu.DS_He();

    static readonly string[] mangChuoi =
    {
        "đầu", "lòng", "hai", "ả", "tố", "nga",
        "Thúy", "Kiều", "là", "chị", "em", "là", "Thúy", "Vân"
    };

    static readonly string[] monAn =
    {
        "Bún bò Huế", "Hủ tiếu heo", "Bánh canh", "Bánh mì",
        "Nước Cà phê", "Mì quảng", "Cơm tấm", "Nước Chanh dây", "Mì xào",
        "Bún riêu", "Bánh cuốn", "Mì gói", "Bún chả", "Hủ tiếu Nam vang"
    };

    // HÀM IN
    static void In<T>(string tieuDe, IEnumerable<T> ds)
        => Console.WriteLine($"  {tieuDe}: {string.Join(", ", ds)}");

    // TỪ ĐẦU TIÊN CỦA CHUỖI
    static string TuDau(string s) => s.Split(' ')[0];

    // BÀI 2.1
    static void Bai21_a()
    {
        Console.WriteLine("\na. Chia hết cho 4 và 3:");
        var qs = from n in mangSo2 where n % 4 == 0 && n % 3 == 0 select n;
        var ms = mangSo2.Where(n => n % 4 == 0 && n % 3 == 0);
        In("Query Syntax ", qs);
        In("Method Syntax", ms);
    }

    static void Bai21_b()
    {
        Console.WriteLine("\nb. Nhỏ hơn hoặc bằng 3:");
        var qs = from n in mangSo2 where n <= 3 select n;
        var ms = mangSo2.Where(n => n <= 3);
        In("Query Syntax ", qs);
        In("Method Syntax", ms);
    }

    static void Bai21_c()
    {
        Console.WriteLine("\nc. Chẵn chia đôi, lẻ giữ nguyên:");
        var qs = from n in mangSo2 select n % 2 == 0 ? n / 2 : n;
        var ms = mangSo2.Select(n => n % 2 == 0 ? n / 2 : n);
        In("Query Syntax ", qs);
        In("Method Syntax", ms);
    }

    // BÀI 2.2
    static void Bai22_a()
    {
        Console.WriteLine("\na. Có 4 ký tự, sắp xếp theo ký tự đầu:");
        var qs = from s in mangChuoi where s.Length == 4 orderby s[0] select s;
        var ms = mangChuoi.Where(s => s.Length == 4).OrderBy(s => s[0]);
        In("Query Syntax ", qs);
        In("Method Syntax", ms);
    }

    static void Bai22_b()
    {
        Console.WriteLine("\nb. Dạng <chữ thường> - <CHỮ HOA>:");
        var qs = from s in mangChuoi select $"{s.ToLower()} - {s.ToUpper()}";
        var ms = mangChuoi.Select(s => $"{s.ToLower()} - {s.ToUpper()}");
        In("Query Syntax ", qs);
        In("Method Syntax", ms);
    }

    static void Bai22_c()
    {
        Console.WriteLine("\nc. Chứa ký tự 'u':");
        var qs = from s in mangChuoi where s.Contains('u') select s;
        var ms = mangChuoi.Where(s => s.Contains('u'));
        In("Query Syntax ", qs);
        In("Method Syntax", ms);
    }

    static void Bai22_d()
    {
        Console.WriteLine("\nd. Bắt đầu bằng chữ in hoa:");
        var qs = from s in mangChuoi where char.IsUpper(s[0]) select s;
        var ms = mangChuoi.Where(s => char.IsUpper(s[0]));
        Console.WriteLine($"  Query Syntax : {string.Join(" ", qs)}");
        Console.WriteLine($"  Method Syntax: {string.Join(" ", ms)}");
    }

    // BÀI 3.1
    static void Bai31_a()
    {
        Console.WriteLine("\na. Tổng số phần tử, số chẵn, số lẻ:");

        int tongQs = (from n in mangSo3 select n).Count();
        int chanQs = (from n in mangSo3 where n % 2 == 0 select n).Count();
        int leQs = (from n in mangSo3 where n % 2 != 0 select n).Count();

        int tongMs = mangSo3.Count();
        int chanMs = mangSo3.Count(n => n % 2 == 0);
        int leMs = mangSo3.Count(n => n % 2 != 0);

        Console.WriteLine($"  Query Syntax : tổng = {tongQs}, chẵn = {chanQs}, lẻ = {leQs}");
        Console.WriteLine($"  Method Syntax: tổng = {tongMs}, chẵn = {chanMs}, lẻ = {leMs}");
    }

    static void Bai31_b()
    {
        Console.WriteLine("\nb. Tổng, lớn nhất, nhỏ nhất:");

        int tongQs = (from n in mangSo3 select n).Sum();
        int maxQs = (from n in mangSo3 select n).Max();
        int minQs = (from n in mangSo3 select n).Min();

        Console.WriteLine($"  Query Syntax : tổng = {tongQs}, max = {maxQs}, min = {minQs}");
        Console.WriteLine($"  Method Syntax: tổng = {mangSo3.Sum()}, max = {mangSo3.Max()}, min = {mangSo3.Min()}");
    }

    static void Bai31_c()
    {
        Console.WriteLine("\nc. Số giá trị khác nhau:");

        int qs = (from n in mangSo3 select n).Distinct().Count();
        int ms = mangSo3.Distinct().Count();

        Console.WriteLine($"  Query Syntax : {qs}");
        Console.WriteLine($"  Method Syntax: {ms}");
    }

    static void Bai31_d()
    {
        Console.WriteLine("\nd. Phân nhóm theo số dư khi chia cho 5:");

        var qs = from n in mangSo3
                 group n by n % 5 into g
                 orderby g.Key
                 select g;

        var ms = mangSo3.GroupBy(n => n % 5).OrderBy(g => g.Key);

        Console.WriteLine("  Query Syntax:");
        foreach (var g in qs)
            Console.WriteLine($"    Dư {g.Key}: {string.Join(", ", g)}");

        Console.WriteLine("  Method Syntax:");
        foreach (var g in ms)
            Console.WriteLine($"    Dư {g.Key}: {string.Join(", ", g)}");
    }

    // BÀI 3.2
    static void Bai32_a()
    {
        Console.WriteLine("\na. Ngắn nhất và dài nhất:");

        // Query Syntax
        int minQs = (from s in monAn select s.Length).Min();
        int maxQs = (from s in monAn select s.Length).Max();
        var ngan = from s in monAn where s.Length == minQs select s;
        var dai = from s in monAn where s.Length == maxQs select s;

        Console.WriteLine($"  Query Syntax : ngắn nhất ({minQs} ký tự): {string.Join(", ", ngan)}");
        Console.WriteLine($"                 dài nhất  ({maxQs} ký tự): {string.Join(", ", dai)}");

        // Method Syntax
        int minMs = monAn.Min(s => s.Length);
        int maxMs = monAn.Max(s => s.Length);

        Console.WriteLine($"  Method Syntax: ngắn nhất ({minMs} ký tự): {string.Join(", ", monAn.Where(s => s.Length == minMs))}");
        Console.WriteLine($"                 dài nhất  ({maxMs} ký tự): {string.Join(", ", monAn.Where(s => s.Length == maxMs))}");
    }

    static void Bai32_b()
    {
        Console.WriteLine("\nb. Phân nhóm theo từ đầu tiên:");

        var qs = from s in monAn
                 group s by TuDau(s) into g
                 select g;

        var ms = monAn.GroupBy(s => TuDau(s));

        Console.WriteLine("  Query Syntax:");
        foreach (var g in qs)
            Console.WriteLine($"    {g.Key}: {string.Join(" | ", g)}");

        Console.WriteLine("  Method Syntax:");
        foreach (var g in ms)
            Console.WriteLine($"    {g.Key}: {string.Join(" | ", g)}");
    }

    static void Bai32_c()
    {
        Console.WriteLine("\nc. Số món có từ đầu tiên là \"Bánh\":");

        int qs = (from s in monAn where TuDau(s) == "Bánh" select s).Count();
        int ms = monAn.Count(s => TuDau(s) == "Bánh");

        Console.WriteLine($"  Query Syntax : {qs}");
        Console.WriteLine($"  Method Syntax: {ms}");
    }

    // BÀI 4.1 - IN THỬ DỮ LIỆU
    static void Bai41()
    {
        var ds = DuLieu.DS_Mon();
        Console.WriteLine($"  Tổng số môn: {ds.Count}");
        foreach (var m in ds)
            Console.WriteLine($"  {m.MaMon,-6} | {m.TenMon,-42} | {m.He,-3} | {m.SoTiet}");
    }

        // HÀM IN BÀI 5
    static string TenHe(string he) => he == "" ? "(không có)" : he;

    static void InMon(string nhan, IEnumerable<MonHoc> ds)
    {
        Console.WriteLine($"  {nhan}:");
        foreach (var m in ds)
            Console.WriteLine($"    {m.MaMon,-6} | {m.TenMon,-42} | {TenHe(m.He),-10} | {m.SoTiet}");
    }

    static void InNhom<TKey>(string nhan, IEnumerable<IGrouping<TKey, MonHoc>> nhom)
    {
        Console.WriteLine($"  {nhan}:");
        foreach (var g in nhom)
        {
            string key = g.Key is string s ? TenHe(s) : g.Key?.ToString() ?? "";
            Console.WriteLine($"    [{key}]");
            foreach (var m in g)
                Console.WriteLine($"      {m.MaMon,-6} | {m.TenMon,-42} | {TenHe(m.He),-10} | {m.SoTiet}");
        }
    }

    // BÀI 5.1
    static void Bai51_a()
    {
        Console.WriteLine("\na. Tên môn bắt đầu bằng \"Lập trình\":");
        var qs = from m in dsMon
                 where m.TenMon.StartsWith("Lập trình", StringComparison.OrdinalIgnoreCase)
                 select m.TenMon;
        var ms = dsMon.Where(m => m.TenMon.StartsWith("Lập trình", StringComparison.OrdinalIgnoreCase))
                      .Select(m => m.TenMon);
        Console.WriteLine("  Query Syntax:");
        foreach (var t in qs) Console.WriteLine($"    {t}");
        Console.WriteLine("  Method Syntax:");
        foreach (var t in ms) Console.WriteLine($"    {t}");
    }

    static void Bai51_b()
    {
        Console.WriteLine("\nb. Hệ CD, số tiết giảm dần, mã môn tăng dần:");
        var qs = from m in dsMon
                 where m.He == "CD"
                 orderby m.SoTiet descending, m.MaMon
                 select m;
        var ms = dsMon.Where(m => m.He == "CD")
                      .OrderByDescending(m => m.SoTiet)
                      .ThenBy(m => m.MaMon);
        InMon("Query Syntax", qs);
        InMon("Method Syntax", ms);
    }

    static void Bai51_c()
    {
        Console.WriteLine("\nc. Tên môn chứa \"web\" (Tên môn, Hệ):");
        var qs = from m in dsMon
                 where m.TenMon.Contains("web", StringComparison.OrdinalIgnoreCase)
                 select new { m.TenMon, m.He };
        var ms = dsMon.Where(m => m.TenMon.Contains("web", StringComparison.OrdinalIgnoreCase))
                      .Select(m => new { m.TenMon, m.He });
        Console.WriteLine("  Query Syntax:");
        foreach (var x in qs) Console.WriteLine($"    {x.TenMon} | {x.He}");
        Console.WriteLine("  Method Syntax:");
        foreach (var x in ms) Console.WriteLine($"    {x.TenMon} | {x.He}");
    }

    static void Bai51_d()
    {
        Console.WriteLine("\nd. Hệ KTV, mã môn tăng dần:");
        var qs = from m in dsMon where m.He == "KTV" orderby m.MaMon select m;
        var ms = dsMon.Where(m => m.He == "KTV").OrderBy(m => m.MaMon);
        InMon("Query Syntax", qs);
        InMon("Method Syntax", ms);
    }

    // BÀI 5.2
    static void Bai52_a()
    {
        Console.WriteLine("\na. Tổng số môn:");
        int qs = (from m in dsMon select m).Count();
        int ms = dsMon.Count();
        Console.WriteLine($"  Query Syntax : {qs}");
        Console.WriteLine($"  Method Syntax: {ms}");
    }

    static void Bai52_b()
    {
        Console.WriteLine("\nb. Số môn bắt đầu bằng \"Lập trình\":");
        int qs = (from m in dsMon
                  where m.TenMon.StartsWith("Lập trình", StringComparison.OrdinalIgnoreCase)
                  select m).Count();
        int ms = dsMon.Count(m => m.TenMon.StartsWith("Lập trình", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine($"  Query Syntax : {qs}");
        Console.WriteLine($"  Method Syntax: {ms}");
    }

    static void Bai52_c()
    {
        Console.WriteLine("\nc. Tổng số tiết hệ KTV:");
        int qs = (from m in dsMon where m.He == "KTV" select (int)m.SoTiet).Sum();
        int ms = dsMon.Where(m => m.He == "KTV").Sum(m => m.SoTiet);
        Console.WriteLine($"  Query Syntax : {qs}");
        Console.WriteLine($"  Method Syntax: {ms}");
    }

    static void Bai52_d()
    {
        Console.WriteLine("\nd. Tổng số môn của mỗi hệ:");
        var qs = from m in dsMon
                 group m by m.He into g
                 select new { He = g.Key, Tong = g.Count() };
        var ms = dsMon.GroupBy(m => m.He)
                      .Select(g => new { He = g.Key, Tong = g.Count() });
        Console.WriteLine("  Query Syntax:");
        foreach (var x in qs) Console.WriteLine($"    Hệ {TenHe(x.He)}: {x.Tong} môn");
        Console.WriteLine("  Method Syntax:");
        foreach (var x in ms) Console.WriteLine($"    Hệ {TenHe(x.He)}: {x.Tong} môn");
    }

    static void Bai52_e()
    {
        Console.WriteLine("\ne. Nhóm theo số tiết, giảm dần:");
        var qs = from m in dsMon
                 group m by m.SoTiet into g
                 orderby g.Key descending
                 select new { SoTiet = g.Key, Tong = g.Count() };
        var ms = dsMon.GroupBy(m => m.SoTiet)
                      .OrderByDescending(g => g.Key)
                      .Select(g => new { SoTiet = g.Key, Tong = g.Count() });
        Console.WriteLine("  Query Syntax:");
        foreach (var x in qs) Console.WriteLine($"    Số tiết {x.SoTiet}: {x.Tong} môn");
        Console.WriteLine("  Method Syntax:");
        foreach (var x in ms) Console.WriteLine($"    Số tiết {x.SoTiet}: {x.Tong} môn");
    }

    static void Bai52_f()
    {
        Console.WriteLine("\nf. Môn có số tiết cao nhất:");
        int max = (from m in dsMon select (int)m.SoTiet).Max();
        var qs = from m in dsMon where m.SoTiet == max select m;
        var ms = dsMon.Where(m => m.SoTiet == dsMon.Max(x => x.SoTiet));
        InMon("Query Syntax", qs);
        InMon("Method Syntax", ms);
    }

    static void Bai52_g()
    {
        Console.WriteLine("\ng. Thống kê theo hệ:");
        var qs = from m in dsMon
                 group m by m.He into g
                 select new
                 {
                     He = g.Key,
                     TongMon = g.Count(),
                     TongTiet = g.Sum(x => x.SoTiet),
                     Max = g.Max(x => x.SoTiet),
                     Min = g.Min(x => x.SoTiet)
                 };
        var ms = dsMon.GroupBy(m => m.He).Select(g => new
        {
            He = g.Key,
            TongMon = g.Count(),
            TongTiet = g.Sum(x => x.SoTiet),
            Max = g.Max(x => x.SoTiet),
            Min = g.Min(x => x.SoTiet)
        });
        Console.WriteLine("  Query Syntax:");
        foreach (var x in qs)
            Console.WriteLine($"    Hệ {TenHe(x.He),-10}: {x.TongMon} môn, tổng {x.TongTiet} tiết, cao nhất {x.Max}, thấp nhất {x.Min}");
        Console.WriteLine("  Method Syntax:");
        foreach (var x in ms)
            Console.WriteLine($"    Hệ {TenHe(x.He),-10}: {x.TongMon} môn, tổng {x.TongTiet} tiết, cao nhất {x.Max}, thấp nhất {x.Min}");
    }

    static void Bai52_h()
    {
        Console.WriteLine("\nh. Các môn phân nhóm theo hệ:");
        var qs = from m in dsMon group m by m.He into g select g;
        var ms = dsMon.GroupBy(m => m.He);
        InNhom("Query Syntax", qs);
        InNhom("Method Syntax", ms);
    }

    static void Bai52_i()
    {
        Console.WriteLine("\ni. Các môn phân nhóm theo số tiết, tăng dần:");
        var qs = from m in dsMon group m by m.SoTiet into g orderby g.Key select g;
        var ms = dsMon.GroupBy(m => m.SoTiet).OrderBy(g => g.Key);
        InNhom("Query Syntax", qs);
        InNhom("Method Syntax", ms);
    }

    static void Bai52_j()
    {
        Console.WriteLine("\nj. Hệ KTV, nhóm theo học phần HP2..HP5:");
        var qs = from m in dsMon
                 where m.He == "KTV"
                 orderby m.MaMon
                 group m by m.MaMon.Substring(0, 3) into g
                 orderby g.Key
                 select g;
        var ms = dsMon.Where(m => m.He == "KTV")
                      .OrderBy(m => m.MaMon)
                      .GroupBy(m => m.MaMon.Substring(0, 3))
                      .OrderBy(g => g.Key);
        InNhom("Query Syntax", qs);
        InNhom("Method Syntax", ms);
    }

    static void Bai52_k()
    {
        Console.WriteLine("\nk. Nhóm theo hệ, chỉ lấy số tiết > 40, sắp xếp theo mã môn:");
        var qs = from m in dsMon
                 where m.SoTiet > 40
                 orderby m.MaMon
                 group m by m.He into g
                 select g;
        var ms = dsMon.Where(m => m.SoTiet > 40)
                      .OrderBy(m => m.MaMon)
                      .GroupBy(m => m.He);
        InNhom("Query Syntax", qs);
        InNhom("Method Syntax", ms);
    }

        // HÀM IN BÀI 6
    static void InDS<T>(string nhan, IEnumerable<T> ds)
    {
        Console.WriteLine($"  {nhan}:");
        foreach (var x in ds) Console.WriteLine($"    {x}");
    }

    static string LayTenHe(string ma)
        => dsHe.FirstOrDefault(h => h.MaHe == ma)?.TenHe ?? "(chưa khai báo hệ)";

    // BÀI 6.2
    static void Bai62_a()
    {
        Console.WriteLine("\na. Join: Tên hệ, Mã môn, Tên môn:");
        var qs = from h in dsHe
                 join m in dsMon on h.MaHe equals m.He
                 select new { h.TenHe, m.MaMon, m.TenMon };
        var ms = dsHe.Join(dsMon, h => h.MaHe, m => m.He,
                           (h, m) => new { h.TenHe, m.MaMon, m.TenMon });
        InDS("Query Syntax", qs);
        InDS("Method Syntax", ms);
    }

    static void Bai62_b()
    {
        Console.WriteLine("\nb. Left outer join (có cả hệ chưa có môn):");
        var qs = from h in dsHe
                 join m in dsMon on h.MaHe equals m.He into gj
                 from mon in gj.DefaultIfEmpty()
                 select new
                 {
                     h.TenHe,
                     MaMon = mon?.MaMon ?? "(chưa có)",
                     TenMon = mon?.TenMon ?? "(chưa có)"
                 };
        var ms = dsHe.GroupJoin(dsMon, h => h.MaHe, m => m.He, (h, gj) => new { h, gj })
                     .SelectMany(x => x.gj.DefaultIfEmpty(),
                                 (x, mon) => new
                                 {
                                     x.h.TenHe,
                                     MaMon = mon?.MaMon ?? "(chưa có)",
                                     TenMon = mon?.TenMon ?? "(chưa có)"
                                 });
        InDS("Query Syntax", qs);
        InDS("Method Syntax", ms);
    }

    static void Bai62_c()
    {
        Console.WriteLine("\nc. Cả hệ chưa có môn và môn chưa khai báo hệ:");

        // Query Syntax: left join + right join rồi Union
        var trai = from h in dsHe
                   join m in dsMon on h.MaHe equals m.He into gj
                   from mon in gj.DefaultIfEmpty()
                   select new
                   {
                       TenHe = h.TenHe,
                       MaMon = mon?.MaMon ?? "(chưa có)",
                       TenMon = mon?.TenMon ?? "(chưa có)"
                   };
        var phai = from m in dsMon
                   join h in dsHe on m.He equals h.MaHe into gj
                   from he in gj.DefaultIfEmpty()
                   select new
                   {
                       TenHe = he?.TenHe ?? "(chưa khai báo hệ)",
                       MaMon = m.MaMon,
                       TenMon = m.TenMon
                   };
        var qs = trai.Union(phai);

        // Method Syntax
        var traiMs = dsHe.GroupJoin(dsMon, h => h.MaHe, m => m.He, (h, gj) => new { h, gj })
                         .SelectMany(x => x.gj.DefaultIfEmpty(),
                                     (x, mon) => new
                                     {
                                         TenHe = x.h.TenHe,
                                         MaMon = mon?.MaMon ?? "(chưa có)",
                                         TenMon = mon?.TenMon ?? "(chưa có)"
                                     });
        var phaiMs = dsMon.GroupJoin(dsHe, m => m.He, h => h.MaHe, (m, gj) => new { m, gj })
                          .SelectMany(x => x.gj.DefaultIfEmpty(),
                                      (x, he) => new
                                      {
                                          TenHe = he?.TenHe ?? "(chưa khai báo hệ)",
                                          MaMon = x.m.MaMon,
                                          TenMon = x.m.TenMon
                                      });
        var ms = traiMs.Union(phaiMs);

        InDS("Query Syntax", qs);
        InDS("Method Syntax", ms);
    }

    static void Bai62_d()
    {
        Console.WriteLine("\nd. Chỉ hệ chưa có môn và môn chưa khai báo hệ:");

        var heQs = from h in dsHe
                   join m in dsMon on h.MaHe equals m.He into gj
                   where !gj.Any()
                   select h.TenHe;
        var monQs = from m in dsMon
                    join h in dsHe on m.He equals h.MaHe into gj
                    where !gj.Any()
                    select $"{m.MaMon} - {m.TenMon}";

        var heMs = dsHe.GroupJoin(dsMon, h => h.MaHe, m => m.He, (h, gj) => new { h, gj })
                       .Where(x => !x.gj.Any())
                       .Select(x => x.h.TenHe);
        var monMs = dsMon.GroupJoin(dsHe, m => m.He, h => h.MaHe, (m, gj) => new { m, gj })
                         .Where(x => !x.gj.Any())
                         .Select(x => $"{x.m.MaMon} - {x.m.TenMon}");

        InDS("Query Syntax - hệ chưa có môn", heQs);
        InDS("Query Syntax - môn chưa khai báo hệ", monQs);
        InDS("Method Syntax - hệ chưa có môn", heMs);
        InDS("Method Syntax - môn chưa khai báo hệ", monMs);
    }

    static void Bai62_e()
    {
        Console.WriteLine("\ne. 5 môn đầu có số tiết giảm dần:");
        var qs = (from h in dsHe
                  join m in dsMon on h.MaHe equals m.He
                  orderby m.SoTiet descending
                  select new { h.TenHe, m.MaMon, m.TenMon, m.SoTiet }).Take(5);
        var ms = dsHe.Join(dsMon, h => h.MaHe, m => m.He,
                           (h, m) => new { h.TenHe, m.MaMon, m.TenMon, m.SoTiet })
                     .OrderByDescending(x => x.SoTiet)
                     .Take(5);
        InDS("Query Syntax", qs);
        InDS("Method Syntax", ms);
    }

    static void Bai62_f()
    {
        Console.WriteLine("\nf. Tổng số môn của mỗi hệ:");
        var qs = from h in dsHe
                 join m in dsMon on h.MaHe equals m.He into gj
                 select new { h.MaHe, h.TenHe, TongSoMon = gj.Count() };
        var ms = dsHe.GroupJoin(dsMon, h => h.MaHe, m => m.He,
                                (h, gj) => new { h.MaHe, h.TenHe, TongSoMon = gj.Count() });
        InDS("Query Syntax", qs);
        InDS("Method Syntax", ms);
    }

    static void Bai62_g()
    {
        Console.WriteLine("\ng. Số loại Số tiết khác nhau:");
        int qs = (from m in dsMon select m.SoTiet).Distinct().Count();
        int ms = dsMon.Select(m => m.SoTiet).Distinct().Count();
        Console.WriteLine($"  Query Syntax : {qs}");
        Console.WriteLine($"  Method Syntax: {ms}");
    }

    static void Bai62_h()
    {
        Console.WriteLine("\nh. Môn đầu tiên có tên bắt đầu bằng \"Lập trình\":");
        var qs = (from m in dsMon
                  where m.TenMon.StartsWith("Lập trình", StringComparison.OrdinalIgnoreCase)
                  select m).FirstOrDefault();
        var ms = dsMon.FirstOrDefault(m => m.TenMon.StartsWith("Lập trình", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine($"  Query Syntax : {(qs == null ? "(không có)" : $"{qs.MaMon} - {qs.TenMon}")}");
        Console.WriteLine($"  Method Syntax: {(ms == null ? "(không có)" : $"{ms.MaMon} - {ms.TenMon}")}");
    }

    static void Bai62_i()
    {
        Console.WriteLine("\ni. Các môn theo từng hệ, đánh số thứ tự trong nhóm:");

        var qs = from m in dsMon
                 group m by m.He into g
                 select new
                 {
                     TenHe = LayTenHe(g.Key),
                     Mon = g.Select((m, i) => new { STT = i + 1, m.MaMon, m.TenMon })
                 };
        var ms = dsMon.GroupBy(m => m.He)
                      .Select(g => new
                      {
                          TenHe = LayTenHe(g.Key),
                          Mon = g.Select((m, i) => new { STT = i + 1, m.MaMon, m.TenMon })
                      });

        Console.WriteLine("  Query Syntax:");
        foreach (var g in qs)
        {
            Console.WriteLine($"    [{g.TenHe}]");
            foreach (var x in g.Mon)
                Console.WriteLine($"      {x.STT}. {x.MaMon,-6} | {x.TenMon}");
        }

        Console.WriteLine("  Method Syntax:");
        foreach (var g in ms)
        {
            Console.WriteLine($"    [{g.TenHe}]");
            foreach (var x in g.Mon)
                Console.WriteLine($"      {x.STT}. {x.MaMon,-6} | {x.TenMon}");
        }
    }

    
}

// BÀI 4.1
public class MonHoc
{
    public string MaMon { get; set; } = "";
    public string TenMon { get; set; } = "";
    public string He { get; set; } = "";
    public byte SoTiet { get; set; }
}

public class DuLieu
{
    public static List<MonHoc> DS_Mon()
    {
        return new List<MonHoc>
        {
            new MonHoc { MaMon = "HP2_1", TenMon = "Nền tảng C#", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP2_2", TenMon = "Công nghệ ADO.NET", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP3_1", TenMon = "Lập trình Windows Forms", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP3_2", TenMon = "Xây dựng ứng dụng Windows Forms", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP4_1", TenMon = "Lập trình Web với HTML, CSS và JavaScript", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP4_2", TenMon = "Xây dựng ứng dụng Web với ASP.NET", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP5_1", TenMon = "Lập trình CSDL SQL Server căn bản", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP5_2", TenMon = "Lập trình CSDL SQL Server nâng cao", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "JLCB", TenMon = "Joomla cơ bản", He = "CD", SoTiet = 72 },
            new MonHoc { MaMon = "LINQ", TenMon = "Language-Integrated Query", He = "CD", SoTiet = 64 },
            new MonHoc { MaMon = "DAWEB", TenMon = "Đồ án thực tế Web với ASP.NET", He = "CD", SoTiet = 40 },
            new MonHoc { MaMon = "DAWIN", TenMon = "Đồ án thực tế Windows Forms", He = "CD", SoTiet = 40 },
            new MonHoc { MaMon = "CC++", TenMon = "Lập trình hướng đối tượng với C/C++", He = "CD", SoTiet = 128 },
            new MonHoc { MaMon = "JQUE", TenMon = "JQuery", He = "CD", SoTiet = 22 },
            new MonHoc { MaMon = "XML", TenMon = "Công nghệ XML", He = "CD", SoTiet = 32 },
            new MonHoc { MaMon = "CRYS", TenMon = "Crystal Report trong Visual Studio", He = "CD", SoTiet = 32 },
            new MonHoc { MaMon = "BWEB", TenMon = "HTML, CSS và JavaScript", He = "CD", SoTiet = 32 },
            new MonHoc { MaMon = "XYZ", TenMon = "Chưa đặt tên môn", He = "", SoTiet = 0 }
        };
    }
        public static List<He> DS_He()
    {
        return new List<He>
        {
            new He { MaHe = "KTV", TenHe = "Kỹ thuật viên" },
            new He { MaHe = "CD",  TenHe = "Chuyên đề" },
            new He { MaHe = "QT",  TenHe = "Chứng chỉ quốc tế" }
        };
    }
}
// BÀI 6.1
public class He
{
    public string MaHe { get; set; } = "";
    public string TenHe { get; set; } = "";
}