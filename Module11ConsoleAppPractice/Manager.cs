using Module11ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11ConsoleAppPractice
{
    public class Manager
    {
        private MainConnector connector;
        private DbExecuter dbExecuter;
        private UserTable table;

        public Manager()
        {
            connector = new MainConnector();
            dbExecuter = new DbExecuter(connector);
            table = new UserTable();
            table.Name = "NetworkUser";
            table.Fields = new List<string>() { "Id", "Name", "Login" };
            table.ImportantField = "Login";
        }

        public void Connect()
        {
            var result = connector.ConnectAsync();
            if (!result.Result)
            {
                throw new Exception("Не удалось подключиться к базе данных!");
            }
            Console.WriteLine("Подключились к базе данных!");
        }

        public void Disconnect()
        {
            connector.DisconnectAsync();
        }

        public void ShowData()
        {
            var reader = dbExecuter.SelectAll(table.Name);
            SqlTableReader.PrintTable(reader);
        }

        public int DeleteUserByLogin(string value)
        {
            return dbExecuter.DeleteByColumn(table.Name, table.ImportantField, value);
        }

        public int UpdateUserByLogin(string value, string newValue)
        {
            return dbExecuter.UpdateByColumn(table.Name, table.Fields[1], table.Fields[2], value, newValue);
        }

        public int AddUser(string name, string login)
        {
            return dbExecuter.InsertNewUser(name, login);
        }
    }
}
