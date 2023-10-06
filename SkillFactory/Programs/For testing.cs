using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs
{
    internal class For_testing
    {
        public static void Test()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            foreach (var num in stack)
            {
                Console.WriteLine(num);
            }
        }
    }
}
