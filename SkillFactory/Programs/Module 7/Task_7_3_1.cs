using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_7
{
    public class Task_7_3_1
    {
        public class UserRepository : IUserRepository
        {
            public IEnumerable<User> FindAll()
            {
                return null;
            }
        }

        public interface IUserRepository
        {
            IEnumerable<User> FindAll();
        }

        public class User
        {
            public string Name
            {
                get;
                set;
            }
        }
    }
}
