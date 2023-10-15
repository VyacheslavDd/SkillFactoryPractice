using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_5
{
    internal class Task_5_3_5
    {
        private class Contact
        {
            public string? Name { get; set; }
            public long Phone { get; set; }
        }

        public static void ContactsTask()
        {
            var contacts = new List<Contact>()
            {
               new Contact() { Name = "Андрей", Phone = 7999945005 },
               new Contact() { Name = "Сергей", Phone = 799990455 },
               new Contact() { Name = "Иван", Phone = 79999675 },
               new Contact() { Name = "Игорь", Phone = 8884994 },
               new Contact() { Name = "Анна", Phone = 665565656 },
               new Contact() { Name = "Василий", Phone = 3434 }
            };
            while (true)
            {
                var number = int.Parse(Console.ReadLine());
                if (number <= 0 || number > contacts.Count / 2) break;
                var takenContacts = contacts.Skip(2 * (number - 1)).Take(2);
                foreach (var contact in takenContacts) Console.WriteLine($"{contact.Name} - {contact.Phone}");
            }
        }
    }
}
