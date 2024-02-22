using Bussnes.Layer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToManage.EntityLayer;
using ToManager.DataAccess.Layer.Abstract;

namespace Bussnes.Layer.Concrete
{
    public class CategoryDetailService : ICategoryDetailService
    {
        private readonly ICategoryDetailDAL _categoryDetailDAL;
        public CategoryDetailService(ICategoryDetailDAL categoryDetailDAL)
        {
            _categoryDetailDAL = categoryDetailDAL;
        }

        public void AddDetail(CategoryDetail categoryDetail)
        {
            categoryDetail.Status = true;
            _categoryDetailDAL.Insert(categoryDetail);
        }

        public void DeleteDtail(int id)
        {
           var result = _categoryDetailDAL.GetById(id);
            result.Status = false;
            _categoryDetailDAL.Update(result);
        }

        public CategoryDetail GetByIdDetail(int id)
        {
            var result = _categoryDetailDAL.GetById(id);
            return result;

        }

        public List<CategoryDetail> GetListAllDetail()
        {
          return _categoryDetailDAL.AllList();
        }

        public void UpdateDetail(CategoryDetail categoryDetail)
        {
            categoryDetail.Status = true;
            _categoryDetailDAL.Update(categoryDetail);
        }
    }
}
