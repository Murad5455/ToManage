using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToManage.EntityLayer;
using ToManager.DataAccess.Layer.Abstract;
using ToManager.DataAccess.Layer.Repositories;

namespace ToManager.DataAccess.Layer.EntityFramework
{
    public class EfCategoryDetailRepository : GenericRepository<CategoryDetail>, ICategoryDetailDAL
    {
        private readonly Context contex;
        public EfCategoryDetailRepository(Context contex) : base(contex)
        {
            this.contex = contex;
        }

        public List<CategoryDetail> AllList()
        {
            var result = contex.CategoryDetails.Where(x => x.Status == true).ToList();
            return result;
        }
    }
}
