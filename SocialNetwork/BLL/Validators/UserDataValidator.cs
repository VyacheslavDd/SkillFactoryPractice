using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Validators
{
    public class UserDataValidator
    {
        private static UserDataValidator validator;

        private EmailAddressAttribute emailAddressAttribute;

        private UserDataValidator()
        {
            emailAddressAttribute = new EmailAddressAttribute();
        }

        public static UserDataValidator GetValidator()
        {
            if (validator == null)
                validator = new UserDataValidator();
            return validator;
        }

        private void ValidateString(string? value)
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Введённое значение не должно быть пустым.");
        }

        private void ValidatePassword(string? password)
        {
            ValidateString(password);
            if (password?.Length < 8) throw new ArgumentException("Пароль должен быть не менее восьми символов!");
        }

        private void ValidateEmail(string? email)
        {
            ValidateString(email);
            if (!emailAddressAttribute.IsValid(email)) throw new ArgumentException("Некорректный адрес электронной почты!");
        }

        public void ValidateData(UserRegistrationData userRegistrationData)
        {
            ValidateString(userRegistrationData.FirstName);
            ValidateString(userRegistrationData.LastName);
            ValidatePassword(userRegistrationData.Password);
            ValidateEmail(userRegistrationData.Email);
        }

        public void ValidateName(string firstName, string lastName)
        {
            ValidateString(firstName);
            ValidateString(lastName);
        }

        public void ValidateAddress(string? email)
        {
            ValidateEmail(email);
        }
    }
}
