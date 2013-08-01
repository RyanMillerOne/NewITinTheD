using ITintheDWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace ITintheDWebsite.Controllers
{
    public class HomeController : Controller
    {
        private DBEntities db = new DBEntities();
        private List<string> mailList = new List<string>() { "chancecyphers@gmail.com", "sraymond@galaxesolutions.com" };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Who()
        {
            return View();
        }

        public ActionResult What()
        {
            return View();
        }

        public ActionResult Learning()
        {
            return View();
        }

        public ActionResult Gain()
        {
            return View();
        }

        public ActionResult Why()
        {
            return View();
        }

        public ActionResult Faq()
        {
            return View();
        }

        public ActionResult Apply()
        {
            List<SelectListItem> howYouHeard = new List<SelectListItem>();
            howYouHeard.Add(new SelectListItem { Text = "Internet", Value = "Internet" });
            howYouHeard.Add(new SelectListItem { Text = "Friend", Value = "Friend" });
            howYouHeard.Add(new SelectListItem { Text = "Other", Value = "Other" });

            ViewBag.HowYouHeard = howYouHeard;

            return View();
        }

        [HttpPost]
        public ActionResult Apply(Application a)
        {
            /*if (ModelState.IsValid)
            {
                db.Apps.Add(a);
                db.SaveChanges();
                return RedirectToAction("ThankYou");
            }*/
            if (!ModelState.IsValid) return RedirectToAction("Apply");

            MailMessage mail = new MailMessage();
            SmtpClient client = new SmtpClient();

            //Construct Email
            mail.From = new MailAddress("itinthedwebsitetest@gmail.com", "IT in the D");
            foreach (string s in mailList)
            {
                mail.To.Add(new MailAddress(s, "IT in the D"));
            }
            mail.Subject = "IT in the D application";
            mail.Body = ComposeMessageBody(a);

            //Attach files
            if (a.Resume != null)
            {
                var res = new Attachment(a.Resume.InputStream, a.Resume.FileName);
                mail.Attachments.Add(res);
            }
            if (a.Transcript != null)
            {
                var tran = new Attachment(a.Transcript.InputStream, a.Transcript.FileName);
                mail.Attachments.Add(tran);
            }

            //Client Stuff
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("itinthedwebsitetest@gmail.com", "itinthed");
            client.EnableSsl = true;
            client.Send(mail);

            return RedirectToAction("ThankYou");
        }

        public ActionResult ThankYou()
        {
            return View();
        }

        private string ComposeMessageBody(Application a)
        {
            string body = a.FirstName + " " + a.LastName + " " + a.Email + Environment.NewLine +
                "Heard about IT in the D from: " + a.HowYouHeard + Environment.NewLine + 
                "Is interested in the " + a.Role + " role." + Environment.NewLine +
                "Why be part of IT in the D? " + a.Question1 + Environment.NewLine + 
                "What interest you most/least in a job? " + a.Question2 + Environment.NewLine + 
                "Where do you see yourself in three years? " + a.Question3;

            if (body != null) return body;

            return "Error constructing the body message";
        }
    }
}
