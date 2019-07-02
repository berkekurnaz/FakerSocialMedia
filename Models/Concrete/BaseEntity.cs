using FakerSocialMedia.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakerSocialMedia.Models.Concrete
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
