using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.BusinessDataLogic.UnitConverterProcessor;

namespace UnitConverter.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult UnitConverter()
        {
            ViewBag.Message = "Konwerter Jednostek";



            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UnitConverter(UnitConverterModel model)
        {
           if (ModelState.IsValid)
            {
                int recordsCreated = UnitConvert(model.ConvertTime,
                    model.whatUnit,
                    model.convertFrom,
                    model.convertTo,
                    model.result
                    );
                    return RedirectToAction("Index");
            }



            return View();
        }
    }
}