using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToManage.EntityLayer
{
    public class GoodsCategory
    {
        [Key]
        public int GoodsCategoryId { get; set; }

        public string CategoryName { get; set; }

        public bool Status { get; set; }

        public List<CategoryDetail> CategoryDetails { get; set; }


    }
}
