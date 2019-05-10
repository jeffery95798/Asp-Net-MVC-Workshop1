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
        Database1Entities1 db = new Database1Entities1();
        // GET: Book
        public ActionResult Index()
        {
            var book = db.BOOK_DATA.OrderBy(m => m.BOOK_CLASS_ID).ToList();
            return View(book);
        }
       

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(BOOK_DATA data)
        {
            db.BOOK_DATA.Add(data);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            var c = db.BOOK_CLASS.Where(n => n.BOOK_CLASS_ID == id).FirstOrDefault();
            db.BOOK_CLASS.Remove(c);
            db.SaveChanges();
            return RedirectToAction("index");
        }

        

    }
}
