using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelpDeskApplication.Models;
namespace HelpDeskApplication.Controllers
{
    public class LoginController : Controller
    {
        HelpDeskApplication.Models.HelpdeskEntities db=new Models.HelpdeskEntities();
        //
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            var usr= (from x in db.Users where x.Username==user.Username && x.Password==user.Password select x).FirstOrDefault();
            if(user==null){
            ViewBag.error="Invalid Username and Password";
            }

            if(user.Client_ClientId==0)
            return Redirect("/TicketResponses/Create");
            else{
                 return Redirect("/TicketResponses/Index");
            }
        }
	}
}