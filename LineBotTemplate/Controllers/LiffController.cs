using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LineBotTemplate.Controllers
{
    public class LiffController : Controller
    {
        [Route("~/Liff")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("~/Liff/Demo")]
        public ActionResult Demo()
        {
            return View();
        }
    }
}