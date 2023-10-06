using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Collections;

namespace SkillFactory.Programs.Module_4
{
    internal class Task_4_2_6
    {
        public static void ArrayListFromString()
        {
            Console.WriteLine("Введите строки и числа в любом порядке через пробел: ");
            var input = Console.ReadLine();
            var data = input?.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var arrayList = new ArrayList() { 0.0, new StringBuilder() };
            foreach ( var item in data)
            {
                double number = 0;
                if (double.TryParse(item, out number))
                {
                    arrayList[0] = (double?)arrayList[0] + number;
                }
                else
                {
                    var builder = (StringBuilder)arrayList[1];
                    builder.Append(item + " ");
                }
            }
            Console.WriteLine(arrayList[0]);
            Console.WriteLine(arrayList[1].ToString());
        }
    }
}
