using PostedFiles.Model.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PostedFiles.BusinessLogicalLayer.Repository
{
    public class UserRepository<T> : IRepository<User>
    {
        private static List<User> userList = new List<User>();

        public void Add(User item)
        {
            //string directory = @"C:\Users\ertglr\source\repos\PostedFiles\PostedFiles.Mvc\Uploads\";




            //if (file != null && file.ContentLength > 0)
            //{
            //    var fileName = Path.GetFileName(file.FileName);

            //    file.SaveAs(Path.Combine(directory, fileName));
            //    item.ImagePath = directory + fileName;
            //    userList.Add(item);
            //}
            //else
            //{


            //    userList.Add(item);
            //}

            userList.Add(item);
            
           
        }

        public void Delete(int id)
        {
            User user = userList.FirstOrDefault(i => i.ID == id);
            userList.Remove(user);
            
        }

        public IList<User> GetAll()
        {
            var users = userList.ToList();
            return users;
        }

        public void Update(User model)
        {
            var user = userList.FirstOrDefault(i => i.ID == model.ID);
            user.Firstname = model.Firstname;
            user.Lastname = model.Lastname;
            user.Username = model.Username;

            string directory = "~/‪Uploads/";

            //if (file != null && file.ContentLength > 0)
            //{
            //    var fileName = Path.GetFileName(file.FileName);
            //    file.SaveAs(Path.Combine(directory, fileName));
            //    user.ImagePath = directory + file.FileName;
            //}
            
        }

       
    }
}
