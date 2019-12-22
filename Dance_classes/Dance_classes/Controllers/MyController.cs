using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Dance_classes.Controllers
{
    public class MyController : Controller
    {
        public FilePathResult Downland()
        {
            string file_path = Server.MapPath("~/Files/text.docx");
            string file_type = "aplication/docx";
            return File(file_path, file_type);
        }

        public string Error()
        {
            return "Увы, мест нет";
        }
    }
}