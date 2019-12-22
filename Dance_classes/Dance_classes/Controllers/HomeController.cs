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
        public int ID { get; set; }

        public ActionResult Index()
        {
            // получаем из бд все объекты Dance
            IEnumerable<Dance> dances = db.Dances;
            // передаем все объекты в динамическое свойство Dances в ViewBag
            ViewBag.Dances = dances;
            // возвращаем представление
            return View();
        }

        
       
        [HttpGet]
        public ActionResult Sing_up(int id)
        {
            if (id <= 2)
            {
                return Redirect("/My/Error");
            }
            ViewBag.DanceId = id;
            ID = id;
            return View();
        }

        [HttpPost]
        public MvcHtmlString Sing_up(Record record)
        {
            if (record.Person == null || record.Address == null)
            {
                
                TagBuilder div = new TagBuilder("div");
                div.SetInnerText("Милочка, вы не записались, а - а - а, низя так");
                TagBuilder btn = new TagBuilder("button");
                btn.MergeAttribute("onclick", "location.href = '/Home/Sing_up/'");
                btn.InnerHtml += div;
                return new MvcHtmlString(btn.ToString());
            }
            else
            {
                db.Records.Add(record);
                db.SaveChanges();
                TagBuilder div = new TagBuilder("div");
                div.SetInnerText("Позравляем, вы записались на самые опупенные танцули, ёу!");
                return MvcHtmlString.Create(div.ToString());
            }
            
        }

        
/*
        public string Sing_up(Record record)
        {
            if (record.Person == null || record.Address == null)
            {

                string html = "< div > Милочка, вы не записались, а - а - а, низя так</ div > ";
                html += "< button onclick = "location.href = '/Home/Sing_up/@d.Id'" > Записаться </ button >";
                return
            }
            db.Records.Add(record);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Позравляем, вы записались на самые опупенные танцули, ёу!";
        }
        */
    }
}