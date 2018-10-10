using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using Model.Dao;
using webvitinh.Areas.Admin.Models;
using
using webvitinh.Common;

namespace webvitinh.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login(Models.LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.Login(model.UserName, model.Password);
                if (result)
                {

                    var userSession = new UserLogin();

                    ISession.Add(CommonConstants.USER_SESSION);



                }
                else
                {

                }

            }
            else
            {

                ModelState.AddModelError("", "Đăng Nhập không Đúng");
            }
            return View("Index");
            

        }
    }
}