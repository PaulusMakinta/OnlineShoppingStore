using OnlineHoppingStore.Domain.Abstract;
using OnlineShoppingStore.WebUi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace OnlineShoppingStore.WebUi.Controllers
{
    [Authorize]
    public class AccountController : Controller

    {
        IAuthentication authentication;

        public AccountController(IAuthentication authentication)
        {
            this.authentication = authentication;
        }

       [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel model,string returnUrl)
        {
            if(ModelState.IsValid)
            {
                if(authentication.Authenticate(model.UserName, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return Redirect(returnUrl ?? Url.Action("Index", "Admin"));
                }
                else
                {
                    ModelState.AddModelError("", "Incorrect User Name or Password");
                }
            }
            else
            {
                return View();
            }
            return View();

        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
                return RedirectToAction("Index", "Admin");
        }
    }
}