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
    public class EfGoodsRepository : GenericRepository<Goods>,IGoodsDAL
    {
        private readonly Context _context;

        public EfGoodsRepository(Context context) : base(context)
        {
            _context = context;
        }


        public List<Goods> AllGoods()
        {
            var result = _context.Goodss.Where(x => x.Status == true).ToList();
            if (result != null)
            {
                return result;
            }
            return new List<Goods>();
        }
    }
}
