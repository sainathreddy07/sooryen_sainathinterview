using CodeTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CodeTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Notes(string userId)
        {
            //var userId = "";
            var notes = new List<NoteModel>();
            System.Web.Http.IHttpActionResult resp = new CodeTestApiController().GetNotes(userId);
            var contentResult = ((System.Web.Http.Results.OkNegotiatedContentResult<List<Models.NoteModel>>)resp).Content;

            if(contentResult != null)
            {
                notes = contentResult;
            }
            return View(notes);
        }

        public ActionResult LogOut()
        {
            Response.Cookies["user_ID"].Expires = DateTime.Now.AddDays(-1d);
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

    }
}