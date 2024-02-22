using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToManage.EntityLayer
{
    public class CategoryDetail
    {
        public int CategoryDetailId { get; set; }
        
        public string CategoryDetailName { get; set; }

        public bool Status { get; set; }

        public int GoodsCategoryId { get; set; }

        public List<Goods> Goodss { get; set; }
    }
}
