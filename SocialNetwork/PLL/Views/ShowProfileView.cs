using SocialNetwork.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class ShowProfileView
    {
        private User user;

        public ShowProfileView(User user)
        {
            this.user = user;
        }

        public void ShowProfileInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Имя: {user.FirstName}");
            Console.WriteLine($"Фамилия: {user.LastName}");
            Console.WriteLine($"E-mail: {user.Email}");
            Console.WriteLine($"Ссылка на фото: {user.Photo}");
            Console.WriteLine($"Любимый фильм: {user.FavouriteMovie}");
            Console.WriteLine($"Любимая книга: {user.FavouriteBook}");
            Console.WriteLine();
        }
    }
}
