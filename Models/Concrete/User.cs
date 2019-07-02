using FakerSocialMedia.Models.Abstract;
using FakerSocialMedia.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakerSocialMedia.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string IsAdmin { get; set; }
        public string ApiKey { get; set; }

        public User()
        {

        }

        public User(string username, string password, string isAdmin, string apiKey)
        {
            this.Username = username;
            this.Password = password;
            this.IsAdmin = isAdmin;
            this.ApiKey = apiKey;
        }

    }
}
