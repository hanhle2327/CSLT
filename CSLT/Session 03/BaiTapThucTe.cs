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
            //+ Bậc 1: Cho 50 kWh đầu tiên (từ 0 - 50 kWh): 1.806 VNĐ/kWh
            //• +Bậc 2: Cho 50 kWh tiếp theo(từ 51 - 100 kWh): 1.866 VNĐ / kWh
            //• +Bậc 3: Cho 100 kWh tiếp theo(từ 101 - 200 kWh): 2.167 VNĐ / kWh
            //• +Bậc 4: Cho 100 kWh tiếp theo(từ 201 - 300 kWh): 2.729 VNĐ / kWh
            float GiaBac1 = 1806, GiaBac2 = 1866, GiaBac3 = 2167, GiaBac4 = 2729;
            decimal tienDienChuaThue;
            if (tieuThu <= 50)
            {
                tienDienChuaThue = (decimal)(tieuThu * GiaBac1);
            }    
            else if (tieuThu > 50 && tieuThu <= 100)
            {
                tienDienChuaThue = (decimal)(50 * GiaBac1 + (tieuThu - 50) * GiaBac2 );
            }    
            else if (tieuThu > 100 && tieuThu <= 200)
            {
                tienDienChuaThue = (decimal)(50 * GiaBac1 + 50 * GiaBac2 + (tieuThu - 100) * GiaBac3);
            }
            else
            {
                tienDienChuaThue = (decimal)(50 * GiaBac1 + 50 * GiaBac2 + 100 * GiaBac3 + (tieuThu - 200) * GiaBac4);
            } 
            
            decimal vat = (decimal) (tienDienChuaThue * 8 / 100);
            Console.WriteLine($"Số điện thiêu thụ: {tieuThu} kWh");
            Console.WriteLine($"Tiền điện chưa thuế: {tienDienChuaThue: #,##0} VNĐ");
            Console.WriteLine($"Thuế VAT: {vat: #,##0} VNĐ");
            Console.WriteLine($"Tổng thanh toán {tienDienChuaThue + vat: #,##0} VND");
        }
        static void Bai_2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*Bài 2: Hệ Thống Theo Dõi Chỉ Số BMI & Đánh Giá Tình Trạng Sức Khỏe
            Tình huống thực tế: Một ứng dụng theo dõi sức khỏe cá nhân cần tính chỉ số khối cơ thể (BMI - Body Mass
            Index) dựa trên chiều cao và cân nặng do người dùng cung cấp, đồng thời đưa ra lời khuyên về cân nặng lý
            tưởng.*/

        }
        public static void Main(string[] args)
        {
            Bai_1();
            Bai_2();
            




            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
    }
}
