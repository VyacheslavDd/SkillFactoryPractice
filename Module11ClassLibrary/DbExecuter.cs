using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11ClassLibrary
{
    public class DbExecuter
    {
        private MainConnector connector;
        public DbExecuter(MainConnector connector)
        {
            this.connector = connector;
        }

        public SqlDataReader SelectAll(string table)
        {
            var selectCommandText = "select * from " + table;
            var command = new SqlCommand()
            {
                CommandType = CommandType.Text,
                CommandText = selectCommandText,
                Connection = connector.GetConnection()
            };
            var reader = command.ExecuteReader();
            if (reader.HasRows)
                return reader;
            return null;
        }

        public int DeleteByColumn(string table, string column, string value)
        {
            var command = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = $"DELETE FROM {table} WHERE {column} = '{value}'",
                Connection = connector.GetConnection()
            };
            var result = command.ExecuteNonQuery();
            return result;
        }

        public int UpdateByColumn(string table, string columnToUpdate, string selectorColumn, string selectorValue, string newValue)
        {
            var command = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = $"UPDATE {table} SET {columnToUpdate} = '{newValue}' WHERE {selectorColumn} = '{selectorValue}';",
                Connection = connector.GetConnection()
            };
            return command.ExecuteNonQuery();
        }

        public int InsertNewUser(string name, string login)
        {
            var command = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = $"AddingUserProc",
                Connection = connector.GetConnection()
            };
            command.Parameters.Add(new SqlParameter("@Name", name));
            command.Parameters.Add(new SqlParameter("@Login", login));
            return command.ExecuteNonQuery();
        }
    }
}
