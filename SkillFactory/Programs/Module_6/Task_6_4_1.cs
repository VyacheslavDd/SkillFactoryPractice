using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_6
{
    public class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    public class Employee
    {
        public int DepartmentId { get; set; }
        public string? Name { get; set; }
        public int Id { get; set; }
    }

    internal class Task_6_4_1
    {
        public static void JoinEmployeesWithDepartments()
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
            var newEmployees = employees.Join(departments, e => e.DepartmentId, d => d.Id, (e, d) => new
            {
                Name = e.Name,
                DepartmentName = d.Name
            });
            foreach (var employee in newEmployees)
                Console.WriteLine($"{employee.Name} работает в отделе {employee.DepartmentName}");
        }
    }
}
