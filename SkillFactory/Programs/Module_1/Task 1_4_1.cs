using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_1
{
    internal class Task_1_4_1
    {
        public static void ReadFileData()
        {
            var file = new FileInfo("C:\\skill\\SkillFactory\\Additional files\\BinaryFile.bin");
            using (BinaryWriter bw = new BinaryWriter(file.OpenWrite()))
            {
                var date = file.LastAccessTime;
                bw.Write($"Файл изменён {date.Day}.{date.Month} в {date.Hour}:{date.Minute} на ОС Windows 10");
            }

            using (BinaryReader br = new BinaryReader(file.OpenRead()))
            {
                Console.WriteLine(br.ReadString());
            }
        }
    }
}
