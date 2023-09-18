using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_1
{
    internal class Task_1_2_1
    {
        public static void PrintElementsAmount(DirectoryInfo rootDirectory)
        {
            var directoriesCount = rootDirectory.GetDirectories().Length;
            var filesCount = rootDirectory.GetFiles().Length;
            Console.WriteLine($"Диск C содержит {directoriesCount + filesCount} папок и файлов");
        }

        public static void GetDriveElements()
        {
            try
            {
                var rootDirectory = new DirectoryInfo("C:\\").Root;
                PrintElementsAmount(rootDirectory);

                var newDirectory = new DirectoryInfo("C:\\TestTask");
                newDirectory.Create();
                PrintElementsAmount(rootDirectory);

                newDirectory.Delete(true);
                PrintElementsAmount(rootDirectory);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
