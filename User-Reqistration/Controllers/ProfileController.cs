using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using User_Reqistration.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;


namespace User_Reqistration.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Profile p,HttpPostedFileBase file)
        {
            ViewData["Message"] = "User rofile " + p.FirstName + " is Successfully addded";
            return View();
        }
    }
}