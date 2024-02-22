using Bussnes.Layer.Abstract;
using Microsoft.AspNetCore.Mvc;
using ToManage.EntityLayer;

namespace ToManager.UI.Controllers
{
    public class CategoryDetailController : Controller
    {
        private readonly ICategoryDetailService categoryDetail;
        public CategoryDetailController(ICategoryDetailService categoryDetail)
        {
            this.categoryDetail = categoryDetail;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = categoryDetail.GetListAllDetail();
            return View(result);
        }

        [HttpGet]
        public IActionResult GetAddCategoryDetails()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategoryDetails(CategoryDetail detail)
        {
            categoryDetail.AddDetail(detail);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult GetUpdateCategoryDetails(int id)
        { var result = categoryDetail.GetByIdDetail(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult UpdateCategoryDetails(CategoryDetail detail)
        {
            categoryDetail.UpdateDetail(detail);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult DeleteCategoryDetails(int id)
        {
            categoryDetail.DeleteDtail(id);
            return RedirectToAction("Index");
        }



    }
}
