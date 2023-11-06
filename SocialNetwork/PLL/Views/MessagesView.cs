using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.DAL.Entities;
using SocialNetwork.PLL.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class MessagesView
    {
        private User user;
        private MessageService messageService;
        private Logger logger;

        public MessagesView(User user, MessageService messageService)
        {
            this.user = user;
            this.messageService = messageService;
            logger = Logger.GetLogger();
        }

        public void SendMessage()
        {
            try
            {
                var recipientEmail = Helper.InputField("Введите адрес получателя: ");
                var message = Helper.InputField("Введите сообщение: ");
                var messageData = new MessageData { Content = message, Sender = user, RecipientEmail = recipientEmail };
                messageService.SendMessage(messageData);
                logger.SuccessOutput($"Вы успешно отправили сообщение '{message}' на адрес {recipientEmail}.");
            }
            catch (Exception ex)
            {
                logger.ErrorOutput(ex.Message);
            }
        }

        private void OutputMessages(List<(string, string)> messages, string notification)
        {
            Console.WriteLine();
            foreach (var message in messages)
            {
                Console.WriteLine(string.Format(notification, message.Item1, message.Item2));
            }
            Console.WriteLine();
        }

        public void ShowOutgoingMessages()
        {
            var messages = messageService.GetOutgoingMessages(user);
            OutputMessages(messages, "Отправлено сообщение '{0}' пользователю {1}");
        }

        public void ShowIncomingMessages()
        {
            var messages = messageService.GetIncomingMessages(user);
            OutputMessages(messages, "Получено сообщение '{0}' от пользователя {1}");
        }
    }
}
