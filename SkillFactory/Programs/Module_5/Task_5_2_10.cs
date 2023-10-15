using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_5
{
    public class Contact
    {
        public Contact(string name, string lastName, long phoneNumber, string email) 
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public string Name { get; }
        public string LastName { get; }
        public long PhoneNumber { get; }
        public string Email { get; }
    }

    internal class Task_5_2_10
    {
        private static void PhoneBookCycle(List<Contact> phoneBook)
        {
            var pages = phoneBook.Count / 2;
            while (true)
            {
                Console.WriteLine($"Введите страницу контактов (1-{pages})");
                var isNumber = int.TryParse(Console.ReadKey().KeyChar.ToString(), out int pageIndex);
                Console.Clear();
                if (isNumber && pageIndex >= 1 && pageIndex <= pages)
                {
                    var contacts = phoneBook
                        .Skip(2 * (pageIndex - 1))
                        .Take(2)
                        .OrderBy(contact => contact.Name)
                        .ThenBy(contact => contact.LastName);
                    foreach (var contact in contacts)
                        Console.WriteLine($"{contact.Name} {contact.LastName}, Почта: {contact.Email}, Номер: {contact.PhoneNumber}");
                }
                else
                    Console.WriteLine("Некорректное введённое значение. Повторите попытку.");
            }
        }

        public static void PhoneBookTask()
        {
            var phoneBook = new List<Contact>();
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            PhoneBookCycle(phoneBook);
        }
    }
}
