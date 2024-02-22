using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToManager.DataAccess.Layer.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        public void Insert(T t);
        
        public void Delete(int id);

        public void Update(T t);

        public List<T> GetAllList();

        public T GetById(int id);

    }
}
