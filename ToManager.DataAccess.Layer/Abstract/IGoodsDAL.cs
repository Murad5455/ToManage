using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToManage.EntityLayer;

namespace ToManager.DataAccess.Layer.Abstract
{
    public  interface IGoodsDAL:IGenericRepository<Goods>
    {
        public List<Goods> AllGoods();
    }
}
