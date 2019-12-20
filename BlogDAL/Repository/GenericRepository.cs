using BlogDAL.Interfaces;
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Repository
{
    public class GenericRepository <T>: IGenericRepository<T> where T : class
    {
        private IDatabase _db;
        public GenericRepository()
        {
            _db = new Database("DBBLOG");
        }
        public int Create(T item)
        {
            throw new NotImplementedException();
        }

        public void CreateBulk(IEnumerable<T> items)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T FindById(int id)
        {
            var item = _db.SingleById<T>(id);
            return item;
        }

        public T FindById(string id)
        {
            throw new NotImplementedException();
        }

        public NPoco.Linq.IQueryProviderWithIncludes<T> Get()
        {
            throw new NotImplementedException();
        }

        public Page<T> GetDataByPage(long page, long itemPerPage, Sql sql)
        {
            throw new NotImplementedException();
        }

        public List<T> GetDataWithQuery(string query, params object[] args)
        {
            throw new NotImplementedException();
        }

        public List<T> GetDataWithQuery(Sql sql)
        {
            throw new NotImplementedException();
        }

        public List<T> GetProperty<T>(string query, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
