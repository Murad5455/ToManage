using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToManage.EntityLayer;

namespace Bussnes.Layer.Abstract
{
    public  interface IGoodsService
    {
        public void AddGoods(Goods goods);
        public void UpdateGoods(Goods goods);
        public void DeleteGoods(int id);
        public List<Goods> GetListAllGoods();
        public Goods GetByIdGoods(int id);
    }
}
