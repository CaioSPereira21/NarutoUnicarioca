using NarutoUnicarioca.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NarutoUnicarioca.Controllers
{
    public class PersonagemController : Controller
    {
        public ActionResult Index()
        {
            var personagens = "";
            ViewBag.Personagens = JsonConvert.SerializeObject(personagens);
            return View();
        }

        [HttpPost]
        public JsonResult GetPersonagens()
        {
            var personagens = new List<Personagem>
            {
                new Personagem { Id = 1, Name = "Naruto" }
            };


            return Json(new { personagens }, JsonRequestBehavior.DenyGet);
        }
    }
}