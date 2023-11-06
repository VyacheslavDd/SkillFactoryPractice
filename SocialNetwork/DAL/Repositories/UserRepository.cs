using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.DAL.Entities;

namespace SocialNetwork.DAL.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public int Create(User userEntity)
        {
            return Execute(@"insert into users (firstname,lastname,password,email) 
                             values (:FirstName,:LastName,:Password,:Email)", userEntity);
        }

        public int DeleteById(int id)
        {
            return Execute(@"delete from users where id = :Id", new {Id = id});
        }

        public IEnumerable<User> FindAll()
        {
            return Query<User>(@"select * from users");
        }

        public User FindByEmail(string email)
        {
            return QueryFirstOrDefault<User>(@"select * from users where email = :Email", new { Email = email });
        }

        public User FindById(int id)
        {
            return QueryFirstOrDefault<User>(@"select * from users where id = :Id", new { Id = id });
        }

        public int Update(User userEntity)
        {
            return Execute(@"update users set firstname = :FirstName, lastname = :LastName, password = :Password, email = :Email,
            photo = :Photo, favouriteMovie = :FavouriteMovie, favouriteBook = :FavouriteBook where id = :Id", userEntity);
        }
    }

    interface IUserRepository
    {
        int Create(User userEntity);
        User FindByEmail(string email);
        IEnumerable<User> FindAll();
        User FindById(int id);
        int Update(User userEntity);
        int DeleteById(int id);
    }
}
