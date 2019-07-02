using FakerSocialMedia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakerSocialMedia.DataAccessLayer.Concrete
{
    public class UserOperations : BaseRepository<User>
    {

        string repoName;

        public UserOperations(string repoName) : base(repoName)
        {
            this.repoName = repoName;
        }

        public User Login(User user)
        {
            var result = new User();
            result = this.GetAll().Find(x => x.Username == user.Username && x.Password == user.Password);
            return result;
        }

    }
}
