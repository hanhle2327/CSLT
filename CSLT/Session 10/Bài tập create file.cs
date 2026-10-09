using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session_10
{
    internal class Bài_tập_create_file
    {
        public static void Main(string[] args)
        {
            string sampleFile = "sample.txt";
            string targetDir = "./TestFolder";

            // 1. Create a blank file on the disk
             CreateBlankFile("blank.txt");

            // 2. Remove a file from the disk
            RemoveFile("blank.txt");

            // 3. Create a file and add some text
            CreateAndAddText(sampleFile, "Hello, My name's Hano\nWelcome to MY CHANEL.");

            // 4. Create a text file and read it
            ReadTextFile(sampleFile);

            // 5. Create a file and write an array of strings to the file
            string[] linesArray = { "My name is Hạnh", "I'm 20 years old", "I'm studying at UEH" };
            WriteArrayOfStrings("array_file.txt", linesArray);

            // 6. Append some text to an existing file
            AppendText(sampleFile, "\nThis is appended text.");

            // 7. Create and copy the file to another name and display the content
            CopyAndDisplay(sampleFile, "sample_copy.txt");

            // 8. Create a file and move it into the same directory with another name
            CreateAndMoveFile("temp_move.txt", "temp_renamed.txt");

            // 9. Read the first line of a file
            ReadFirstLine("array_file.txt");

            // 10. Create and read the last line of a file
            ReadLastLine("array_file.txt");

            // 11. Create and read the last n lines of a file
            ReadLastNLines("array_file.txt", 2);

            // 12. Read a specific line from a file (0-indexed)
            ReadSpecificLine("array_file.txt", 2);

            // 13. Count the number of lines in a file
            CountLines("array_file.txt");

            // 14. Print the structure of specific folder (include files)
            SetupTestDirectory(targetDir);
            Console.WriteLine("Directory Structure:");
            PrintFolderStructure(targetDir, "");

            // 15. Statistics of characters/numbers using rectangular and jagged arrays
            Console.WriteLine("\nCharacter and Number Statistics:");
            FileStatistics(sampleFile);
        }


        static void CreateBlankFile(string path)
        {
            File.Create(path).Close();
            Console.WriteLine($"1. Created blank file: {path}");
        }

        static void RemoveFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine($"2. Removed file: {path}");
            }
        }

        static void CreateAndAddText(string path, string text)
        {
            File.WriteAllText(path, text);
            Console.WriteLine($"3. Created file '{path}' and added text.");
        }

        static void ReadTextFile(string path)
        {
            string content = File.ReadAllText(path);
            Console.WriteLine($"4. Reading '{path}':\n--- Content ---\n{content}\n--------------");
        }

        static void WriteArrayOfStrings(string path, string[] lines)
        {
            File.WriteAllLines(path, lines);
            Console.WriteLine($"5. Wrote an array of strings to '{path}'.");
        }

        static void AppendText(string path, string textToAppend)
        {
            File.AppendAllText(path, textToAppend);
            Console.WriteLine($"6. Appended text to '{path}'. Updated content:\n{File.ReadAllText(path)}");
        }

        static void CopyAndDisplay(string sourcePath, string destPath)
        {
            File.Copy(sourcePath, destPath, true);
            Console.WriteLine($"7. Copied '{sourcePath}' to '{destPath}'. Content of copy:");
            Console.WriteLine(File.ReadAllText(destPath));
        }

        static void CreateAndMoveFile(string tempPath, string newPath)
        {
            File.WriteAllText(tempPath, "Temporary content for moving.");
            if (File.Exists(newPath)) File.Delete(newPath);
            File.Move(tempPath, newPath);
            Console.WriteLine($"8. Created '{tempPath}' and moved/renamed it to '{newPath}'.");
        }

        static void ReadFirstLine(string path)
        {
            string firstLine = File.ReadLines(path).FirstOrDefault();
            Console.WriteLine($"9. First line of '{path}': {firstLine}");
        }

        static void ReadLastLine(string path)
        {
            string lastLine = File.ReadLines(path).LastOrDefault();
            Console.WriteLine($"10. Last line of '{path}': {lastLine}");
        }

        static void ReadLastNLines(string path, int n)
        {
            var lastNLines = File.ReadLines(path).TakeLast(n);
            Console.WriteLine($"11. Last {n} lines of '{path}':");
            foreach (var line in lastNLines)
            {
                Console.WriteLine($"    {line}");
            }
        }

        static void ReadSpecificLine(string path, int lineIndex)
        {
            string line = File.ReadLines(path).ElementAtOrDefault(lineIndex);
            Console.WriteLine($"12. Line at index {lineIndex} of '{path}': {line}");
        }

        static void CountLines(string path)
        {
            int count = File.ReadLines(path).Count();
            Console.WriteLine($"13. Total number of lines in '{path}': {count}");
        }

        static void SetupTestDirectory(string dirPath)
        {
            Directory.CreateDirectory(dirPath);
            File.WriteAllText(Path.Combine(dirPath, "file1.txt"), "Root file 1");
            Directory.CreateDirectory(Path.Combine(dirPath, "SubFolder"));
            File.WriteAllText(Path.Combine(dirPath, "SubFolder", "file2.txt"), "Sub folder file 2");
        }

        static void PrintFolderStructure(string dirPath, string indent)
        {
            DirectoryInfo dir = new DirectoryInfo(dirPath);
            Console.WriteLine($"{indent}[Folder] {dir.Name}");

            foreach (var file in dir.GetFiles())
            {
                Console.WriteLine($"{indent}   - [File] {file.Name}");
            }

            foreach (var subDir in dir.GetDirectories())
            {
                PrintFolderStructure(subDir.FullName, indent + "   ");
            }
        }

        static void FileStatistics(string path)
        {
            string[] lines = File.ReadAllLines(path);

            // 1. Frequency calculation using a Rectangular Array (2D Array: ASCII character code vs Count)
            int[,] freqRectArray = new int[256, 2];
            for (int i = 0; i < 256; i++)
            {
                freqRectArray[i, 0] = i; // ASCII code
                freqRectArray[i, 1] = 0; // Count
            }

            // 2. Position tracking using a Jagged Array (Jagged array to store arrays of position coordinates [line, col])
            // To keep it simple, we store a list of positions for each ASCII character index, then convert to jagged array.
            List<int[]>[] positionLists = new List<int[]>[256];
            for (int i = 0; i < 256; i++) positionLists[i] = new List<int[]>();

            for (int lineIdx = 0; lineIdx < lines.Length; lineIdx++)
            {
                string line = lines[lineIdx];
                for (int colIdx = 0; colIdx < line.Length; colIdx++)
                {
                    char c = line[colIdx];
                    int ascii = (int)c;
                    if (ascii < 256)
                    {
                        freqRectArray[ascii, 1]++;
                        positionLists[ascii].Add(new int[] { lineIdx + 1, colIdx + 1 }); // 1-based line, col
                    }
                }
            }

            // Convert lists of positions to a Jagged Array structure for final querying/display
            int[][][] positionJaggedArray = new int[256][][];
            for (int i = 0; i < 256; i++)
            {
                positionJaggedArray[i] = positionLists[i].ToArray();
            }

            // Display results for characters/numbers that appeared at least once
            Console.WriteLine("    [Character / Number Frequency & Positions]");
            for (int i = 0; i < 256; i++)
            {
                int count = freqRectArray[i, 1];
                if (count > 0 && !char.IsControl((char)i))
                {
                    char c = (char)freqRectArray[i, 0];
                    Console.Write($"    Char '{c}' (ASCII {i}): Count = {count} | Positions: ");

                    // Read from Jagged Array
                    foreach (var pos in positionJaggedArray[i])
                    {
                        Console.Write($"(Line {pos[0]}, Col {pos[1]}) ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
