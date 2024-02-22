using Bussnes.Layer.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToManage.EntityLayer;
using ToManager.DataAccess.Layer.Abstract;

namespace Bussnes.Layer.Concrete
{
    public class GoodsService : IGoodsService
    {
        public IGoodsDAL goodsDAL;
        public GoodsService(IGoodsDAL goodsDAL)
        {
            this.goodsDAL = goodsDAL;
            
        }

        public void AddGoods(Goods goods)
        {
            goods.Status = true;
          goodsDAL.Insert(goods);   
        }

        public void DeleteGoods(int id)
        {
            var result = goodsDAL.GetById(id);
            result.Status = false;
            goodsDAL.Update(result);
        }

        public Goods GetByIdGoods(int id)
        {
          var result = goodsDAL.GetById(id);
           
           return result;
          
        }

        public List<Goods> GetListAllGoods()
        {
           return goodsDAL.AllGoods();
           
        }

        public void UpdateGoods(Goods goods)
        { 
            goods.Status = true;
            goodsDAL.Update(goods);

        }
    }
}
