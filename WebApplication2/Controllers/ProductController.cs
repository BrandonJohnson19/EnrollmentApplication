using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVC_Application_Week_2.Controllers
{
    public class ProductController : Controller
    {
        public string Index()
        {
            return "Product/Index is displayed";
        }

        public string Browse()
        {
            return "Browse displayed";
        }

        public string Details(int id)
        {
            string message = "Details displayed for ID = " + id;
            return message;
        }

        public string Location(string zip)
        {
            string message = HttpUtility.HtmlEncode("Location displayed for zip = " + zip);
            return message;
        }
    }
}