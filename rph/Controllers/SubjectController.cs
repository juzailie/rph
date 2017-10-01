using rph.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rph.Controllers
{
    public class SubjectController : Controller
    {
        // GET: Subject
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string action)
        {
            var model = new Subject();
            return View(model);
        }
        
        [HttpPost]
        public ActionResult Form(Subject model)
        {
            if (ModelState.IsValid)
            {
                
            }

            return View(model);
        }
    }
}