using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.DAL.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public int SenderId { get; set; }
        public int RecipientId { get; set; }

        public Message()
        {

        }

        public Message(string? content, int senderId, int recipientId)
        {
            Content = content;
            SenderId = senderId;
            RecipientId = recipientId;
        }
    }
}
