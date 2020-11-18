using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DbDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult studentSignUp()
        {
            return View();
        }

        public ActionResult studentAuthenticate(String Id, String name, String fname, Char gender, String password, String cnic, String city, int disc, String birthday, String mobile)
        {
            int result = DbDemo.Models.Db.signUpStd(Id, name, fname, gender, password, cnic, city, disc, birthday, mobile);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("studentSignUp", (object)data);
            }
            else if (result == 0)
            {

                String data = "You are not registered!";
                return View("studentSignUp", (object)data);
            }

            return RedirectToAction("Login");

        }

        public ActionResult teacherSignUp()
        {
            return View();
        }
        public ActionResult teacherAuthenticate(String courseId,int Id, String name, String fname, Char gender, String password, String cnic, String city, int disc, String birthday, String mobile,String email)
        {
            int result = DbDemo.Models.Db.signUpTeach(courseId, Id, name, fname, gender, password, cnic, city, disc, birthday, mobile, email);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("teacherSignUp", (object)data);
            }
            else if (result == 0)
            {

                String data = "You are not registered!";
                return View("teacherSignUp", (object)data);
            }

            return RedirectToAction("Login");
        }

        public ActionResult dummy()
        {
            return View();
        }

        public ActionResult userAuthen(int userId,String password)
        {
            int result = DbDemo.Models.Db.userLogin(userId, password);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("Login", (object)data);
            }
            else if (result == 0)
            {

                String data = "You are not registered!";
                return View("Login", (object)data);
            }

            return RedirectToAction("dummy");
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
    }
}