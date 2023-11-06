using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.DAL.Entities;

namespace SocialNetwork.DAL.Repositories
{
    public class FriendShipRepository : BaseRepository, IFriendShipRepository
    {
        public IEnumerable<FriendShip> FindAllByUserId(int userId)
        {
            return Query<FriendShip>(@"select * from friends where userId = :UserId", new { UserId = userId });
        }

        public int Create(FriendShip friendEntity)
        {
            return Execute(@"insert into friends (userId,friendId) values (:UserId,:FriendId)", friendEntity);
        }

        public int Delete(int id)
        {
            return Execute(@"delete from friends where id = :Id", new { Id = id });
        }
    }

    public interface IFriendShipRepository
    {
        int Create(FriendShip friendEntity);
        IEnumerable<FriendShip> FindAllByUserId(int userId);
        int Delete(int id);
    }
}
