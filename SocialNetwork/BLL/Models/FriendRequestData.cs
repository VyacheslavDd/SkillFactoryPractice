using SocialNetwork.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Models
{
    public class FriendRequestData
    {
        public User? User { get; set; }
        public string? TargetEmail { get; set; }
    }
}
