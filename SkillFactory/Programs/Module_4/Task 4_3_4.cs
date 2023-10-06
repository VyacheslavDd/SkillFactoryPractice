using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_4
{
    public static class ListExtensions
    {
        public static void AddUnique(this List<Contact> phoneBook, Contact contact)
        {
            foreach (var contact_ in phoneBook)
            {
                if (contact_.Name == contact.Name && contact_.PhoneNumber == contact.PhoneNumber && contact_.Email == contact.Email)
                {
                    Console.WriteLine("Такой контакт уже существует!");
                    return;
                }
            }
            phoneBook.Add(contact);
            var orderedPhones = phoneBook.OrderBy(x => x.Name).ToList();
            foreach (var contact_ in orderedPhones)
            {
                Console.WriteLine($"{contact_.Name}, {contact_.PhoneNumber}, {contact_.Email}");
            }
        }
    }

    public class Contact // модель класса
    {
        public Contact(string name, long phoneNumber, String email) // метод-конструктор
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public String Name { get; }
        public long PhoneNumber { get; }
        public String Email { get; }
    }

    internal class Task_4_3_4
    {
        public static void PhoneBookTask()
        {
            var phoneBook = new List<Contact>()
            {
                new Contact("xd", 89920159570, "xd@email.com")
            };
            phoneBook.AddUnique(new Contact("mxd", 89920159570, "xd@email.com"));
        }
    }
}
