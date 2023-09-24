using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_2
{
    internal class Task_2_2_3
    {
        public static void CatchRankException()
        {
            try
            {
                throw new RankException();
            }
            catch (RankException ex)
            {
                Console.WriteLine(ex.GetType().Name);
            }
            finally
            {
                Console.WriteLine("Done");
            }
        }
    }
}
