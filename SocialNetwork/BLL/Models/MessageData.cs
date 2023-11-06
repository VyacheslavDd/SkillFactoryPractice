using SocialNetwork.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Models
{
    public class MessageData
    {
        public string? Content { get; set; }
        public User? Sender { get; set; }
        public string? RecipientEmail { get; set; }
    }
}
