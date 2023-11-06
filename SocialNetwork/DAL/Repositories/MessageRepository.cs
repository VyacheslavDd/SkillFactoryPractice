using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.DAL.Entities;

namespace SocialNetwork.DAL.Repositories
{
    public class MessageRepository : BaseRepository, IMessageRepository
    {
        public int Create(Message messageEntity)
        {
            return Execute(@"insert into messages(content, senderId, recipientId) 
                             values(:Content,:SenderId,:RecipientId)", messageEntity);
        }

        public IEnumerable<Message> FindBySenderId(int senderId)
        {
            return Query<Message>(@"select * from messages where senderId = :SenderId", new { SenderId = senderId });
        }

        public IEnumerable<Message> FindByRecipientId(int recipientId)
        {
            return Query<Message>(@"select * from messages where recipientId = :RecipientId", new { RecipientId = recipientId });
        }

        public int DeleteById(int messageId)
        {
            return Execute(@"delete from messages where id = :Id", new { Id = messageId });
        }

    }

    public interface IMessageRepository
    {
        int Create(Message messageEntity);
        IEnumerable<Message> FindBySenderId(int senderId);
        IEnumerable<Message> FindByRecipientId(int recipientId);
        int DeleteById(int messageId);
    }
}
