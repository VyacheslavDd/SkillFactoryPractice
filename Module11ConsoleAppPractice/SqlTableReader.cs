using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11ConsoleAppPractice
{
    public static class SqlTableReader
    {
        public static void PrintTable(SqlDataReader reader)
        {
            var columns = new List<string>();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                columns.Add(reader.GetName(i));
            }
            foreach (var column in columns)
            {
                Console.Write(column + "\t");
            }
            Console.WriteLine();
            while (reader.Read())
            {
                for (int i = 0; i < columns.Count; i++)
                {
                    var value = reader[columns[i]];
                    Console.Write(value + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
