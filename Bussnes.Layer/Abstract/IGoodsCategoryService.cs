using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToManage.EntityLayer;
using ToManager.DataAccess.Layer.Abstract;

namespace Bussnes.Layer.Abstract
{
    public interface IGoodsCategoryService
    {
        public void CategoryAdd(GoodsCategory category);

        public void CategoryUpdate(GoodsCategory category);

        public void CategoryDelete(int id);

        public List<GoodsCategory> CategoryAllList();

        public GoodsCategory CategoryById(int id);

        public void ChangeStatus(int id);

    }
}
