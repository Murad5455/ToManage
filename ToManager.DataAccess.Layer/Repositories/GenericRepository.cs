using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToManage.EntityLayer;
using ToManager.DataAccess.Layer.Abstract;

namespace ToManager.DataAccess.Layer.Repositories
{
    public class GenericRepository<T>:IGenericRepository<T> where T:class
    {
        private readonly Context _context;

        public GenericRepository(Context contex)
        {
            _context = contex;
        }

        public void Insert(T t)
        {
           _context.Add(t);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
           var result = _context.Set<T>().Find(id);
            return result;
        }

        public List<T> GetAllList()
        {
            return _context.Set<T>().ToList();
        }

        public void Delete(int id)
        {
           _context.Remove(id);
            _context.SaveChanges();
        }

        public void Update(T t)
        {
         _context.Update(t);
         _context.SaveChanges();
        }
    }
}
