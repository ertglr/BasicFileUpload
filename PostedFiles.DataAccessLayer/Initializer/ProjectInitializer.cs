using PostedFiles.DataAccessLayer.Context;
using PostedFiles.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostedFiles.DataAccessLayer.Initializer
{
    public class ProjectInitializer : CreateDatabaseIfNotExists<ProjectContext>
    {
        protected override void Seed(ProjectContext context)
        {

            User user = new User
            {
                Firstname = "Ertuğrul",
                Lastname = "Güler",
                Username = "ertglr",
                ImagePath = "IMG-0504.JPG",

            };
            context.Users.Add(user);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
