using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_6
{
    public class Classroom
    {
        public List<string> Students = new List<string>();
    }

    internal class Module_6_Practice_1
    {
        private static string[] GetAllStudents(Classroom[] classes)
        {
            return classes.SelectMany(studList => studList.Students).ToArray();
        }

        public static void GetStudentsTogether()
        {
            var classes = new[]
           {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }
    }
}
