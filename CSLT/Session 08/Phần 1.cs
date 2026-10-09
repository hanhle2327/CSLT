using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace CSLT.Session_08
{
    internal class Phần_1
    {
        public static void Main1(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào chiều cao của bạn:");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào tuổi của bạn:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Giá vé của bạn là: {CalculateBaseTicketPrice(height, age)}.000 VNĐ");

            //Bài 2
            Console.WriteLine("bạn mua vé vào thứ mấy?");
            Console.WriteLine("(Thứ Hai/Monday, Thứ Ba/Tuesday, Thứ Tư (Wednesday), Thứ Năm (Thusday), Thứ Sáu (Friday), Thứ Bảy (Saturday), Chủ Nhật (Sunday)");
            string dayOfWeek = Console.ReadLine();
            Console.WriteLine("Bạn có phải là thành viên (member) không?");
            Console.WriteLine("1 - Có; 0 - Không");
            bool isMember = false;
            int member = int.Parse(Console.ReadLine());
            if (member == 1)
                isMember = true;
            else
                isMember = false;
            Console.WriteLine($"Số tiền phải trả sau khi được giảm giá là: {ApplyDiscount(CalculateBaseTicketPrice(height, age), dayOfWeek, isMember, height, age)}");


            //Bài 3
            Console.Write("Bạn đi mấy người? ");
            int soNguoi = int.Parse(Console.ReadLine());
            double tongTienNhom = 0;
            double soTienThucTra = 0;
            for (int i = 1; i <= soNguoi; i++)
            {
                Console.WriteLine($"Nhập chiều cao của người thứ {i}: ");
                double chieuCao = double.Parse(Console.ReadLine());
                Console.WriteLine($"Nhập tuổi của người thứ {i}: ");
                int tuoi = int.Parse(Console.ReadLine());
                tongTienNhom += CalculateBaseTicketPrice(chieuCao, tuoi);
                Console.WriteLine("bạn mua vé vào thứ mấy?");
                Console.WriteLine("(Thứ Hai/Monday, Thứ Ba/Tuesday, Thứ Tư (Wednesday), Thứ Năm (Thusday), Thứ Sáu (Friday), Thứ Bảy (Saturday), Chủ Nhật (Sunday)");
                string dayOfWeekBuy = Console.ReadLine();
                Console.WriteLine("Bạn có phải là thành viên (member) không?");
                Console.WriteLine("1 - Có; 0 - Không");
                bool laThanhVien = false;
                int ThanhVien = int.Parse(Console.ReadLine());
                if (ThanhVien == 1)
                    laThanhVien = true;
                else
                    laThanhVien = false;
                soTienThucTra += ApplyDiscount(CalculateBaseTicketPrice(chieuCao, tuoi), dayOfWeek, isMember, chieuCao, tuoi);

            }
            Console.WriteLine($"Tổng số tiền nhóm phải trả là: {tongTienNhom}");
            Console.WriteLine($"Tổng số tiền nhóm được giảm giá là: {tongTienNhom - soTienThucTra}");
            Console.WriteLine($"Tổng số tiền nhóm phải trả cuối cùng là: {soTienThucTra}");
        }
            

            // Bảng quy định giá vé niêm yết:
            //Đối tượng khách hàng    Điều kiện áp dụng   Giá vé quy định
            //Trẻ em  Chiều cao dưới 1.2m	50,000 VNĐ
            //Người lớn Từ 1.2m trở lên và dưới 60 tuổi	100,000 VNĐ
            //Người cao tuổi  Từ 60 tuổi trở lên(không xét chiều cao)    40,000 VNĐ

            //Câu 1.1: Tính giá vé chuẩn cho từng khách hàng(2.0 điểm)
            //Viết hàm CalculateBaseTicketPrice(double height, int age) trả về giá vé chuẩn kiểu double.
            //- Nhận vào tham số chiều cao height(mét) và tuổi age(năm).
            //- Áp dụng chính xác thứ tự ưu tiên theo Bảng quy định giá vé trên.

            static double CalculateBaseTicketPrice(double height, int age)
        {
            int giaVe = 0;
            if (height < 1.2)
            {
                giaVe = 50;
            }
            else if (height > 1.2 && age < 60)
            {
                giaVe = 100;
            }
            else if (age >= 60)
            {
                giaVe = 40;
            }
            return giaVe;
        }

        //Câu 1.2: Áp dụng chính sách ưu đãi &giảm giá(2.0 điểm)
        //Viết hàm ApplyDiscount(double totalAmount, string dayOfWeek, bool isMember) trả về số tiền phải trả sau khi giảm giá.
        //- Giảm giá theo ngày trong tuần (dayOfWeek): Thứ Ba ("Tuesday") giảm 10%; Thứ Tư("Wednesday") giảm 15%; các ngày khác giảm 0%.
        //- Ưu đãi thành viên(isMember): Nếu isMember == true, giảm thêm 5% trên số tiền đã giảm theo ngày.
        static double ApplyDiscount(double totalAmount, string dayOfWeek, bool isMember, double height, int age)
        {
            double soTienDuocGiam = 0;
            if (dayOfWeek == "Tuesday" || dayOfWeek == "Thứ Ba")
            {
                soTienDuocGiam = CalculateBaseTicketPrice(height, age) * 0.1;
                if (isMember == true)
                {
                    soTienDuocGiam += (CalculateBaseTicketPrice(height, age) - soTienDuocGiam) * 0.05;
                }
            }
            else if (dayOfWeek == "Wednesday" || dayOfWeek == "Thứ Tư")
            {
                soTienDuocGiam = CalculateBaseTicketPrice(height, age) * 0.15;
                if (isMember == true)
                {
                    soTienDuocGiam += (CalculateBaseTicketPrice(height, age) - soTienDuocGiam) * 0.05;
                }
            }
            else if (dayOfWeek != "Tuesday" && dayOfWeek != "Wednesday")
            {
                soTienDuocGiam = 0;
                if (isMember == true)
                {
                    soTienDuocGiam += (CalculateBaseTicketPrice(height, age) - soTienDuocGiam) * 0.05;
                }
            }
            totalAmount = CalculateBaseTicketPrice(height, age) - soTienDuocGiam;
            return totalAmount;

            //Câu 1.3: Quy trình xử lý tính tiền 1 đơn hàng(2.0 điểm)
            //Viết hàm ProcessSingleOrder() thực hiện toàn bộ luồng xử lý cho 1 đơn hàng của một nhóm khách:
            //1.Nhập số lượng khách hàng trong nhóm.
            //2.Sử dụng vòng lặp(for/while) để nhập chiều cao và tuổi từng người, gọi hàm CalculateBaseTicketPrice để cộng dồn tính tổng tiền gốc.
            //3.Nhập ngày trong tuần(ví dụ: "Tuesday") và trạng thái thành viên(true / false).
            //4.Gọi hàm ApplyDiscount để xác định số tiền thanh toán cuối cùng.
            //5.In ra hóa đơn chi tiết gồm: Tổng tiền gốc, Số tiền giảm giá, và Số tiền thực thanh toán.
            
                }
            }
        }

    
