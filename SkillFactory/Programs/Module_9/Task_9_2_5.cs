using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_9
{
    interface ISwitchable
    {
        public void Open();
        public void Close();
    }

    class GateOpenAction : ISwitchable
    {
        private Gate gate;

        public GateOpenAction(Gate gate)
        {
            this.gate = gate;
        }

        public void Close()
        {
            gate.Close();
        }

        public void Open()
        {
            gate.Open();
        }
    }

    class Pult
    {
        private ISwitchable openableObj;

        public void SetAction(ISwitchable action)
        {
            openableObj = action;
        }

        public void OpenButton()
        {
            openableObj.Open();
        }

        public void CloseButton()
        {
            openableObj.Close();
        }
    }

    class Gate : ISwitchable
    {
        public void Open()
        {
            Console.WriteLine("Открываем ворота");
        }

        public void Close()
        {
            Console.WriteLine("Закрываем ворота");
        }
    }

    internal class Task_9_2_5
    {
        public static void CommandPatternTask()
        {
            Pult pult = new Pult();
            Gate gate = new Gate();

            pult.SetAction(new GateOpenAction(gate));
            pult.OpenButton();
            pult.CloseButton();
        }
    }
}

