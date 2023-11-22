using EntityFrameworkFinalTask.Core;
using EntityFrameworkFinalTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkFinalTask.Repositories
{
    public class UserRepository
    {
        private LibraryContext context;

        public UserRepository(LibraryContext context)
        {
            this.context = context;
        }

        public List<User?> SelectAll()
        {
            return context.Users.ToList();
        }

        public void AddUser(User user)
        {
            context.Users.Add(user);
        }

        public void RemoveUser(User user)
        {
            context.Users.Remove(user);
        }

        public void UpdateNameById(int id, string name)
        {
            var user = SelectUserById(id);
            if (user is not null)
                user.Name = name;
        }

        public User? SelectUserById(int id)
        {
            return context.Users.FirstOrDefault(x => x.Id == id);
        }
    }
}
