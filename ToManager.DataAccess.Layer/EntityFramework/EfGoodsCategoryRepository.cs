using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToManage.EntityLayer;
using ToManager.DataAccess.Layer.Abstract;
using ToManager.DataAccess.Layer.Repositories;

namespace ToManager.DataAccess.Layer.EntityFramework
{
    public class EfGoodsCategoryRepository : GenericRepository<GoodsCategory>, IGoodsCategoryDAL
    {
        private readonly Context context;
        public EfGoodsCategoryRepository(Context contex) : base(contex)
        {
           context = contex;
        }

        public void ChangeStatusCategoy(int id)
        {
            var result = context.GoodsCategorys.FirstOrDefault(x=>x.GoodsCategoryId==id);
            result.Status = false;
            context.SaveChanges();
        }

        public List<GoodsCategory> AllList()
        {
            var result = context.GoodsCategorys.Where(x => x.Status == true).ToList();
            return result;
        }



       
    }
}
