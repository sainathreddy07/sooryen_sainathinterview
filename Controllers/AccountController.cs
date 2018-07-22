using CodeTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Http.Results;
using System.Web.Mvc;

namespace CodeTest.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {

            if (ModelState.IsValid)
            {
                string userName = model.UserName;
                string pwd = model.Password;

                //check with database 
                System.Web.Http.IHttpActionResult response = new CodeTestApiController().GetUser(new UserModel() { UserName = model.UserName, Password = model.Password });

                var contentResult = ((System.Web.Http.Results.OkNegotiatedContentResult<CodeTest.Models.UserModel>)response).Content;

                if (contentResult != null)
                {
                    System.Web.Security.FormsAuthentication.SetAuthCookie(userName.ToString(), false);

                    return RedirectToAction("Notes","Home", new {  userId = contentResult.UserName});

                }
                else
                {
                    ModelState.AddModelError("", "Invalid login attempt");
                }
            }

            return View(model);
        }
    }
}