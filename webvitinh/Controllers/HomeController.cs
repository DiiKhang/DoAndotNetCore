using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webvitinh.Common;
using Model.Dao;

namespace webvitinh.Controllers
{


    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.Slides = new SlideDao().ListAll();
            var ProductDao = new ProductDao();
            ViewBag.NewProducts = ProductDao.ListNewProduct(4);
            ViewBag.ListFeatureProducts = ProductDao.ListFeatureProduct(4);
            return View();
        }

        //[ChildActionOnly]   
        //public IActionResult MainMenu()
        //{
        //    var model = new MenuDao().ListByGroupId(1);
        //    return PartialView(model);
        //}

        //[ChildActionOnly]
        //public IActionResult TopMenu()
        //{
        //    ViewBag.Login = CommonConstants.USER_SESSION;
        //    var model = new MenuDao().ListByGroupId(2);
        //    return PartialView(model);
        //}


        //public IActionResult HeaderCart()
        //{
        //    var cart = Session[CommonConstant.CartSession];
        //    var list = new List<CartItem>();
        //    if (cart != null)
        //    {
        //        list = (List<CartItem>)cart;
        //    }
        //    return PartialView(list);
        //}


        public IActionResult Footer()
        {
            var model = new FooterDao().GetFooter();
            return PartialView(model);
        }
    }
}