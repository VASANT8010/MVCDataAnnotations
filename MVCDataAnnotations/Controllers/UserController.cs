using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDataAnnotations.Models;

namespace MVCDataAnnotations.Controllers
{
    
    public class UserController : Controller
    {
        public JsonResult isValidDate(DateTime DOB)
        {
            bool Status = true;
            if(DOB > DateTime.Now.AddYears(-18))
            {
                Status = false;
            }
            else
            {
                Status = true;
            }
            return Json(Status, JsonRequestBehavior.AllowGet);
        }
        // GET: User
        public ViewResult AddUser()
        {
            return View();
        }
        public ViewResult DisplayUser(User user)
        {
            return View(user);
        }
    }
}