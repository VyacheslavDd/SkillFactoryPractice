using SocialNetwork.BLL.Models;
using SocialNetwork.DAL.Repositories;
using SocialNetwork.BLL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.DAL.Entities;
using SocialNetwork.BLL.Validators;

namespace SocialNetwork.BLL.Services
{
    public class FriendService
    {
        private UserService userService;
        private IFriendShipRepository friendsRepository;

        public FriendService(UserService userService)
        {
            this.userService = userService;
            friendsRepository = new FriendShipRepository();
        }

        private void CheckIfFriendShipExists(User user, User targetUser)
        {
            var friends = friendsRepository.FindAllByUserId(user.Id);
            if (friends.Any(friend => friend.Id == targetUser.Id)) throw new ArgumentException("Данный человек уже есть у вас в друзьях");
        }

        public void AddFriend(FriendRequestData requestData)
        {
            if (requestData.User.Email == requestData.TargetEmail) throw new ArgumentException("Нельзя добавить в друзья самого себя.");

            var validator = UserDataValidator.GetValidator();
            validator.ValidateAddress(requestData.TargetEmail);

            var targetUser = userService.FindByEmail(requestData.TargetEmail);
            if (targetUser is null) throw new UserNotFoundException("Указанный пользователь не найден.");
            CheckIfFriendShipExists(requestData.User, targetUser);

            var friendShip = new FriendShip(requestData.User.Id, targetUser.Id);
            if (friendsRepository.Create(friendShip) == 0) throw new Exception("Произошла ошибка при добавлении в друзья!");
        }

        public IEnumerable<User> ListUserFriends(User user)
        {
            var data = friendsRepository.FindAllByUserId(user.Id);
            var friends = new List<User>();
            foreach (var row in data)
            {
                var friend = userService.FindById(row.FriendId);
                friends.Add(friend);
            }
            return friends;
        }
    }
}
