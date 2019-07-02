using FakerSocialMedia.DataAccessLayer.Concrete;
using FakerSocialMedia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakerSocialMedia.Utilites
{
    public class UserUtilities
    {
        UserOperations userOperations = new UserOperations("Users");

        public void CreateDefaultUser(UserOperations userOperations)
        {
            if(userOperations.GetAll().Count == 0)
            {
                var user = new User("admin","1111","yes","ff10def1881sh2019crtmsh1923abc");
                userOperations.AddModel(user);
            }
        }

    }
}
