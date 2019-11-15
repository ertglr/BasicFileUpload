using PostedFiles.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PostedFiles.BusinessLogicalLayer.Repository
{
    interface IRepository<T> where T:class
    {
        void Add(T item);
        void Delete(int id);
        IList<T> GetAll();
        void Update(T model);

    }
}
