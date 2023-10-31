using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_9
{
    class Product
    {
        private string _type;

        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        public Product(string type)
        {
            _type = type;
        }

        public string this[string key]
        {
            set
            {
                _parts[key] = value;
            }
        }

        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine($"Вид транспортного средства: {_type}");
            Console.WriteLine($" Рама : {_parts["frame"]}"); Console.WriteLine($" Двигатель : {_parts["engine"]}");
            Console.WriteLine($" Колеся: {_parts["wheels"]}");
            Console.WriteLine($" Двери : {_parts["doors"]}");
        }
    }

    abstract class Conveyor
    {
        protected Product _product;

        public Product Product
        {
            get { return _product; }
            set
            {
                _product = value;
            }
        }

        public abstract void CreateProduct();

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }

    class CarPlant
    {
        public Product Construct(Conveyor conveyor)
        {
            conveyor.CreateProduct();
            conveyor.BuildFrame();
            conveyor.BuildEngine();
            conveyor.BuildWheels();
            conveyor.BuildDoors();

            return conveyor.Product;
        }
    }

    class CarConveyor : Conveyor
    {
        public override void CreateProduct()
        {
            Product = new Product("Автомобиль");
        }

        public override void BuildFrame()
        {
            Product["frame"] = "Рама автомобиля";
        }

        public override void BuildEngine()
        {
            Product["engine"] = "150 л.с.";
        }

        public override void BuildDoors()
        {
            Product["doors"] = "4";
        }

        public override void BuildWheels()
        {
            Product["wheels"] = "4";
        }
    }

    class MotoConveyor : Conveyor
    {
        public override void CreateProduct()
        {
            Product = new Product("Мотоцикл");
        }
        public override void BuildFrame()
        {
            Product["frame"] = "Рама мотоцикла";
        }

        public override void BuildEngine()
        {
            Product["engine"] = "70 л.с.";
        }

        public override void BuildDoors()
        {
            Product["doors"] = "0";
        }

        public override void BuildWheels()
        {
            Product["wheels"] = "2";
        }
    }

    class ScooterConveyor : Conveyor
    {
        public override void CreateProduct()
        {
            Product = new Product("Скутер");
        }
        public override void BuildFrame()
        {
            Product["frame"] = "Рама скутера";
        }

        public override void BuildEngine()
        {
            Product["engine"] = "25 л.с.";
        }

        public override void BuildDoors()
        {
            Product["doors"] = "0";
        }

        public override void BuildWheels()
        {
            Product["wheels"] = "2";
        }
    }

    internal class Task_9_1_1
    {
        public static void BuilderPatternTask()
        {
            var builder = new CarPlant();
            var car = builder.Construct(new CarConveyor());
            var moto = builder.Construct(new MotoConveyor());
            var scooter = builder.Construct(new ScooterConveyor());
            car.Show();
            moto.Show();
            scooter.Show();
        }
    }
}
