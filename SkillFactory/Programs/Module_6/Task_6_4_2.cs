using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkillFactory.Programs.Module_6;

namespace SkillFactory.Programs.Module_6
{
    internal class Task_6_4_2
    {
        public static void JoinEmployeesDepartmentsWithGrouping()
        {
            var departments = new List<Department>()
           {
               new Department() {Id = 1, Name = "Программирование"},
               new Department() {Id = 2, Name = "Продажи"}
           };

            var employees = new List<Employee>()
            {
                new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
                new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
                new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
                new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
            };

            var groupedEmployees = departments.GroupJoin(employees, d => d.Id, e => e.DepartmentId, (d, e) => new
            {
                DepartmentName = d.Name,
                Employees = e.Select(emp => emp.Name)
            });
            foreach (var group in groupedEmployees)
            {
                Console.WriteLine($"Отдел: {group.DepartmentName}");
                foreach (var employee in group.Employees)
                    Console.WriteLine(employee);
            }
        }
    }
}
