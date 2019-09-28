using MVCTEST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace MVCTEST.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration([Bind(Exclude = "IsEmailVarified,ActivationCode")] User user)
        {

            if (ModelState.IsValid)
            {
                using (TESTEntities TST = new TESTEntities())
                {
                    user.ActivationCode = Guid.NewGuid();
                    TST.Users.Add(user);
                    TST.SaveChanges();
                    EmailSend(user.Email, user.ActivationCode);

                }
                return RedirectToAction("Enter", "Customer");
            }
            else
            {
                return View();
            }
        } 


        public ActionResult VerifyEmail(Guid Tokan)
        {
            using (TESTEntities TEST = new TESTEntities())
            {
                 
                var user1 = TEST.Users.FirstOrDefault(x => x.ActivationCode == Tokan);
                if(user1 != null)
                {
                    user1.IsEmailVarified = true;
                    TEST.SaveChanges();

                    

                }

            }
                return View();
        }

        public void EmailSend(string Email,Guid? Tokan)
        {
            string url ="https://" + Request.Url.Authority + "/user/VerifyEmail?Tokan=" + Tokan;
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("dip@3sixty.com");
            mail.To.Add("dipaksutare007@gmail.com");
            mail.Subject = "Verify email";
            mail.Body = url;
            SmtpClient sc = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                Credentials = new System.Net.NetworkCredential("dip@3sixtyit.com", "dipak3sixty")
                
                
            };
            sc.Send(mail);



        }
    }
}