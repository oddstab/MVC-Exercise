using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace _0601.Controllers
{
    public class HomeController : Controller
    {
        public List<Models.Product> InitList()
        {
            List<Models.Product> pp = new List<Models.Product>
            {
                new Models.Product{Name_P="老王",NO_P=1, Price_P=8420 },
                new Models.Product{Name_P="老王1",NO_P=2, Price_P=8250 },
                new Models.Product{Name_P="老王2",NO_P=3, Price_P=8260 },
                new Models.Product{Name_P="老王3",NO_P=4, Price_P=8270 },
            };

            return pp;
        }

        // GET: Home
        public ActionResult Index()
        {
            //string myHTML = null;

            //SqlConnection conn = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["test"].ConnectionString);
            //SqlCommand command = new SqlCommand("select * from library", conn);

            //conn.Open();

            //SqlDataReader dataReader = command.ExecuteReader();          

            //myHTML += "<!DOCTYPE html>";
            //myHTML += "<html>";
            //myHTML += "<head>";
            //myHTML += "<meta name=\"viewport\" content=\"width = device - width\" />";
            //myHTML += "<title>還敢下來啊 冰鳥</title>";
            //myHTML += "</head>";
            //myHTML += "<body>";
            //myHTML += "<div>";
            //while (dataReader.Read())
            //{
            //    myHTML += "<h1>" + dataReader[new Random().Next(7)] + "</h1>";
            //}
            //myHTML += "</div>";
            //myHTML += "</body>";
            //myHTML += "</html>";
            //Response.Write(myHTML);
            //Response.End();
            return View();
        }

        [ActionName("Default2")]
        public ActionResult Index2()
        {
            ViewBag.Ha = "我";
            return View();
        }

        //[NonAction]
        [HttpPost]//form裡的method要對應這裡 才能呼叫
        public ActionResult NOme()
        {
            //string username = Request["username"];
            //string pwd = Request["pwd"];
            //ViewBag.msg = $"名稱:{username}，密碼:{pwd}";

            ViewBag.id = Request["id"];
            return View();
        }

        public ActionResult UseGet()
        {
            return View();
        }

        //傳回文字的結果
        public ContentResult TEXT()
        {
            return Content("還敢下來啊 冰鳥");
        }

        public ContentResult HTML()
        {
            return Content("<div style='border:1px solid #000;color:darkgoldenrod'>這是HTML啦！</div>");
        }

        public ContentResult XML()
        {
            return Content("<root><text>這是XML啦！！</text></root>", "text/xml", Encoding.UTF8);
        }

        public RedirectResult rrr()
        {
            return Redirect(Url.Action("XML"));
        }

        public ViewResult VV()
        {
            List<Models.Product> list = InitList();
            return View("Index", list);
        }

        //public ActionResult test()
        //{
        //    return View();
        //}

        public ActionResult test()
        {
            return View();
        }
    }
}