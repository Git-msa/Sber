using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class ExpansionDirectorySearch
    {
        public static void ExpDirectorySearch(string pathStart)
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
                    else if (count < i && !parts[i].Contains("*"))
                    {
                        pathSecond = pathSecond + "\\" + parts[i];
                    }
                    else { }
                }
                else if (parts[i] == "*.")
                {
                    pathSecond = pathSecond + "\\" + parts[i];
                }
            }

            SearchFile(pathFirst, parts[parts.Length - 1], pathSecond);

            Console.WriteLine("Поиск завершен.");
        }

        static void SearchFile(string directory, string fileName, string pathSecond)
        {
            try
            {
                foreach (string file in Directory.GetFiles(directory, fileName))
                {
                    if (file.Contains(pathSecond))
                    {
                        string[] parts = file.Split('\\');
                        string a = parts[parts.Length - 2];

                        if (parts[parts.Length - 2] == pathSecond.Replace("\\", null))
                        {
                            Console.WriteLine("Найден файл: " + file);
                            break;
                        }
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
