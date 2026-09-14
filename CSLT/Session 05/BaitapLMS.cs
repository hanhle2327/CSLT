using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session_05
{
    internal class BaitapLMS
    {
        static void Game_doan_so()
        {
            /* Cho người dùng chơi cho đến khi họ không chơi nữa
             *  5. Cho người dùng chọn mức độ chơi: Dễ - 9 lượt đoán, Trung bình - 6 lượt đoán, Khó - 4 lượt đoán
             * 1. Máy tính nghĩ ngẫu nhiên 1 số
             * 2. Hỏi người dùng đoán số
             * 3. Nếu người dùng đoán đúng thì thông báo đúng, 
             * nhỏ hơn --> thông báo nhỏ hơn, lớn hơn --> thông báo lớn hơn
             * 
             * 6. Thống kê số lần thắng/thua
             * 7. Tính xem người đó lời/lỗ bao nhiêu tiền. 
             * Biết 1 lần chơi tốn $10, thắng khó 1 lần nhận thưởng gấp 3 lần tiền chơi, 
             * thắng mức trung bình 1 lần nhận thưởng bằng tiền chơi, 
             * thắng dễ 1 lần nhận thưởng bằng 1 nửa tiền chơi
             */

            bool continue_play = true;
            int luot_thang = 0, tong_luot_choi = 0;
            int level = 1;
            int so_lan_doan = 0;
            int so_tien = 0;
            do
            {
                tong_luot_choi++;
                Console.WriteLine("Bạn chơi mức độ nào?");
                Console.WriteLine("1 - Dễ: bạn có 9 lượt đoán");
                Console.WriteLine("2 - Trung bình: bạn có 6 lượt đoán");
                Console.WriteLine("3 - Khó: bạn có 4 lượt đoán");
                level = int.Parse(Console.ReadLine());
                if (level == 1)
                    so_lan_doan = 9;
                else if (level == 2)
                    so_lan_doan = 6;
                else
                    so_lan_doan = 4;
                Random rnd = new Random();
                int com_num = rnd.Next(100) + 1;
                for (int i = 0; i < so_lan_doan; i++)
                {
                    Console.WriteLine("Bạn đoán số mấy?");
                    int user_num = int.Parse(Console.ReadLine());

                    if (user_num == com_num)
                    {
                        luot_thang++;
                        Console.WriteLine("Bravol! Bạn là thiên tài.");
                        Console.WriteLine($"Bạn đã đoán đúng sau {i + 1} lượt chơi");
                        if (so_lan_doan == 9)
                            so_tien = 10 / 2;
                        else if (so_lan_doan == 6)
                            so_tien = 10;
                        else
                            so_tien = 10 * 3;
                        Console.WriteLine($"Bạn nhận được {so_tien} nghìn đồng tiền thưởng ");
                        break;
                    }
                    else if (user_num < com_num)
                    {
                        Console.WriteLine("Số bạn đoán nhỏ hơn số máy nghĩ");
                    }
                    else
                    {
                        Console.WriteLine("Số bạn đoán lơn hơn số máy nghĩ");
                    }
                }
                Console.WriteLine($"Số máy nghĩ ra là: {com_num}");
                Console.WriteLine("bạn dám chơi nữa không?");
                Console.WriteLine("Bấm phím c nếu muốn tiếp tục");
                Console.WriteLine("Bấm phím k nếu không muốn tiếp tục");
                string tra_loi = Console.ReadLine();
                if (tra_loi.ToLower() == "k")
                    continue_play = false;
            } while (continue_play);
        }
        public static void Main456 (string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Game_doan_so ();
        }
    }
}
