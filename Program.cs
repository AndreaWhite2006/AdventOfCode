﻿using System;
using System.IO;

namespace AdventOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            using (StreamReader sr = new StreamReader("input.txt"))
            {
                string[] words = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
                string[] RevWords = { "eno", "owt", "eerht", "ruof", "evif", "xis", "neves", "thgie", "enin" };
                string[] digits = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string Number = "";
                    string Numeric = "";
                    bool foundword = false;
                    for (int i = 0; i < line.Length; i++)
                    {
                        Number += line[i];
                        for (int j = 0; j < words.Length; j++)
                        {
                            if (Number.Contains(words[j]))
                            {
                                Numeric += digits[j];
                                foundword = true;
                                break;
                            }
                        }
                        if (foundword)
                        {
                            break;
                        }
                        if (char.IsDigit(line[i]))
                        {
                            Numeric += line[i];
                            break;
                        }
                    }

                    Number = "";
                    foundword = false;

                    for (int i = )
                    {
                        Number += line[i];
                        for (int j = 0; j < words.Length; j++)
                        {
                            if (Number.Contains(words[j]))
                            {
                                Numeric += digits[j];
                                foundword = true;
                                break;
                            }
                        }
                        if (foundword)
                        {
                            break;
                        }
                        if (char.IsDigit(line[i]))
                        {
                            Numeric += line[i];
                            break;
                        }
                    }

                    if (Numeric.Length == 2)
                    {
                        string Num = "";
                        Num += Numeric[0];
                        Num += Numeric[1];
                        Console.WriteLine(Num);
                        total += int.Parse(Num);
                    }
                    else
                    {
                        string Num = "";
                        Num += Numeric[0];
                        Num += Numeric[0];
                        Console.WriteLine(Num);
                        total += int.Parse(Num);

                    }
                }
            }
            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}

