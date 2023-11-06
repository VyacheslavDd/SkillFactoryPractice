using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Validators;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Services
{
    public class MessageService
    {
        private UserService userService;
        private IMessageRepository messageRepository;

        public MessageService(UserService service)
        {
            userService = service;
            messageRepository = new MessageRepository();
        }

        public void SendMessage(MessageData data)
        {
            if (string.IsNullOrEmpty(data.Content)) throw new ArgumentNullException("Введите непустое сообщение.");
            if (data.Sender.Email == data.RecipientEmail) throw new ArgumentException("Нельзя отправить сообщение самому себе.");
            var validator = UserDataValidator.GetValidator();
            validator.ValidateAddress(data.RecipientEmail);

            var recipient = userService.FindByEmail(data.RecipientEmail);
            if (recipient is null) throw new UserNotFoundException("Получатель не найден.");

            var message = new Message(data.Content, data.Sender.Id, recipient.Id);
            if (messageRepository.Create(message) == 0) throw new Exception("Произошла непредвиденная ошибка при отправке сообщения. Попробуйте ещё раз.");
        }

        public List<(string, string)> GetOutgoingMessages(User sender)
        {
            var parsedMessages = new List<(string, string)>();
            var messages = messageRepository.FindBySenderId(sender.Id);
            foreach (var message in messages)
            {
                parsedMessages.Add((message.Content, userService.FindById(message.RecipientId).Email));
            }
            return parsedMessages;
        }

        public List<(string, string)> GetIncomingMessages(User recipient)
        {
            var parsedMessages = new List<(string, string)>();
            var messages = messageRepository.FindByRecipientId(recipient.Id);
            foreach (var message in messages)
            {
                parsedMessages.Add((message.Content, userService.FindById(message.SenderId).Email));
            }
            return parsedMessages;
        }
    }
}
