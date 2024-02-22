using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToManage.EntityLayer;

namespace ToManager.DataAccess.Layer
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<GoodsCategory> GoodsCategorys { get; set; }
        public DbSet<Goods> Goodss { get; set; }
        public DbSet<CategoryDetail> CategoryDetails { get; set; }
    }
}
