using Bussnes.Layer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToManage.EntityLayer;
using ToManager.DataAccess.Layer;
using ToManager.DataAccess.Layer.Abstract;
using ToManager.DataAccess.Layer.Repositories;

namespace Bussnes.Layer.Concrete
{
    public class GoodsCategoryService : IGoodsCategoryService
    {
       private readonly IGoodsCategoryDAL genericRepository;
      

        public GoodsCategoryService(IGoodsCategoryDAL genericRepository)
        {
            this.genericRepository = genericRepository;
          
        }
   

        public void CategoryAdd(GoodsCategory category)
        {
            category.Status = true;
           genericRepository.Insert(category);

        }
      
        public List<GoodsCategory> CategoryAllList()
        {
            return genericRepository.AllList();
        }

        public GoodsCategory CategoryById(int id)
        {
            return genericRepository.GetById(id);
        }

        public void CategoryDelete(int id)
        {
             genericRepository.Delete(id);
        }

        public void CategoryUpdate(GoodsCategory category)
        {
            category.Status = true;
           genericRepository.Update(category);
        }

        public void ChangeStatus(int id)
        {
            var result = genericRepository.GetById(id);
             result.Status = false;

            genericRepository.Update(result);

        }

        /* public bool ChangeStatus(GoodsCategory category)
         {

             var result = genericRepository.ChangeStatusCategoy(category);
             return result;
         }*/


    }
}
