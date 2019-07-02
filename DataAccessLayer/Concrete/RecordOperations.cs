using FakerSocialMedia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakerSocialMedia.DataAccessLayer.Concrete
{
    public class RecordOperations : BaseRepository<Record>
    {

        string repoName;

        public RecordOperations(string repoName) : base(repoName)
        {
            this.repoName = repoName;
        }

    }
}
