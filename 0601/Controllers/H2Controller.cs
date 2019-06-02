using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0601.Controllers
{
    public class H2Controller : Controller
    {
        // GET: H2
        public ActionResult Index()
        {
            return View();
        }

        public HttpNotFoundResult none()
        {
            
            return HttpNotFound("GG");
        }

        public ActionResult J1()
        {
            return Content("alert('Hello World');","application/x-javascript");
        }

        public JavaScriptResult J2()
        {
            string strScript = "alert('這是JavaScriptResult的結果')";

            return JavaScript(strScript);
        }

        public JsonResult JSON()
        {
            var Json_obj = new
            {
                id = 1,
                name= "名稱",
                message ="我是json",
            };
            return Json(Json_obj,JsonRequestBehavior.AllowGet);
        }

        public FilePathResult Download()
        {
            string Image_Path = Server.MapPath("~/images/書記gif.gif");

            //取得路徑後這樣設置可以下載
            return File(Image_Path, "application/x-jpg", "書記gif.gif");
        }

        public FilePathResult Show()
        {
            string Image_Path = Server.MapPath("~/images/書記gif.gif");


            return File(Image_Path,"image/jpg");
        }

        public ActionResult NEW()
        {
            return View();
        }
    }
}