using PostedFiles.BusinessLogicalLayer.Repository;
using PostedFiles.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using PostedFiles.DataAccessLayer.Context;

namespace PostedFiles.Mvc.Controllers
{
    public class HomeController : Controller
    {

        ProjectContext db = new ProjectContext();
        //public UserRepository<User> repository = new UserRepository<User>();
      
        public ActionResult Index()
        {

            return View(db.Users.ToList());
        }

        public ActionResult PostedFile()
        {
            

            return View();
        }

        [HttpPost]
        public ActionResult PostedFile(User user,HttpPostedFileBase? file)
        {

            string directory ="";




            if (file != null && file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);

                directory=System.IO.Path.Combine(Server.MapPath("~/Uploads/" + fileName));
                file.SaveAs(directory);
                //user.ImagePath = directory + fileName;
                user.ImagePath = fileName;
                db.Users.Add(user);
                db.SaveChanges();
               
            }



            return RedirectToAction("Index");
        }

        //public ActionResult TrialUpload()
        //{
        //    var list = repository.GetAll();
            
        //    User user = new User();

        //    user.ID = 1;
        //    user.Firstname = "Ertuğrul";
        //    user.Lastname = "Güler";
        //    user.Username = "ertglr";
        //    user.ImagePath = "/Uploads/IMG-0504.JPG";
        //    repository.Add(user);
        //    return RedirectToAction("Index");
        //}
    }
}