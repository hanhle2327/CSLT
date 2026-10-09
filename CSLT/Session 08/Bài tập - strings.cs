using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT.Session_09
{
    internal class Bài_tập_slide
    {
        public static void Main1(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
                // 1. Input a string and print it
                Console.Write("1. Enter a string: ");
                string inputStr = Console.ReadLine();
                Console.WriteLine($" Output: {inputStr}");

                // 2. Find the length of a string without using a library function
                int length = GetStringLength(inputStr);
                Console.WriteLine($"2. Length of the string (without library function): {length}");

                // 3. Separate individual characters from a string
                Console.Write("3. Individual characters: ");
                PrintIndividualCharacters(inputStr);
                Console.WriteLine("\n");

                // 4. Print individual characters of the string in reverse order
                Console.Write("4. Characters in reverse order: ");
                PrintCharactersReverse(inputStr);
                Console.WriteLine("\n");

                // 5. Count the total number of words in a string
                int wordCount = CountWords(inputStr);
                Console.WriteLine($"5. Total number of words: {wordCount}");

                // 6. Compare two strings without using string library functions
                Console.Write("6. Enter another string to compare with the first: ");
                string compareStr = Console.ReadLine();
                bool areEqual = CompareStrings(inputStr, compareStr);
                Console.WriteLine($"   Are the two strings equal? {areEqual}");

                // 7. Count the number of alphabets, digits, and special characters
                CountAlphabetsDigitsSpecial(inputStr, out int alphabets, out int digits, out int specials);
                Console.WriteLine($"7. Alphabets: {alphabets}, Digits: {digits}, Special Characters: {specials}");

                // 8. Count the number of vowels or consonants in a string
                CountVowelsAndConsonants(inputStr, out int vowels, out int consonants);
                Console.WriteLine($"8. Vowels: {vowels}, Consonants: {consonants}");

                // 9. Check whether a given substring is present
                Console.Write("9. Enter a substring to check presence: ");
                string subString = Console.ReadLine();
                bool isPresent = ContainsSubstring(inputStr, subString);
                Console.WriteLine($"   Is substring present? {isPresent}");

                // 10. Search for the position of a substring within a string
                int position = FindSubstringPosition(inputStr, subString);
                Console.WriteLine($"10. Position of substring (0-indexed, -1 if not found): {position}");

                // 11. Check whether a character is an alphabet and its case
                Console.Write("11. Enter a single character to check case: ");
                char chInput = Console.ReadKey().KeyChar;
                Console.WriteLine();
                CheckAlphabetCase(chInput);
                Console.WriteLine();

                // 12. Find the number of times a substring appears in a given string
                int subCount = CountSubstringOccurrences(inputStr, subString);
                Console.WriteLine($"12. Number of times substring appears: {subCount}");

                // 13. Insert a substring before the first occurrence of a string/substring
                Console.Write("13. Enter a substring to insert before the first occurrence of '{0}': ", subString);
                string insertStr = Console.ReadLine();
                string modifiedStr = InsertBeforeFirstOccurrence(inputStr, subString, insertStr);
                Console.WriteLine($"Modified string: {modifiedStr}");
            }


            // 2. Length without library function
            static int GetStringLength(string str)
            {
                int count = 0;
                foreach (char c in str)
                {
                    count++;
                }
                return count;
            }

            // 3. Separate individual characters
            static void PrintIndividualCharacters(string str)
            {
                for (int i = 0; i < GetStringLength(str); i++)
                {
                    Console.Write($"{str[i]} ");
                }
            }

            // 4. Print characters in reverse order
            static void PrintCharactersReverse(string str)
            {
                int len = GetStringLength(str);
                for (int i = len - 1; i >= 0; i--)
                {
                    Console.Write(str[i]);
                }
            }

            // 5. Count words
            static int CountWords(string str)
            {
                int count = 0;
                bool inWord = false;
                for (int i = 0; i < GetStringLength(str); i++)
                {
                    if (str[i] != ' ' && str[i] != '\t' && str[i] != '\n')
                    {
                        if (!inWord)
                        {
                            inWord = true;
                            count++;
                        }
                    }
                    else
                    {
                        inWord = false;
                    }
                }
                return count;
            }

            // 6. Compare two strings without library functions
            static bool CompareStrings(string s1, string s2)
            {
                int len1 = GetStringLength(s1);
                int len2 = GetStringLength(s2);

                if (len1 != len2) return false;

                for (int i = 0; i < len1; i++)
                {
                    if (s1[i] != s2[i]) return false;
                }
                return true;
            }

            // 7. Count alphabets, digits, and special characters
            static void CountAlphabetsDigitsSpecial(string str, out int alphabets, out int digits, out int specials)
            {
                alphabets = digits = specials = 0;
                foreach (char c in str)
                {
                    if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                    {
                        alphabets++;
                    }
                    else if (c >= '0' && c <= '9')
                    {
                        digits++;
                    }
                    else
                    {
                        specials++;
                    }
                }
            }

            // 8. Count vowels and consonants
            static void CountVowelsAndConsonants(string str, out int vowels, out int consonants)
            {
                vowels = consonants = 0;
                foreach (char c in str)
                {
                    char lower = char.ToLower(c);
                    if (lower >= 'a' && lower <= 'z')
                    {
                        if (lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u')
                        {
                            vowels++;
                        }
                        else
                        {
                            consonants++;
                        }
                    }
                }
            }

            // 10. Search for position of a substring
            static int FindSubstringPosition(string mainStr, string subStr)
            {
                int mainLen = GetStringLength(mainStr);
                int subLen = GetStringLength(subStr);

                if (subLen == 0) return 0;
                if (mainLen < subLen) return -1;

                for (int i = 0; i <= mainLen - subLen; i++)
                {
                    bool match = true;
                    for (int j = 0; j < subLen; j++)
                    {
                        if (mainStr[i + j] != subStr[j])
                        {
                            match = false;
                            break;
                        }
                    }
                    if (match) return i;
                }
                return -1;
            }

            // 9. Check whether substring is present
            static bool ContainsSubstring(string mainStr, string subStr)
            {
                return FindSubstringPosition(mainStr, subStr) != -1;
            }

            // 11. Check alphabet and case
            static void CheckAlphabetCase(char c)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    if (c >= 'A' && c <= 'Z')
                    {
                        Console.WriteLine($"'{c}' is an alphabet and it is UPPERCASE.");
                    }
                    else
                    {
                        Console.WriteLine($"'{c}' is an alphabet and it is lowercase.");
                    }
                }
                else
                {
                    Console.WriteLine($"'{c}' is NOT an alphabet.");
                }
            }

            // Helper for finding substring position starting from a specific index
            static int FindSubstringPositionFrom(string mainStr, string subStr, int startIndex)
            {
                int mainLen = GetStringLength(mainStr);
                int subLen = GetStringLength(subStr);

                if (mainLen - startIndex < subLen) return -1;

                for (int i = startIndex; i <= mainLen - subLen; i++)
                {
                    bool match = true;
                    for (int j = 0; j < subLen; j++)
                    {
                        if (mainStr[i + j] != subStr[j])
                        {
                            match = false;
                            break;
                        }
                    }
                    if (match) return i;
                }
                return -1;
            }

            // 12. Count number of times a substring appears
            static int CountSubstringOccurrences(string mainStr, string subStr)
            {
                int subLen = GetStringLength(subStr);
                if (subLen == 0) return 0;

                int count = 0;
                int index = 0;

                while ((index = FindSubstringPositionFrom(mainStr, subStr, index)) != -1)
                {
                    count++;
                    index += subLen;
                }
                return count;
            }

            // 13. Insert substring before the first occurrence
            static string InsertBeforeFirstOccurrence(string mainStr, string target, string insertStr)
            {
                int pos = FindSubstringPosition(mainStr, target);
                if (pos == -1) return mainStr; // Target not found, return original string

                string result = "";
                int mainLen = GetStringLength(mainStr);

                // Add characters before the target position
                for (int i = 0; i < pos; i++)
                {
                    result += mainStr[i];
                }

                // Add the insert string
                result += insertStr;

                // Add the rest of the original string starting from the target position
                for (int i = pos; i < mainLen; i++)
                {
                    result += mainStr[i];
                }

                return result;
            }
        }
    }

