using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_4
{
    internal class Task_4_3_5
    {
        public static void FullFillMonths()
        {
            var months = new List<string>()
            {
                "Jan", "Feb", "Mar", "Apr", "May"
            };
            var missing = new ArrayList()
            {
                1, 2, 3, 5, "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };

            var missingMonths = new string[7];
            missing.GetRange(4, 7).CopyTo(missingMonths);
            months.AddRange(missingMonths);

            foreach (var month in months)
            {
                Console.WriteLine(month);
            }
        }
    }
}
