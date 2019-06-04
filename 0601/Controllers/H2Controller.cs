using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Mvc;
using _0601.Models;

namespace _0601.Controllers
{
    public class H2Controller : Controller
    {
        // GET: H2
        Random rn = new Random();
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult PSIndex()
        {
            return View();
        }

        [HttpPost]
        //自動裝配
        public ActionResult PSIndex(string ps)
        {
            ViewBag.pw = Password.SHA512(ps);
            return View();
        }

        public HttpNotFoundResult none()
        {

            return HttpNotFound("GG");
        }

        public ActionResult J1()
        {
            return Content("alert('Hello World');", "application/x-javascript");
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
                name = "名稱",
                message = "我是json",
            };
            return Json(Json_obj, JsonRequestBehavior.AllowGet);
        }

        //public ContentResult Show()
        //{
        //    string mypath = Server.MapPath("/images/");

        //    //取得images資料夾下的所有圖片名稱
        //    string[] Files_Name = Directory.GetFiles(mypath);

        //    //string Image_Path = Server.MapPath(string.Format( "~/images/image ({0}).gif",rn.Next()));

        //    //return File(Image_Path, "image/jpg");
        //    return Content(string.Join("<br/>",Files_Name));
        //}

        public FilePathResult Download()
        {
            string mypath = Server.MapPath("~/images/");

            //取得images資料夾下的所有圖片名稱(含路徑)
            string[] total_Files = Directory.GetFiles(mypath).FilterImage();
            int len = total_Files.Length;

            //隨機抓檔案出來顯示
            string rn_File = total_Files[rn.Next(len)];

            //取得最後一個斜線位置
            int last_Slash = rn_File.LastIndexOf("\\") + 1;

            rn_File = rn_File.Substring(last_Slash);

            string Image_Path = Server.MapPath(string.Format("~/images/{0}", rn_File));

            //取得路徑後這樣設置可以下載
            return File(Image_Path, "application/x-jpg", rn_File);
        }

        public FilePathResult Show()
        {
            string mypath = Server.MapPath("~/images/");

            //取得images資料夾下的所有圖片名稱(含路徑)
            string[] total_Files = Directory.GetFiles(mypath).FilterImage();
            int len = total_Files.Length;

            //隨機抓檔案出來顯示
            string rn_File = total_Files[rn.Next(len)];

            //取得最後一個斜線位置
            int last_Slash = rn_File.LastIndexOf("\\") + 1;

            //抓檔名
            rn_File = rn_File.Substring(last_Slash);

            string Image_Path = Server.MapPath(string.Format("~/images/{0}",rn_File));
            return File(Image_Path, "image/jpg");
            //return Content(string.Join("<br/>", Files_Name)+ "<br/><br/><br/>共有"+Len+"個檔案");
        }
        public ActionResult NEW()
        {
            return View();
        }

        public ActionResult ErrorPage()
        {
            return View();
        }

    }
}