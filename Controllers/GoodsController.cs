using Microsoft.AspNetCore.Mvc;
using TeaTimeSite.Data.Interfaces;
using TeaTimeSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeaTimeSite.Controllers
{
    public class GoodsController : Controller
    {
        private readonly IGoods _allGoods;
        private readonly IGoodsCategory _allCategories;
        public GoodsController(IGoods goods, IGoodsCategory categories)
        {
            _allGoods = goods;
            _allCategories = categories;
        }

        public ViewResult GetListOfGoods()
        {
            ViewBag.PageTitle = "TEATIME - Главная";
            var obj = new GoodsListViewModel();
            obj.AllGoods = _allGoods.Goods;
            obj.currentCategory = "Чай";
            return View(obj);
        }
    }
}
