using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_4
{
    internal class Task_4_2_5
    {
        public static void ConcatenateDifferentArrays()
        {
            var months = new[]
            {
                "Jan", "Feb", "Mar", "Apr", "May" , "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };

            var numbers = new[]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
            };

            var concatenatedArray = new ArrayList();
            var monthsLength = months.Length;
            for (int i = 0; i < monthsLength; i++)
            {
                concatenatedArray.Add(months[i]);
                concatenatedArray.Add(numbers[i]);
            }
            foreach (var obj in concatenatedArray)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
