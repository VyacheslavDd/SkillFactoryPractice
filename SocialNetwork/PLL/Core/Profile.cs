using SocialNetwork.BLL.Services;
using SocialNetwork.BLL.Validators;
using SocialNetwork.DAL.Entities;
using SocialNetwork.PLL.Additional;
using SocialNetwork.PLL.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Core
{
    public class Profile
    {
        private Logger logger;
        private UserService userService;
        private MessageService messageService;
        private FriendService friendsService;
        private User user;

        private ShowProfileView showProfileView;
        private UpdateProfileView updateProfileView;
        private MessagesView messagesView;
        private FriendsView friendsView;

        private bool isRunning = true;

        public Profile(User user, UserService userService)
        {
            this.user = user;
            this.userService = userService;
            messageService = new MessageService(this.userService);
            friendsService = new FriendService(userService);
            logger = Logger.GetLogger();

            showProfileView = new ShowProfileView(this.user);
            updateProfileView = new UpdateProfileView(this.user, userService);
            messagesView = new MessagesView(this.user, messageService);
            friendsView = new FriendsView(this.user, friendsService);
        }

        private void QuitProfile()
        {
            isRunning = false;
            Console.WriteLine($"До скорой встречи, {user.FirstName}!");
        }

        private void ShowActions()
        {
            Console.WriteLine("Что делаем?");
            Console.WriteLine("Просмотреть информацию о моём профиле (нажмите 1)");
            Console.WriteLine("Редактировать мой профиль (нажмите 2)");
            Console.WriteLine("Добавить в друзья (нажмите 3)");
            Console.WriteLine("Написать сообщение (нажмите 4)");
            Console.WriteLine("Посмотреть исходящие сообщения (нажмите 5)");
            Console.WriteLine("Посмотреть входящие сообщения (нажмите 6)");
            Console.WriteLine("Добавить человека в друзья (нажмите 7)");
            Console.WriteLine("Посмотреть список друзей (нажмите 8)");
            Console.WriteLine("Выйти из профиля (нажмите 9)");
        }

        private void Act(int action)
        {
            switch (action)
            {
                case 1:
                    showProfileView.ShowProfileInfo();
                    break;
                case 2:
                    updateProfileView.ChangeProfileData();
                    break;
                case 4:
                    messagesView.SendMessage();
                    break;
                case 5:
                    messagesView.ShowOutgoingMessages();
                    break;
                case 6:
                    messagesView.ShowIncomingMessages();
                    break;
                case 7:
                    friendsView.AddFriend();
                    break;
                case 8:
                    friendsView.ShowFriends();
                    break;
                case 9:
                    QuitProfile();
                    break;
                default:
                    logger.ErrorOutput("Пока что такая команда не реализована!");
                    break;
            }
        }

        public void Run()
        {
            while (isRunning)
            {
                ShowActions();
                var action = ChoiceGetter.GetChoice(1, 9, logger);
                Act(action);
            }
        }
    }
}
