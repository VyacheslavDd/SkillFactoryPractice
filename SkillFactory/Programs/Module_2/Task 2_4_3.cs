using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_2
{
    public class Parent
    {
        public string? Name { get; set; }
    }

    public class Child : Parent 
    {
    }

    internal class Task_2_4_3
    {
        public static void ContravarianceShowCase()
        {
            var printHumanName = (Parent human) => Console.WriteLine(human.Name);
            var child = new Child() { Name = "Simon" };
            printHumanName(child);
        }
    }
}
