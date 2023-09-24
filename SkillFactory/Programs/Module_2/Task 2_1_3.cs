using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_2
{
    internal class Task_2_1_3
    {
        public static void ChangeDataProperty()
        {
            var newException = new Exception();
            newException.Data?.Add("date", DateTime.Now);
            Console.WriteLine(newException.Data);
        }
    }
}
