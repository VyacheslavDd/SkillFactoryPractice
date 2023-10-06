using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_4
{
    public class Contact1 // модель класса
    {
        public Contact1(long phoneNumber, string email) // метод-конструктор
        {
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public long PhoneNumber { get; }
        public string Email { get; }
    }

    internal class Task_4_4_4
    {
        public static void NewContactsPresentation()
        {
            var contacts = new SortedDictionary<string, Contact1>();
            contacts.Add("xd", new Contact1(89220159570, "xd.email"));
            contacts.Add("me", new Contact1(99201956077, "m"));
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }
    }
}
