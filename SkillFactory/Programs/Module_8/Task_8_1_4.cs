using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_8
{
    internal class Task_8_1_4
    {
        public static DayOfWeek GetDayOfWeek(int day)
        {
            if (day < 1 || day > 7) throw new InvalidOperationException("День недели должен быть от 1 до 7");
            return (DayOfWeek)day;
        }
    }
}
