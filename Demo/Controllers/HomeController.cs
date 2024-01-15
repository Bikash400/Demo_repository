using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Demo.Controllers
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


        public JsonResult  GetStaticData()
        {
            List<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem { Text = "Option 1", Value = "1" },
                new SelectListItem { Text = "Option 2", Value = "2" },
                new SelectListItem { Text = "Option 3", Value = "3" }
            };

            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SubmitDropdownValue(FormCollection form , string UpdateSiteStatus)
        {
            string selectedValue = form["selectedValue"];
         //Process the selectedValue as needed

            return Content($"Selected value: {selectedValue}");
        }

        public JsonResult ArnabMeetha(int value)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            var option = js.Deserialize<int>(value.ToString());
            //string value = js.Deserialize<int>( _jsonFetchData );
            // Process the selectedValue as needed

            return Json(value, JsonRequestBehavior.AllowGet);
        }
    }
}
