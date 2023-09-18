using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_1
{
    [Serializable]
    public class Contact
    {
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(string name, long phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }

    internal class Task_1_4_3
    {
        public static void SerializeContact()
        {
            var myContact = new Contact("Vyacheslav", 89920159570, "Sonic.x.exe@yandex.ru");
            var formatter = new BinaryFormatter();

            var newFile = new FileInfo("C:\\skill\\SkillFactory\\Additional files\\Contact.bin");
            using (FileStream fs = newFile.OpenWrite())
            {
                formatter.Serialize(fs, myContact);
            }
        }
    }
}
