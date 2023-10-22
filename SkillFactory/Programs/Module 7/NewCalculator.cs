using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_7
{
    public class NewCalculator
    {
        public int Addition(params int[] numbers)
        {
            return numbers.Sum();
        }
        public int Multiplication(params int[] numbers)
        {
            return numbers.Aggregate((first, second) => first * second);
        }
    }
}
