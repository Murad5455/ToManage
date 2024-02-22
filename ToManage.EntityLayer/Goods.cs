using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToManage.EntityLayer
{
    public class Goods
    {
        [Key]
        public int GoodsId { get; set; }

        public string GoodsName { get; set; }

        public int GoodsCount { get; set; }
       
        public int BuyPrice { get; set; }
       
        public int SellPrice { get; set; }

        //public int CompanyName { get; set; }

        public bool Status { get; set; }

        public int GoodsNumber { get; set; }

        public int CategoryDetailId { get; set; }

    }
}
