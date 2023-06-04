using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class SimpleDirectorySearch
    {
        public static void DirectorySearch(string pathStart)
        {
            string[] parts = pathStart.Split('\\');

            string pathFirst = null;
            string pathSecond = null;
            int count = 0;

            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i] != "*" && parts[i] != "**")
                {
                    if (count == i)
                    {
                        pathFirst = pathFirst + parts[i] + "\\";
                        count++;
                    }
                    else if (count < i)
                    {
                        pathSecond = pathSecond + "\\" + parts[i];
                    }
                    else { }
                }
            }

            SearchFile(pathFirst, parts[parts.Length - 1], pathSecond);

            Console.WriteLine("Поиск завершен.");
            Console.ReadLine();
        }

        static void SearchFile(string directory, string fileName, string pathSecond)
        {
            try
            {
                foreach (string file in Directory.GetFiles(directory, fileName))
                {
                    if (file.Contains(pathSecond))
                    {
                        Console.WriteLine("Найден файл: " + file);
                        break;
                    }
                }

                foreach (string subdirectory in Directory.GetDirectories(directory))
                {
                    SearchFile(subdirectory, fileName, pathSecond);
                }
            }
            catch (UnauthorizedAccessException)
            {
            }
            catch (DirectoryNotFoundException)
            {
            }
        }
    }
}
