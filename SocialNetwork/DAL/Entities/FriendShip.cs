using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.DAL.Entities
{
    public class FriendShip
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FriendId { get; set; }

        public FriendShip() { }

        public FriendShip(int senderId, int receiverId)
        {
            UserId = senderId;
            FriendId = receiverId;
        }
    }
}
