using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Asp_Net_MVC_Workshop1.Models;


namespace Asp_Net_MVC_Workshop1.Controllers
{
    public class BookController : Controller
    {

        Database1Entities db=new Database1Entities();

        // GET: Book
        public ActionResult Index()
        {
            return View();
        }



    }
}