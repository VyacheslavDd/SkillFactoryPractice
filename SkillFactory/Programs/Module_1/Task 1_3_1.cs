using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_1
{
    internal class Task_1_3_1
    {
        public static void ReadSourceCode()
        {
            try
            {
                var file = new FileInfo("C:\\skill\\SkillFactory\\Programs\\Task 1_3_1.cs");

                using (StreamReader sr = file.OpenText())
                {
                    while (true)
                    {
                        var line = sr.ReadLine();
                        if (line == null) break;
                        Console.WriteLine(line);
                    }
                }

                using (StreamWriter sw = file.AppendText())
                {
                    sw.WriteLine($"//{DateTime.Now}");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
//17.09.2023 23:17:15
//17.09.2023 23:17:26
//17.09.2023 23:18:04
//17.09.2023 23:18:33
