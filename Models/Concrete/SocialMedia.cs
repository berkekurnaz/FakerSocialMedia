using FakerSocialMedia.Models.Abstract;
using FakerSocialMedia.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakerSocialMedia.Models
{
    public class SocialMedia : BaseEntity
    {
        public string MediaName { get; set; }
        public string IsEnabled { get; set; }

        public SocialMedia()
        {

        }

        public SocialMedia(string mediaName, string isEnabled)
        {
            this.MediaName = mediaName;
            this.IsEnabled = isEnabled;
        }

    }
}
