using NarutoUnicarioca.Helpers;
using NarutoUnicarioca.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
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

        public async Task<ActionResult> Akatsuki()
        {
            using (var httpClient = new HttpClient())
            {
                var url = "https://www.narutodb.xyz/api/akatsuki?page=1&limit=44";
                var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var personagens = JsonConvert.DeserializeObject<IntegracaoNaruto>(json);
                    ViewBag.Personagens = JsonConvert.SerializeObject(personagens.akatsuki);
                    return View();
                }
                else
                {
                    return null;
                }
            }
        }
        public async Task<ActionResult> Bijuus()
        {
            using (var httpClient = new HttpClient())
            {
                var url = "https://www.narutodb.xyz/api/tailed-beast?page=1&limit=44";
                var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var personagens = JsonConvert.DeserializeObject<IntegracaoNaruto>(json);
                    ViewBag.Personagens = JsonConvert.SerializeObject(personagens.tailedBeasts);
                    return View();
                }
                else
                {
                    return null;
                }
            }
        }


        [HttpPost]
        public JsonResult GetPersonagens()
        {
            var httpclient = new HttpClient();
            var url = "https://www.narutodb.xyz/api/akatsuki?page=1&limit=44";

            var task = httpclient.GetAsync(url);
            task.Wait();

            if (task.Result.IsSuccessStatusCode)
            {
                var json = task.Result.Content.ReadAsStringAsync().Result;
                var personagens = JsonConvert.DeserializeObject<IntegracaoNaruto>(json);
                return Json(new { personagens.akatsuki }, JsonRequestBehavior.DenyGet);
            }
            else
            {
                return null;
            }
        }

    }
}