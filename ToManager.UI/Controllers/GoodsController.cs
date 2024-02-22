using Bussnes.Layer.Abstract;
using Microsoft.AspNetCore.Mvc;
using ToManage.EntityLayer;
using ToManager.DataAccess.Layer.Abstract;

namespace ToManager.UI.Controllers
{
    public class GoodsController : Controller
    {
        private readonly IGoodsService goods;
        public GoodsController(IGoodsService goods)
        {
            this.goods = goods;
        }

        [HttpGet]
        public IActionResult Index()
        {
           var result = goods.GetListAllGoods();
            return View(result);
        }
        [HttpGet]
        public IActionResult GetAddGoods()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GoodsAdd(Goods goodss) 
        {
            goods.AddGoods(goodss);
            return RedirectToAction("Index");   
        }
        [HttpGet]
        public IActionResult GetUpdateGoods(int id)
        {
           var result = goods.GetByIdGoods(id);
            return View(result);    

        }
        [HttpPost]
        public IActionResult UpdateGoods(Goods goodss)
        {
            goods.UpdateGoods(goodss);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult DeleteGoods(int id)
        {
            goods.DeleteGoods(id);
            return RedirectToAction("Index");
        }



    }
}
