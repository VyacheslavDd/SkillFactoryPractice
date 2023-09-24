using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_2
{
    internal class Task_2_1_4
    {
        public static void ChangeProperties()
        {
            var exception = new Exception("This is an unknown exception");
            exception.HelpLink = "www.idk.com";
            Console.WriteLine(exception.Message + $", consult this at {exception.HelpLink}");
        }
    }
}
