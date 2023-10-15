using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkillFactory.Programs.Module_5;

namespace SkillFactory.Programs.Module_6
{

    internal class Task_6_3_3
    {
        public static void ContactsGroupingTask()
        {
            var phoneBook = new List<Contact>();
            phoneBook.Add(new Contact("Игорь", "1", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "1", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "1", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "1", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "1", 799900000013, "serg@gmail.com"));
            phoneBook.Add(new Contact("Иннокентий", "1", 799900000013, "innokentii@example.com"));

            var groupedPhones = phoneBook.GroupBy(contact => contact.Email.Contains("example"));
            foreach (var group in groupedPhones)
            {
                Console.WriteLine(group.Key ? "Фейковые:" : "Настоящие:");
                foreach (var contact in group)
                    Console.WriteLine(contact.Name);
            }
        }
    }
}
