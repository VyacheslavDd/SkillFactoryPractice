using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_2
{
    internal class Task_2_6_2
    {

        public static event Action<List<string>, int> SortOperation;

        public static void SortEvent()
        {
            try
            {
                var people = new List<string>() { "Мария", "Вячеслав", "Сергей", "Данил", "Екатерина" };
                Console.WriteLine("Введите 1 для сортировки имён А-Я, или введите 2 для сортировки Я-А");
                var number = int.Parse(Console.ReadLine());
                SortOperation += SortPeopleOnParameterEnter;
                SortOperation(people, number);
                
                foreach (var name in people)
                {
                    Console.WriteLine(name);
                }
            }
            catch (Exception ex) when (ex.GetType() == new ArgumentException().GetType() || ex.GetType() == new FormatException().GetType())
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void SortPeopleOnParameterEnter(List<string> people, int parameter)
        {
            switch (parameter)
            {
                case 1:
                    people.Sort();
                    break;
                case 2:
                    people.Sort();
                    people.Reverse();
                    break;
                default:
                    throw new ArgumentException("Некорректно введённый параметр сортировки!");
            }
        }
    }   
}
