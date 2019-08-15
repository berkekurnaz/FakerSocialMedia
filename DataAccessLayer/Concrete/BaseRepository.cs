using FakerSocialMedia.DataAccessLayer.Abstract;
using FakerSocialMedia.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiteDB;
using FakerSocialMedia.Models.Concrete;
using System.IO;
using System.Reflection;

namespace FakerSocialMedia.DataAccessLayer.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity, IEntity, new()
    {

        string repoName;

        public BaseRepository(string repoName)
        {
            this.repoName = repoName;
        }

        private static readonly string _path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location).TrimEnd('\\') + @"\myDatabase.db";

        public List<T> GetAll()
        {
            var list = new List<T>();
            using (var db = new LiteDatabase(_path))
            {
                var items = db.GetCollection<T>(repoName);
                foreach (T item in items.FindAll())
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public T GetById(int id)
        {
            var result = new T();
            using (var db = new LiteDatabase(_path))
            {
                var item = db.GetCollection<T>(repoName);
                result = item.Find(x => x.Id == id).FirstOrDefault();
            }
            return result;
        }

        public void AddModel(T model)
        {
            using (var db = new LiteDatabase(_path))
            {
                var items = db.GetCollection<T>(repoName);
                items.Insert(model);
            }
        }

        public void DeleteModel(int id)
        {
            using (var db = new LiteDatabase(_path))
            {
                var item = db.GetCollection<T>(repoName);
                item.Delete(id);
            }
        }

        public void UpdateModel(T model)
        {
            using (var db = new LiteDatabase(_path))
            {
                var items = db.GetCollection<T>(repoName);
                items.Update(model);
            }
        }

    }
}
