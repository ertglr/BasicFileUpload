using PostedFiles.Model.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PostedFiles.Model.Models
{
    public class UploadFileModel
    {
        [FileSize(10240)]
        [FileTypes("jpg,jpeg,png")]
        public HttpPostedFileBase File { get; set; }
        


    }
}
