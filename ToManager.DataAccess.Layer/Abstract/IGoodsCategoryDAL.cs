using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToManage.EntityLayer;

namespace ToManager.DataAccess.Layer.Abstract
{
    public interface IGoodsCategoryDAL : IGenericRepository<GoodsCategory>
    {

        public void ChangeStatusCategoy(int id);
        public List<GoodsCategory> AllList();
    }
}