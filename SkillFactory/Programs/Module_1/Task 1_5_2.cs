using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_1
{
    internal class Task_1_5_2
    {
        private static long IterateDirectories(DirectoryInfo[] dirs)
        {
            long size = 0;
            foreach (var subDir in dirs)
            {
                try
                {
                    size += GetDirectorySize(subDir.FullName);
                }
                catch
                {
                    continue;
                }
            }
            return size;
        }

        private static long IterateFiles(FileInfo[] files)
        {
            long size = 0;
            foreach (var subFile in files)
            {
                try
                {
                    size += subFile.Length;
                }
                catch
                {
                    continue;
                }
            }
            return size;
        }

        public static long GetDirectorySize(string url)
        {
            long size = 0;

            var dirInfo = new DirectoryInfo(url);
            var subDirs = dirInfo.GetDirectories();
            var subFiles = dirInfo.GetFiles();

            size += IterateDirectories(subDirs);
            size += IterateFiles(subFiles);

            return size;
        }
    }
}
