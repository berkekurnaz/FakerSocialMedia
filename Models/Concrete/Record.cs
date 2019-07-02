using FakerSocialMedia.Models.Abstract;
using FakerSocialMedia.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakerSocialMedia.Models
{
    public class Record : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string CreatedDate { get; set; }
        public int CreatedDay { get; set; }
        public int CreatedWeek { get; set; }
        public int CreatedMonth { get; set; }
        public int CreatedYear { get; set; }
        public string CreatedIp { get; set; }
        public string MediaName { get; set; }

        public Record()
        {

        }

        public Record(string username, string password, string createdDate, int createdDay, int createdWeek, int createdMonth, int createdYear, string createdIp, string mediaName)
        {
            this.Username = username;
            this.Password = password;
            this.CreatedDate = createdDate;
            this.CreatedDay = createdDay;
            this.CreatedWeek = createdWeek;
            this.CreatedMonth = createdMonth;
            this.CreatedYear = createdYear;
            this.CreatedIp = createdIp;
            this.MediaName = mediaName;
        }

    }
}
