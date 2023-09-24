using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_2
{
    internal class Task_2_2_2
    {
        public static void CatchArgumentOutOfRangeException()
        {
            try
            {
                throw new ArgumentOutOfRangeException();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done");
            }
        }
    }
}
