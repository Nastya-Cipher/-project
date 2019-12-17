using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dance_classes.Models;

namespace Dance_classes.Controllers
{
    public class HomeController : Controller
    {
        // создаем контекст данных
        DanceContext db = new DanceContext();

        public ActionResult Index()
        {
            // получаем из бд все объекты Dance
            IEnumerable<Dance> dances = db.Dances;
            // передаем все объекты в динамическое свойство Dances в ViewBag
            ViewBag.Dances = dances;
            // возвращаем представление
            return View();
        }

        public FilePathResult Downland()
        {
            string file_path = Server.MapPath("~/Files/text.docx");
            string file_type = "aplication/docx";
            return File(file_path, file_type);
        }
       
        [HttpGet]
        public ActionResult Sing_up(int id)
        {
            if (id <= 2)
            {
                return Redirect("/My");
            }
            ViewBag.DanceId = id;
            return View();
        }
        [HttpPost]
        public string Sing_up(Record record)
        {
            db.Records.Add(record);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Позравляем, вы записались на самые опупенные танцули, ёу!";
        }

       
       
    }
}