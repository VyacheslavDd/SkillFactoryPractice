using Microsoft.Data.SqlClient;
using Module11ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11ConsoleAppPractice
{
    public class App
    {
        private Manager manager;

        public App()
        {
            manager = new Manager();
        }

        private void AskLoginDeletion()
        {
            Console.WriteLine("Введите логин для удаления: ");
            var login = Console.ReadLine();
            var result = manager.DeleteUserByLogin(login);
            if (result > 0)
            {
                Console.WriteLine($"Было удалено {result} строк!");
                manager.ShowData();
            }
            else
            {
                Console.WriteLine("Не было удалено ничего...");
            }
        }

        public void Run()
        {
            manager.Connect();
            manager.Disconnect();
        }
    }
}
