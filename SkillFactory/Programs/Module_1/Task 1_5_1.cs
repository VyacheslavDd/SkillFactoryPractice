using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_1
{
    internal class Task_1_5_1
    {
        private static void DoClearing(DirectoryInfo[] subDirectories, FileInfo[] subFiles)
        {
            foreach (var subDir in subDirectories)
            {
                try
                {
                    if ((DateTime.Now - subDir.LastWriteTime) > TimeSpan.FromMinutes(30)) subDir.Delete(true);
                }
                catch
                {
                    Console.WriteLine($"{subDir.FullName}: запрещён доступ");
                }
            }

            foreach (var subFile in subFiles)
            {
                try
                {
                    if ((DateTime.Now - subFile.LastWriteTime) > TimeSpan.FromMinutes(30)) subFile.Delete();
                }
                catch
                {
                    Console.WriteLine($"{subFile.FullName}: запрещён доступ");
                }
            }
        }

        public static void ClearDirectory()
        {
            try
            {
                Console.WriteLine("Укажите путь до папки:");
                var path = Console.ReadLine();
                var directory = new DirectoryInfo(path);

                if (!directory.Exists)
                {
                    throw new Exception("Данная директория не существует!");
                }

                var startSize = Task_1_5_2.GetDirectorySize(path);
                Console.WriteLine($"Исходный размер папки: {startSize} байт");

                var subDirectories = directory.GetDirectories();
                var subFiles = directory.GetFiles();
                DoClearing(subDirectories, subFiles);

                var currentSize = Task_1_5_2.GetDirectorySize(path);
                Console.WriteLine($"Освобождено {startSize - currentSize} байт");
                Console.WriteLine($"Текущий размер папки: {currentSize} байт");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
