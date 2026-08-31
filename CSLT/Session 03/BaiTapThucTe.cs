using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Channels;

namespace CSLT.Session_03
{
    internal class BaiTapThucTe
    {
        static void Bai_1()
        {
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
            /*Bài 2: Hệ Thống Theo Dõi Chỉ Số BMI & Đánh Giá Tình Trạng Sức Khỏe
            Tình huống thực tế: Một ứng dụng theo dõi sức khỏe cá nhân cần tính chỉ số khối cơ thể (BMI - Body Mass
            Index) dựa trên chiều cao và cân nặng do người dùng cung cấp, đồng thời đưa ra lời khuyên về cân nặng lý
            tưởng.
            Kiến thức trọng tâm: Kiểu double, ép kiểu, Math.Pow(), định dạng số thập phân ({0:F2}), cấu trúc rẽ nhánh.
            Yêu cầu bài toán:
            • Nhập vào chiều cao (tính bằng mét, ví dụ 1.72) và cân nặng (tính bằng kg, ví dụ 68.5).
            • Tính chỉ số BMI theo công thức: BMI = Cân nặng / (Chiều cao ^ 2).
            • Phân loại tình trạng sức khỏe theo chuẩn WHO dành cho người châu Á:
            • + BMI < 18.5: Gầy (Thiếu cân)
            • + 18.5 <= BMI < 23.0: Bình thường (Lý tưởng)
            • + 23.0 <= BMI < 25.0: Thừa cân (Tiền béo phì)
            • + BMI >= 25.0: Béo phì
            • Tính dải cân nặng lý tưởng cho chiều cao đó (Cân nặng tối thiểu = 18.5 * Chiều cao^2; Cân nặng tối đa =
            22.9 * Chiều cao^2).
            • Xuất ra chỉ số BMI (lấy 2 chữ số thập phân), phân loại và khoảng cân nặng lý tưởng.
            Ví dụ minh họa Input / Output:*/

            Console.WriteLine("Nhập chiều cao của bạn (m): ");
            double chieuCao = double.Parse( Console.ReadLine() );
            Console.WriteLine("Nhập cân nặng của bạn (kg): ");
            double canNang = double.Parse( Console.ReadLine() );
            double BMI = canNang / (chieuCao * chieuCao);
            string phanLoai;
            if (BMI < 18.5)
            {
                phanLoai = "Gầy (Thiếu cân)";
            }
            else if (18.5 <= BMI && BMI < 23)
            {
                phanLoai = "Bình thường (Lý tưởng)";
            }
            else if (23 <= BMI && BMI < 25)
            {
                phanLoai = "Thừa cân (Tiền béo phì)";
            }
            else
            {
                phanLoai = "Béo phì";
            }
            double canNangToiThieu = 18.5 * (chieuCao * chieuCao);
            double canNangToiDa = 22.9 * (chieuCao * chieuCao);
            Console.WriteLine($"Chỉ số BMI của bạn: {BMI:F2}");
            Console.WriteLine($"Phân loại sức khỏe: {phanLoai}");
            Console.WriteLine($"Khuyên dùng: Cân nặng lí tưởng của bạn nên từ {canNangToiThieu:F2} kg đến {canNangToiDa:F2} kg.");
        }
        enum CurrencyType
        {
            USD,
            EUR,
            JPY,
            GBP
        }
        static void Bai_3()
        {
            /*Bài 3: Ứng Dụng Quy Đổi Tiền Tệ Ngoại Tệ Đa Tỷ Giá Ngân Hàng
            Tình huống thực tế: Một quầy đổi tiền tại sân bay cần ứng dụng tính toán nhanh số tiền khách hàng nhận
            được khi đổi từ Việt Nam Đồng (VND) sang các loại ngoại tệ phổ biến (USD, EUR, JPY, GBP) có tính phí dịch
            vụ.
            Kiến thức trọng tâm: Kiểu decimal, enum (CurrencyType), switch-case, định dạng tiền tệ quốc tế.
            Yêu cầu bài toán:
            • Tạo một enum tên CurrencyType gồm: USD, EUR, JPY, GBP.
            • Khai báo tỷ giá cố định (Ví dụ: 1 USD = 25,400 VNĐ; 1 EUR = 27,200 VNĐ; 1 JPY = 165 VNĐ; 1 GBP =
            32,100 VNĐ).
            • Nhập vào số tiền VNĐ cần đổi (decimal) và chọn loại ngoại tệ muốn đổi.
            • Phí dịch vụ quy đổi là 0.5% trên tổng số tiền VNĐ.
            • Tính số tiền VNĐ thực tế sau khi trừ phí, sau đó quy đổi ra ngoại tệ tương ứng.
            • In kết quả chính xác đến 2 chữ số thập phân kèm ký hiệu tiền tệ*/


            decimal tyGiaUSD = 25400m;
            decimal tyGiaEUR = 27200m;
            decimal tyGiaJPY = 1650m;
            decimal tyGiaGBP = 32100m;

            Console.WriteLine("Nhập số tiền VNĐ: ");
            decimal soTienVNĐ = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
            int luaChon = int.Parse(Console.ReadLine());
            CurrencyType loaiTien;
            switch (luaChon)
            {
                case 1:
                    loaiTien = CurrencyType.USD; 
                    break;
                case 2:
                    loaiTien = CurrencyType.EUR;
                    break;
                case 3:
                    loaiTien = CurrencyType.JPY;
                    break;
                default:
                    loaiTien = CurrencyType.GBP; 
                    break;
            }

            decimal phiDichVu = 0.005m * soTienVNĐ;
            decimal soTienSauPhi = soTienVNĐ - phiDichVu;
            decimal tyGia;
            string kiHieu;
            switch (loaiTien)
            {
                case CurrencyType.USD:
                    tyGia = tyGiaUSD;
                    kiHieu = "USD";
                    break;
                case CurrencyType.EUR:
                    tyGia = tyGiaEUR;
                    kiHieu = "EUR";
                    break;
                case CurrencyType.JPY:
                    tyGia = tyGiaJPY;
                    kiHieu = "JYP";
                    break;
                default:
                    tyGia = tyGiaGBP;
                    kiHieu = "GBP";
                    break;
            }
            decimal soTienNgoaiTe = soTienSauPhi / tyGia;
            Console.WriteLine($"Phí dịch vụ (0.5%): {phiDichVu:#,##0} VNĐ");
            Console.WriteLine($"Số tiền VNĐ tính đổi: {soTienSauPhi:#,##0} VNĐ");
            Console.WriteLine($"Số tiền {kiHieu} nhận được: {soTienNgoaiTe:F2} {kiHieu}");
        }
        static void Bai_4()
        {
            /*Bài 4: Tính Tuổi Chính Xác & Đếm Ngược Ngày Sinh Nhật
            Tình huống thực tế: Hệ thống chăm sóc khách hàng của một công ty bán lẻ cần tự động tính tuổi chính xác
            của khách hàng và đếm số ngày còn lại đến sinh nhật tiếp theo để gửi voucher ưu đãi.
            Kiến thức trọng tâm: Kiểu DateTime, TimeSpan, DateTime.ParseExact, toán tử trừ hai ngày, ép kiểu.
            Yêu cầu bài toán:
            • Nhập ngày tháng năm sinh của người dùng dưới dạng chuỗi 'dd/MM/yyyy' (ví dụ: '25/10/2002').
            • Chuyển đổi chuỗi thành DateTime sử dụng DateTime.TryParseExact để đảm bảo không bị lỗi định dạng.
            • Lấy ngày hiện tại hệ thống (DateTime.Now.Date).
            • Tính tuổi chính xác tính theo số năm.
            • Xác định ngày sinh nhật tiếp theo trong năm nay hoặc năm sau. Tính số ngày còn lại đến sinh nhật đó.
            • Hiển thị: Tuổi hiện tại, Tổng số ngày đã sống từ lúc sinh ra, và Số ngày còn lại đến sinh nhật kế tiếp*/

            Console.WriteLine("Nhập ngày sinh (dd/MM/yyyy): ");
            String DOB = Console.ReadLine();
            string fomat = "dd/MM/YYYY";
            do
            {
                if (DateTime.TryParseExact(DOB, fomat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                {
                    Console.WriteLine("Ngày đã nhập: " + parsedDate.ToString("yyyy/MM/dd"));
                }
                else
                {
                    Console.WriteLine("Chuỗi ngày tháng không hợp lệ, vui lòng nhập lại!");
                }
            } while (true);

            DateTime ngayHienTai = DateTime.Now.Date;

            
        }
        public static void Main10(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai_1();
            Bai_2();
            Bai_3();
            




            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
    }
}
