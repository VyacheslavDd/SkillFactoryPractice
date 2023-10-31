using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsFinalTask
{
    public class Actor
    {
        private IAction command;

        public void SetCommand(IAction command)
        {
            this.command = command;
        }

        public void Run()
        {
            command.Run();
        }

        public void Cancel()
        {
            command.Cancel();
        }
    }
}
