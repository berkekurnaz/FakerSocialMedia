using FakerSocialMedia.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakerSocialMedia.DataAccessLayer.Abstract
{
    public interface IBaseRepository<T> where T : IEntity, new()
    {
        List<T> GetAll();
        T GetById(int id);
        void AddModel(T model);
        void UpdateModel(T model);
        void DeleteModel(int id);
    }
}
