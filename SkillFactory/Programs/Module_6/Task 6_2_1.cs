using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_6
{
    internal class Task_6_2_1
    {
        public static void Factorial(int number)
        {
            var array = new long[number];
            for (int i = 0; i < number; i++)
                array[i] = i + 1;

            long result = array.Aggregate((x, y) => x * y);
            Console.WriteLine(result);
        }
    }
}
