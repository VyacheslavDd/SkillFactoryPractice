﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.DAL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Photo { get; set; }
        public string? FavouriteBook { get; set; }
        public string? FavouriteMovie { get; set; }

        public User(int id, string? firstName, string? lastName, string? email, string? password,
            string? photo, string? favouriteBook, string? favouriteMovie)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Photo = photo;
            FavouriteBook = favouriteBook;
            FavouriteMovie = favouriteMovie;
        }

        public User()
        {

        }
    }
}
