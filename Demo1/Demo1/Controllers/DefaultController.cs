using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo1.Models;

namespace Demo1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            using (NumbersContext context = new NumbersContext())
            {
                int count = context.Numbers.Count();
                ViewBag.Count = count;
                context.Numbers.Add(new NumbersModel()
                {
                    Number = count
                });
                context.SaveChanges();
                var lista = from x in context.Numbers
                            select x.Number;
                ViewBag.Lista = lista.ToList();
            }

            return View();
        }

        public ActionResult Bugged()
        {
            string x = null;
            string y = x.Trim();
            return View();
        }
    }
}