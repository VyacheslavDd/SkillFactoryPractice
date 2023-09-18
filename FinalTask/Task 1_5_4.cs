using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask;

[Serializable]
public class Student
{
    public string? Name { get; set; }
    public string? Group { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Student(string name, string group, DateTime birthDate)
    {
        Name = name;
        Group = group;
        DateOfBirth = birthDate;
    }
}

internal class Task_1_5_4
{
    private static string dirPath = "C:\\Users\\Slava\\Desktop\\Students";

    private static DirectoryInfo CreateStudentsDirectory()
    {
        var dir = new DirectoryInfo(dirPath);
        if (!dir.Exists)
            dir.Create();
        return dir;
    }

    private static Student[] GetStudents()
    {
        var formatter = new BinaryFormatter();

        using (FileStream fs = File.Open("C:\\skill\\SkillFactoryPractice\\SkillFactory\\Additional files\\Students.dat", FileMode.Open))
        {
            var students = (Student[])formatter.Deserialize(fs);
            return students;
        }
    }

    private static void ParseStudents(Student[] students)
    {
        foreach (var student in students)
        {
            var filePath = dirPath + $"\\{student.Group}.txt";

            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine($"{student.Name}, {student.DateOfBirth}");
            }
        }
    }

    public static void ParseStudentsData()
    {
        CreateStudentsDirectory();
        var students = GetStudents();
        ParseStudents(students);
    }
}
