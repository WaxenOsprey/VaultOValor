// Purpose: To hold the Player class.
using System;

namespace models
{
    public class Player
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email {get; set;}
        public string Password {get; set;}

        public Player(int userId, string userName, string email, string password)
        {
            UserId = userId;
            UserName = userName;
            Email = email;
            Password = password;
        }

    }
}

