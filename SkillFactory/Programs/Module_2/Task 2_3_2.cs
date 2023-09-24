using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_2
{
    internal class Task_2_3_2
    {
        public delegate void Operation(int a, int b);

        public static void PracticingDelegates()
        {
            Operation mulDelegate = SubtractNumbers;
            mulDelegate += AddNumbers;
            mulDelegate.Invoke(10, 20);
            mulDelegate -= AddNumbers;
            mulDelegate.Invoke(10, 20);
        }

        private static void SubtractNumbers(int a, int b)
        {
            Console.WriteLine(b - a);
        }

        private static void AddNumbers(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
