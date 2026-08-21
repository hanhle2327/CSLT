using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session_03
{
    internal class BaiTapThucTe
    {
        static void Bai_1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //DANH SÁCH 15 BÀI TẬP LẬP TRÌNH TÌNH HUỐNG THỰC TẾ
            /*Bài 1: Tính Tiền Điện Sinh Hoạt Gia Đình Theo Bậc Thang (EVN)
            Tình huống thực tế: Tập đoàn Điện lực Việt Nam (EVN) áp dụng biểu giá điện sinh hoạt bậc thang lũy tiến
            để khuyến khích người dân tiết kiệm điện. Hãy viết chương trình tính hóa đơn tiền điện hàng tháng cho một
            hộ gia đình.*/
            Console.WriteLine("Nhập chỉ số điện cũ (kWh): ");
            float Csd1 = float.Parse(Console.ReadLine());
            float Csd2;
            do
            {
                Console.WriteLine("Nhập chỉ số điện mới (kWh): ");
                Csd2 = float.Parse(Console.ReadLine());
                if (Csd1 <= Csd2)
                    break;
                else
                    Console.WriteLine("\nt**** Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ");
            } while (true);
            //lượng điện tiêu thụ trong tháng
            float tieuThu = Csd2 - Csd1;
            //giả sử giá điện cố định là 3050 VNĐ
            float donGia = 3050;
            decimal tienDien = (decimal)( tieuThu * donGia);
            decimal vat = (decimal) (tienDien * 8 / 100);
            Console.WriteLine($"Số điện thiêu thụ: {tieuThu}");
            Console.WriteLine($"Tiền điện chưa thuế: {tienDien}");
            Console.WriteLine($"Thuế VAT: {vat}");
            Console.WriteLine($"Tổng thanh toán {tienDien + vat}");
        }
        public static void Main(string[] args)
        {
            Bai_1();
            




            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
    }
}
