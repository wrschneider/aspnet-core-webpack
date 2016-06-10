using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace BillCore.Controllers
{
    public class BillController : Controller
    {
        public IActionResult Index()
        {
            dynamic obj = new ExpandoObject();
            obj.Foo = "string set server-side";
            return View(obj);
        }

        // TODO: change to Web API
        public IActionResult api()
        {
            return Json(new { foo = "value from api method" });
        }
    }
}