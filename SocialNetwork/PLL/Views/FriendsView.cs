
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
    public class FriendsView
    {
        private User user;
        private FriendService friendService;
        private Logger logger;

        public FriendsView(User user, FriendService friendService)
        {
            this.user = user;
            this.friendService = friendService;
            logger = Logger.GetLogger();
        }

        public void AddFriend()
        {
            try
            {
                var targetEmail = Helper.InputField("Введите почту человека: ");
                var requestData = new FriendRequestData() { User = user, TargetEmail = targetEmail };
                friendService.AddFriend(requestData);
                logger.SuccessOutput("Запрос выполнен.");
            }
            catch (Exception ex)
            {
                logger.ErrorOutput(ex.Message);
            }
        }

        public void ShowFriends()
        {
            var friends = friendService.ListUserFriends(user);
            Console.WriteLine();
            foreach (var friend in friends)
            {
                Console.WriteLine($"{friend.FirstName} {friend.LastName}, почта: {friend.Email}");
            }
            Console.WriteLine();
        }
    }
}
