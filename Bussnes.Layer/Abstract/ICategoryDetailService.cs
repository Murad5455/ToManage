using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToManage.EntityLayer;

namespace Bussnes.Layer.Abstract
{

    public interface ICategoryDetailService
    {
        public void AddDetail(CategoryDetail categoryDetail);
        public void UpdateDetail(CategoryDetail categoryDetail);
        public void DeleteDtail(int id);
        public List<CategoryDetail> GetListAllDetail();
        public CategoryDetail GetByIdDetail(int id); 
    }
}
