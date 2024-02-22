using Bussnes.Layer.Abstract;
using Microsoft.AspNetCore.Mvc;
using ToManage.EntityLayer;

namespace ToManager.UI.Controllers
{
    public class GoodsCategoryController : Controller
    {
        private readonly IGoodsCategoryService goodsCategoryService;

        public GoodsCategoryController(IGoodsCategoryService goodsCategoryService)
        {
            this.goodsCategoryService = goodsCategoryService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = goodsCategoryService.CategoryAllList();
            return View(result);
        }
        [HttpGet]
        public IActionResult GetAddGoodsCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(GoodsCategory goods)
        {
            goodsCategoryService.CategoryAdd(goods);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GetCategoryUpdate(int id)
        {
            var result = goodsCategoryService.CategoryById(id);
            return View("GetCategoryUpdate",result);
        }

        [HttpPost]
        public IActionResult UpdateCategory(GoodsCategory category) 
        {
           
           goodsCategoryService.CategoryUpdate(category);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult ChangeStatusDelete(int id)
        {
            //var result = goodsCategoryService.CategoryById(id);
            goodsCategoryService.ChangeStatus(id) ;
            return RedirectToAction("Index");
          //  return Redirect("Index");
        }


    }
}
