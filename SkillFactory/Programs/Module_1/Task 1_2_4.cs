using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_1
{
    internal class Task_1_2_4
    {
        public static void MoveFileTask()
        {
            try
            {
                var desktopInfo = new DirectoryInfo("C:\\Users\\Slava\\Desktop");
                var testFolder = new DirectoryInfo("C:\\Users\\Slava\\Desktop\\testFolder");
                if (!testFolder.Exists)
                {
                    testFolder.Create();
                }
                string binPath = "C:\\$RECYCLE.BIN\\testFolder";
                testFolder.MoveTo(binPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
