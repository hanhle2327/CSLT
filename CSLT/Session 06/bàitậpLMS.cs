using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using System.Text;

namespace CSLT.Session_06
{
    internal class bàitậpLMS
    {
        public static void Main33 (string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //// Bài 1
            Console.WriteLine("Nhập vào hai số nguyên cần tính tổng");
            Console.Write("Nhập số nguyên thứ nhất: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số nguyên thứ hai: ");
            int b = int.Parse(Console.ReadLine());
            int sum = TinhTong(a, b);
            Console.WriteLine($"Tổng của số {a} và số {b} là {sum}");
            Console.WriteLine();

            ////Bài 2
            Console.Write("Nhập vào số nguyên cần kiểm tra: ");
            int n = int.Parse(Console.ReadLine());
            string KetQua = KiemTraChan(n) ? "chẵn" : "lẻ"; // Toán tử ba ngôi. Cú pháp: điều_kiện ? biểu_thức_nếu_đúng : biểu_thức_nếu_sai; trong đó điều kiện là biểu thức trả về giá trị true/false
            Console.WriteLine($"Số nguyên {n} là một số {KetQua}");
            Console.WriteLine();

            ////Bài 3
            Console.WriteLine("Nhập vào ba số nguyên cần tìm Max");
            Console.Write("Nhập vào số nguyên thứ nhất: ");
            int so1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào số nguyên thứ hai: ");
            int so2 = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào số nguyên thứ ba: ");
            int so3 = int.Parse(Console.ReadLine());
            int KetQua3 = TimMax(so1, so2, so3);
            Console.WriteLine($"Số lớn nhất trong ba số nhập vào ({so1}, {so2}, {so3}) là: {KetQua3}");
            Console.WriteLine();

            ////Bài 4
            Console.Write("Nhập vào 1 số muốn tình giai thừa: ");
            int m = int.Parse(Console.ReadLine());
            long KetQua4 = TinhTongGiaiThua(m);
            Console.WriteLine($"Giai thừa của số {m} là: {KetQua4}");
            Console.WriteLine();

            ////Bài 5
            Console.Write("Nhập vào chuỗi kí tự muốn đảo ngược: ");
            string chuoi = Console.ReadLine();
            string KetQua5 = DaoNguocChuoi(chuoi);
            Console.WriteLine($"Chuỗi ban đầu là: {chuoi}");
            Console.WriteLine($"Chuỗi sau khi đảo ngược là: {KetQua5}");
            Console.WriteLine();

            ////Bài 6
            Console.Write("Nhập vào số muốn kiểm tra nguyên tố: ");
            int NguyenTo = int.Parse(Console.ReadLine());
            string KetQUa6 = KiemTraNguyenTo(NguyenTo) ? "là số nguyên tố" : "không là số nguyên tố";
            Console.WriteLine($"Số {NguyenTo} {KetQUa6}");
            Console.WriteLine();

            ////Bài 7
            Console.Write("Nhập vào số số muốn hiển thị trong dãy Fibonacci: ");
            int SoFibonacci = int.Parse(Console.ReadLine());
            Console.Write($"Input: {SoFibonacci} -> Dãy Fibonacci: ");
            InFibonacci(SoFibonacci);
            Console.WriteLine();

            ////Bài 8
            Console.WriteLine();
            Console.Write("Nhập vào 1 cụm từ muốn đếm nguyên âm: ");
            string TuKhoa = Console.ReadLine();
            int KetQua8 = DemNguyenAm(TuKhoa);
            Console.WriteLine($"Cụm từ vừa nhập ({TuKhoa}) có {KetQua8} nguyên âm");
            Console.WriteLine();

            ////Bài 9
            Console.WriteLine("Nhập số muốn tính lũy thừa:");
            Console.Write("Nhập cơ số:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Nhập số mũ:");
            int y = int.Parse(Console.ReadLine());
            double KetQua9 = TinhLuyThua(x, y);
            Console.WriteLine($"Lũy thừa của số có cơ số là {x}, số mũ là {y} là: {KetQua9}");
            Console.WriteLine();

            ////Bài 10
            Console.Write("Nhập vào số phần tử của mảng:");
            int SoPhanTu = int.Parse(Console.ReadLine());
            int[] arr = new int[SoPhanTu];
            Console.WriteLine($"Nhập vào {SoPhanTu} số nguyên:");
            for (int i = 0; i < SoPhanTu; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            double KetQua10 = TinhTrungBinh(arr);
            Console.WriteLine($"Input: [{string.Join(",", arr)}]");//Hàm {string.Join(",", arr)} --> để hiển thị mảng
            Console.WriteLine($"Output: {KetQua10}");

            ////Bài 11
            Console.Write("Nhập vào chuỗi bạn muốn kiểm tra đảo ngược: ");
            string ChuoiDoiXung = Console.ReadLine();
            string KetQua11 = KiemTraDoiXung(ChuoiDoiXung) ? "là chuỗi đối xứng" : "không là chuỗi đối xứng";
            Console.WriteLine($"Chuỗi bạn vừa nhập vào ({ChuoiDoiXung}) là {KetQua11}");

            ////Bài 12
            Console.Write("Nhập vào nhiệt độ (độ C) bạn muốn đổi sáng độ F: ");
            double c = double.Parse(Console.ReadLine());
            double KetQua12 = CelsiusToFaraheit(c);
            Console.WriteLine($"{c} độ C = {KetQua12} độ F");

            //Bài 13
            Console.Write("Nhập vào số phần tử của mảng: ");
            int PhanTu = int.Parse(Console.ReadLine());
            int[] arr13 = new int[PhanTu];
            Console.WriteLine($"Nhập vào {PhanTu} số nguyên");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Nhập vào phần tử thứ {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int KetQua14 = TimMin(arr);
            Console.WriteLine($"Mảng nhập vào: [{string.Join(",", arr)}]");
            Console.WriteLine($"Số nhỏ nhất rong mảng là: {KetQua14}");

            //Bài 14
            Console.Write("Nhập vào 1 số nguyên: ");
            int o = int.Parse (Console.ReadLine());
            Console.WriteLine($"Tổng của các chữ số tạo thành số nguyên vừa nhập là: {TongCacChuSo(o)}");

            //Bài 15
            int[] input = { 3, 1, 4, 2 };
            Console.WriteLine($"Mảng [3, 1, 4, 2] sau khi được xếp theo thứ tự là: ");
            SapXepMang (input);

            //Bài 16:
            Console.Write("Nhập chuỗi:");
            string chuoinhap7 = Console.ReadLine();
            string ketqua9 = XoaTrungLap(chuoinhap7);
            Console.WriteLine($"Chuỗi sau khi xóa ký tự trùng lặp: {ketqua9}");

            //Bài 17:
            Console.Write("Nhập số thứ nhất:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai:");
            int num2 = int.Parse(Console.ReadLine());
            int ketqua10 = UCLN(so1, so2);
            Console.WriteLine($"Ước chung lớn nhất của {num1} và {num2} là: {ketqua10}");

            //Bài 18:
            Console.Write("Nhập số thập phân: ");
            int sonhap4 = Convert.ToInt32(Console.ReadLine());
            string ketqua11 = DecimalToBinary(sonhap4);
            Console.WriteLine($"Chuyển đổi thành nhị phân: {ketqua11}");

            //Bài 19:
            Console.Write("Nhập năm:");
            int nam = Convert.ToInt32(Console.ReadLine());
            bool ketqua12 = KiemTraNamNhuan(nam);
            if (ketqua12)
                Console.WriteLine($"{nam} là năm nhuận.");
            else
                Console.WriteLine($"{nam} không phải là năm nhuận.");

            //Bài 20:
            Console.Write("Nhập chuỗi: ");
            string chuoinhap8 = Console.ReadLine();
            int ketqua13 = DemSoTu(chuoinhap8);
            Console.WriteLine($"Số từ trong câu: {ketqua13}");
        }

        //Bài 1: Tính tổng hai số nguyên
        //Yêu cầu: Viết hàm `int TinhTong(int a, int b)` nhận vào hai số nguyên và trả về tổng của chúng.
        static int TinhTong(int a, int b)
        {
            return a + b;
        }

        //Bài 2: Kiểm tra số chẵn lẻ
        //Yêu cầu: Viết hàm `bool KiemTraChan(int n)` trả về `true` nếu `n` là số chẵn, `false` nếu là số lẻ.
        // Hướng dẫn: Sử dụng toán tử chia lấy dư `%`. Nếu biểu thức `n % 2 == 0` đúng thì n là số chẵn. Bạn có thể return thẳng biểu thức này.

        static bool KiemTraChan(int n)
        {

            return n % 2 == 0;
        }

        //Bài 3: Tìm số lớn nhất trong ba số
        //Yêu cầu: Viết hàm `int TimMax(int a, int b, int c)` trả về giá trị lớn nhất trong ba số được truyền vào.
        //Hướng dẫn: Bạn có thể sử dụng cấu trúc điều kiện `if-else` lồng nhau. Cách ngắn gọn hơn là tận dụng hàm có sẵn `Math.Max(Math.Max(a, b), c)`
        static int TimMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }

        ////Bài 4: Tính giai thừa của một số
        //Yêu cầu: Viết hàm `long TinhGiaiThua(int n)` tính và trả về giai thừa của số nguyên dương n(n!).
        //Hướng dẫn: Sử dụng một biến lưu kết quả(khởi tạo bằng 1). Dùng vòng lặp `for` chạy từ 1 đến `n` để nhân dồn vào
        //biến kết quả.Chú ý: dùng kiểu `long` để tránh tràn số lượng giới hạn của `int`.
        static long TinhTongGiaiThua(int n)
        {
            int GiaiThua = 1;
            for (int i = 1; i <= n; i++)
            {
                GiaiThua *= i;
            }
            return GiaiThua;
        }

        //Bài 5: Đảo ngược chuỗi ký tự
        //Yêu cầu: Viết hàm `string DaoNguocChuoi(string input)` nhận vào một chuỗi và trả về chuỗi bị đảo ngược.
        //Hướng dẫn: Chuyển chuỗi thành mảng ký tự `char[]` bằng phương thức `.ToCharArray()`. Sau đó dùng hàm
        //`Array.Reverse()` để đảo mảng, cuối cùng tạo lại chuỗi mới bằng `new string (char_array)`.
        static string DaoNguocChuoi(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        //Bài 6: Kiểm tra số nguyên tố
        //Yêu cầu: Viết hàm `bool KiemTraNguyenTo(int n)` kiểm tra xem số nguyên n có phải số nguyên tố hay không.
        static bool KiemTraNguyenTo(int n)
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //Bài 7: In dãy Fibonacci
        //Yêu cầu: Viết hàm `void InFibonacci(int n)` in ra n số đầu tiên của dãy Fibonacci.
        //Kết quả mẫu: Input: 6 -> Output: 0 1 1 2 3 5
        static void InFibonacci(int n)
        {
            if (n < 0) return;
            int a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                int TiepTheo = a + b;
                a = b;
                b = TiepTheo;
            }
        }

        //Bài 8: Đếm số lượng nguyên âm trong chuỗi
        //Yêu cầu: Viết hàm `int DemNguyenAm(string s)` đếm số lượng các ký tự nguyên âm(a, e, i, o, u) trong chuỗi.
        //Kết quả mẫu: Input: "Hello World" -> Output: 3

        static int DemNguyenAm(string s)
        {
            int Dem = 0;
            string NguyenAm = "aeiou";
            foreach (char c in s.ToLower())
            {
                if (NguyenAm.Contains(c))
                {
                    Dem++;
                }
            }
            return Dem;
        }

        //Bài 9: Tính lũy thừa
        //Yêu cầu: Viết hàm `double TinhLuyThua(double x, int y)` tính x^y(không dùng Math.Pow).
        //Kết quả mẫu: Input: x = 2, y = 3 -> Output: 8

        static double TinhLuyThua(double x, int y)
        {
            if (y == 0) return 1;
            int SoMu = Math.Abs(y);
            double LuyThua = 1;
            for (int i = 0; i <= SoMu; i++)
            {
                LuyThua *= x;
            }
            if (y < 0)
            {
                return 1 / LuyThua;
            }
            return LuyThua;
        }

        //Bài 10: Tính điểm trung bình của mảng
        //Yêu cầu: Viết hàm `double TinhTrungBinh(int[] arr)` tính giá trị trung bình của mảng số nguyên.
        //Kết quả mẫu: Input: [4, 5, 6, 7] -> Output: 5.5
        static double TinhTrungBinh(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return 0;
            double tong = 0;
            foreach (int so in arr)
            {
                tong += so;
            }
            return tong / arr.Length;
        }

        //Bài 11: Kiểm tra chuỗi đối xứng(Palindrome)
        //Yêu cầu: Viết hàm `bool KiemTraDoiXung(string s)` kiểm tra chuỗi có đọc xuôi và ngược giống nhau không.
        //Kết quả mẫu: Input: "radar" -> Output: True | Input: "hello" -> Output: False

        static bool KiemTraDoiXung(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            string n = new string(charArray);
            if (s == n)
            {
                return true;
            }
            return false;
        }

        //Bài 12: Chuyển đổi nhiệt độ
        //Yêu cầu: Viết hàm `double CelsiusToFahrenheit(double c)` chuyển đổi từ độ C sang độ F.
        //Kết quả mẫu: Input: 25 -> Output: 77
        static double CelsiusToFaraheit(double c)
        {
            double F = 0;
            return F = c + 273;
        }

        //Bài 13: Tìm giá trị nhỏ nhất trong mảng
        //Yêu cầu: Viết hàm `int TimMin(int[] arr)` trả về phần tử nhỏ nhất trong mảng.
        //Kết quả mẫu: Input: [10, 5, 8, 2, 9] -> Output: 2
        static int TimMin(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("Mảng không được trống");
            }
            int Min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < Min)
                {
                    Min = arr[i];
                }
            }
            return Min;
        }

        //Bài 14: Tính tổng các chữ số của một số nguyên
        //Yêu cầu: Viết hàm `int TongCacChuSo(int n)` để tính tổng từng chữ số tạo nên n.
        //Kết quả mẫu: Input: 1234 -> Output: 10 (Vì 1+2+3+4 = 10)
        static int TongCacChuSo(int n)
        {
            int sum = 0;
            n = Math.Abs(n);
            while (n > 0)
            {
                sum += n % 10; //chia lấy phần dư cho 10 --> có số cuối
                n /= 10; //chia lấy phần nguyên cho 10 
            }
            return sum;
        }

        //Bài 15: Sắp xếp mảng tăng dần
        //Yêu cầu: Viết hàm `void SapXepMang(int[] arr)` sắp xếp và in ra mảng tăng dần.
        //Kết quả mẫu: Input: [3, 1, 4, 2] -> Output: 1 2 3 4

        static void SapXepMang(int[] a)
        {
            if (a == null) return;
            Array.Sort(a);
            Console.WriteLine(string.Join(" ", a));
        }


        //Bài 16: Xóa ký tự trùng lặp
        //Yêu cầu: Viết hàm `string XoaTrungLap(string s)` trả về chuỗi với các ký tự xuất hiện lần đầu tiên được giữ lại.
        //Kết quả mẫu: Input: "programming" -> Output: "progamin"

        static string XoaTrungLap(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;
            string trunglap = new string(s.Distinct().ToArray());
            return trunglap;
        }

        //Bài 17: Tìm ước chung lớn nhất (UCLN)
        //Yêu cầu: Viết hàm `int UCLN(int a, int b)` sử dụng thuật toán Euclid để tìm UCLN của 2 số.
        //Kết quả mẫu: Input: a = 12, b = 18->Output: 6

        static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        //Bài 18: Chuyển đổi hệ thập phân sang nhị phân
        //Yêu cầu: Viết hàm `string DecimalToBinary(int n)` nhận vào số thập phân và trả về chuỗi nhị phân.
        //Kết quả mẫu: Input: 10 -> Output: "1010"


        static string DecimalToBinary(int n)
        {
            return Convert.ToString(n, 2);
        }


        //Bài 19: Kiểm tra năm nhuận
        //Yêu cầu: Viết hàm `bool KiemTraNamNhuan(int year)` kiểm tra xem một năm có phải năm nhuận không.
        //Kết quả mẫu: Input: 2024 -> Output: True | Input: 2023 -> Output: False
        static bool KiemTraNamNhuan(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }


        //Bài 20: Đếm số từ trong câu
        //Yêu cầu: Viết hàm `int DemSoTu(string sentence)` trả về số lượng từ có trong câu.
        //Kết quả mẫu: Input: "Học lập trình C# rất thú vị" -> Output: 7
        static int DemSoTu(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
                return 0;
            return sentence.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

    }
}
