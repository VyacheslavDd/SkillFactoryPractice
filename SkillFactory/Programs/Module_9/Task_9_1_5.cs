using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_9
{
    abstract class BaseClass
    {
        protected int id;

        public BaseClass(int id)
        {
            this.id = id;
        }

        public void GetId()
        {
            Console.WriteLine($"Создан объект с Id {id}");
        }

        public abstract BaseClass Clone();
    }

    class ImplementationOne : BaseClass
    {
        public ImplementationOne(int id) : base(id) { }

        public override BaseClass Clone()
        {
            return new ImplementationOne(id);
        }
    }

    class ImplementationTwo : BaseClass
    {
        public ImplementationTwo(int id) : base(id) { }

        public override BaseClass Clone()
        {
            return new ImplementationTwo(id);
        }
    }

    internal class Task_9_1_5
    {
        public static void PrototypePatternTask()
        {
            BaseClass myObject = new ImplementationOne(1);
            myObject.GetId();

            BaseClass clone = myObject.Clone();
            clone.GetId();

            myObject = new ImplementationTwo(2);
            myObject.GetId();

            clone = myObject.Clone();
            clone.GetId();
        }
    }
}
