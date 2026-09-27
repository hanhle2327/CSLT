using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session_07
{
    internal class BaiTapLMS
    {

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // requests 10 integers from the user and orders them by implementing the bubble sort algorithm.
            int[] numbers = new int[10];
            Console.WriteLine("Sắp xếp nổi bọt (Bubble Sort)");
            Console.WriteLine("Vui lòng nhập 10 số nguyên:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Số thứ {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.Write("Lỗi! Vui lòng nhập một số nguyên hợp lệ: ");
                }
            }

            BubbleSort(numbers);

            Console.WriteLine("\nCác số sau khi sắp xếp (tăng dần):");
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();

            // Request a sentence from the user, then ask to enter a word. Search if the word appears in the phrase using the linear search algorithm
            Console.WriteLine("Tìm kiếm tuyến tính (Linear Search)");
            Console.Write("Nhập một câu: ");
            string sentence = Console.ReadLine() ?? string.Empty;

            Console.Write("Nhập từ cần tìm: ");
            string targetWord = Console.ReadLine() ?? string.Empty;
            int foundIndex = LinearSearchWord(sentence, targetWord);
            if (foundIndex != -1)
            {
                Console.WriteLine($"\nThành công! Tìm thấy từ '{targetWord}' tại vị trí từ thứ {foundIndex + 1} trong câu.");
            }
            else
            {
                Console.WriteLine($"\nKhông tìm thấy từ '{targetWord}' trong câu.");
            }
        }




        // requests 10 integers from the user and orders them by implementing the bubble sort algorithm.
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Hoán đổi giá trị
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        // Request a sentence from the user, then ask to enter a word. Search if the word appears in the phrase using the linear search algorithm
        static int LinearSearchWord(string sentence, string targetWord)
        {
            // Tách câu thành mảng các từ (bỏ qua dấu câu thông dụng)
            char[] delimiters = { ' ', ',', '.', '!', '?', ';', ':' };
            string[] words = sentence.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            // Duyệt tuần tự từng phần tử (Linear Search)
            for (int i = 0; i < words.Length; i++)
            {
                // So sánh không phân biệt hoa thường
                if (string.Equals(words[i], targetWord, StringComparison.OrdinalIgnoreCase))
                {
                    return i; // Trả về vị trí tìm thấy
                }
            }

            return -1; // Không tìm thấy
        }
    }
}

