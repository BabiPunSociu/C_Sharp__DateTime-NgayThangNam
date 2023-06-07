using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhapDateTime_NgayThangNam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateOfBirth;
            // Nhập ngày sinh dạng dd/mm/yyyy
            Console.Write("\nNhap ngay sinh (dd/mm/yyyy) : ");
            string input = (Console.ReadLine()).Trim();
            string[] arrListStr = input.Split('/', ' ', '.', '-', '_'); // Tách chuỗi theo các kí tự
            int ngay = int.Parse(arrListStr[0]);
            if (ngay < 1 || ngay > 31) throw new Exception("Loi nhap ngay");
            int thang = int.Parse(arrListStr[1]);
            if (thang < 1 || thang > 12) throw new Exception("Loi nhap thang");
            int nam = int.Parse(arrListStr[2]);

            dateOfBirth = new DateTime(nam, thang, ngay);

            Console.WriteLine(dateOfBirth);
            Console.WriteLine();
            Console.WriteLine(dateOfBirth.ToString("dd/MM/yyyy"));   // Định dạng ngày tháng năm
        }
    }
}
