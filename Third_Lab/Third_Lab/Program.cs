using System;
using System.IO;


namespace Third_Lab
{
    class MainClass
    {
        class Program
        {
            static void monitor(DirectoryInfo directory, int cursor)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                FileSystemInfo[] files = directory.GetFileSystemInfos();
                for (int i = 0; i < files.Length; i++)
                {
                    if (files[i].GetType() == typeof(FileSystemInfo))
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    if (i == cursor)
                        Console.BackgroundColor = ConsoleColor.Red;
                    else
                        Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(files[i].Name);
                }


            }
            static void Main(string[] args)
            {
                DirectoryInfo Dir = new DirectoryInfo(@"/Users/samat/Desktop/");
                int cursor = 0;
                int n = Dir.GetFileSystemInfos().Length - 1;
                monitor(Dir, cursor);
                bool triger = true;
                while (triger)
                {
                    ConsoleKeyInfo button = Console.ReadKey();
                    switch (button.Key)
                    {
                        case ConsoleKey.UpArrow:
                            cursor--;
                            if (cursor < 0)
                                cursor = n;
                            break;
                        case ConsoleKey.DownArrow:
                            cursor++;
                            cursor = cursor % n;
                            break;
                        case ConsoleKey.Enter:
                            if (Dir.GetFileSystemInfos()[cursor].GetType() == typeof(DirectoryInfo))
                            {
                                Dir = new DirectoryInfo(Dir.GetFileSystemInfos()[cursor].FullName);
                                cursor = 0;
                                n = Dir.GetFileSystemInfos().Length - 1;
                            }
                            else
                            {
                                StreamReader sr = new StreamReader(Dir.GetFileSystemInfos()[cursor].FullName);
                                string s = sr.ReadToEnd();
                                Console.Clear();
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine(s);
                                Console.ReadKey();
                            }
                            break;
                        case ConsoleKey.Backspace:
                            if (Dir.Parent != null)
                            {
                                Dir = Dir.Parent;
                                cursor = 0;
                                n = Dir.GetFileSystemInfos().Length - 1;
                            }
                            break;
                        case ConsoleKey.Escape:
                            triger = false;
                            break;
                        default:
                            break;

                    }
                    monitor(Dir, cursor);
                }
            }
        }
    }
}
