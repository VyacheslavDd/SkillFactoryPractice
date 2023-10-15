using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_5
{
    internal class Task_5_1_8
    {
        private static void Task_1(List<object> objects)
        {
            var names = from obj in objects where obj.GetType() == typeof(string) orderby obj select obj;
            foreach (var name in names) Console.WriteLine(name);
        }

        private static void Task_2(List<object> objects)
        {
            var names = objects.Where(obj => obj.GetType() == typeof(string)).OrderBy(obj => obj);
            foreach (var name in names) Console.WriteLine(name);
        }

        public static void NamesPractice()
        {
            var objects = new List<object>()
            {
               1,
               "Сергей ",
               "Андрей ",
               300,
            };
            Task_1(objects);
            Task_2(objects);
        }
    }
}
