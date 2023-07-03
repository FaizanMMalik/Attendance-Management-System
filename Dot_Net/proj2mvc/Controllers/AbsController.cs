using proj2mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proj2mvc.Controllers
{
    public class AbsController : Controller
    {
        public ActionResult Welcome()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login1 login)
        {
            if (ModelState.IsValid)
            {
                if (new Functions().isValidUser(login.username, login.password))
                {

                    Session["login"] = login;

                    return RedirectToAction("Welcome", "Abs");
                }
                else
                {
                    ViewBag.InvalidUser = "Invalid UserName or Password";
                    return View(login);
                }
            }
            return View(login);
        }
        public ActionResult APolicy()
        {
            return View();
        }
        public ActionResult Contacts()
        {
            Functions e = new Functions();
            List<Functions> ContactList = e.GetCnt();
            return View(ContactList);
        }
        public ActionResult Messages()
        {
            Functions e = new Functions();
            List<Functions> MsgList = e.GetMsg();
            return View(MsgList);

        }
        public ActionResult ALetter()
        {
            return View();
        }

        public ActionResult WLetter()
        {
            return View();
        }
        public ActionResult AForm()
        {
            Functions e = new Functions();
            List<Functions> aform = e.GetAform();
            return View(aform);
           
        }
        public ActionResult DeleteC(Int64 id)
        {
            Functions entity = new Functions();
            int emp = entity.DeleteContacts(id);
            return RedirectToAction("Contacts");
        }
        public ActionResult DeleteA(Int64 id)
        {
            Functions entity = new Functions();
            int emp = entity.DeleteAf(id);
            return RedirectToAction("AForm");
        }
        public ActionResult DeleteM(Int64 id)
        {
            Functions entity = new Functions();
            int emp = entity.DeleteMsg(id);
            return RedirectToAction("Messages");
        }
    
    }
}