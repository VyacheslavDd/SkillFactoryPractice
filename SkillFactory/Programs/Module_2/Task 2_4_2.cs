using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_2
{
    public class Car
    {
        public string? Model { get; set; }
        public Color Color { get; set; }

        public Car(string? model, Color color) 
        { 
            Model = model;
            Color = color;
        }
    }

    public class Lexus : Car
    {
        public int MaxSpeed { get; set; }

        public Lexus(string? model, Color color, int maxSpeed) : base(model, color)
        {
            MaxSpeed = maxSpeed;
        }
    }

    internal class Task_2_4_2
    {
        public static void CovarianceShowCase()
        {
            var getCar = () => new Lexus("NULL", Color.Black, 300);
            Car car = getCar();
            Console.WriteLine(car.Model);
        }
    }
}
