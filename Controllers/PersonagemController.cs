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

        public ActionResult Akatsuki()
        {
            var personagens = "";
            ViewBag.Personagens = JsonConvert.SerializeObject(personagens);
            return View();
        }
        public ActionResult Bijuus()
        {
            var personagens = "";
            ViewBag.Personagens = JsonConvert.SerializeObject(personagens);
            return View();
        }

        [HttpPost]
        public JsonResult GetAkatsukiPersonagens()
        {
            var httpclient = new HttpClient();
            var url = "https://www.narutodb.xyz/api/akatsuki?page=1&limit=44";

            var task = httpclient.GetAsync(url);
            task.Wait();

            if (task.Result.IsSuccessStatusCode)
            {
                var json = task.Result.Content.ReadAsStringAsync().Result;
                var personagens = JsonConvert.DeserializeObject<IntegracaoNaruto>(json);

                List<string> nomesDesejados = new List<string>
                {
                "Black Zetsu", "Deidara", "Hidan", "Itachi Uchiha",
                "Jūgo", "Kabuto Yakushi", "Kakuzu", "Karin", "Kisame Hoshigaki",
                "Konan", "Madara Uchiha", "Nagato", "Obito Uchiha", "Orochimaru",
                "Sasori", "Sasuke Uchiha", "Suigetsu Hōzuki", "Tobi (Zetsu)", "Yahiko", "White Zetsu"
                };

                var akatsuki = personagens.akatsuki
                    .Where(x => nomesDesejados.Contains(x.name)).OrderBy(x => x.name).ToList();

                var sasuke = akatsuki.FirstOrDefault(x => x?.name == "Sasuke Uchiha");
                sasuke.images[0] = "../Imagens/Sasuke (Akatsuki).jpg";

                var nagato = akatsuki.FirstOrDefault(x => x?.name == "Nagato");
                nagato.images[0] = "../Imagens/Nagato.jpg";

                var tobi = akatsuki.FirstOrDefault(x => x?.name == "Tobi (Zetsu)");
                tobi.name = "Tobi";
                tobi.images[0] = "../Imagens/Tobi.jpg";

                return Json(new { akatsuki }, JsonRequestBehavior.DenyGet);
            }
            else
            {
                return null;
            }
        }
        [HttpPost]
        public async Task<JsonResult> GetBijuusPersonagens()
        {
            using (var httpClient = new HttpClient())
            {
                var url = "https://www.narutodb.xyz/api/tailed-beast?page=1&limit=44";
                var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var personagens = JsonConvert.DeserializeObject<IntegracaoNaruto>(json);

                    var nomesBijuus = new List<string>
            {
                "Shukaku", "Matatabi", "Isobu", "Son Gokū", "Kokuō",
                "Saiken", "Chōmei", "Gyūki", "Kurama", "Ten-Tails"
            };

                    var tailedBeasts = nomesBijuus
                        .Select(nome => personagens.tailedBeasts.FirstOrDefault(x => x.name == nome))
                        .ToList();

                    var kurama = tailedBeasts.FirstOrDefault(x => x?.name == "Kurama");
                    kurama?.images.Add("../Imagens/Kurama.png");

                    return Json(new { tailedBeasts }, JsonRequestBehavior.DenyGet);
                }
                else
                {
                    return null;
                }
            }
        }

    }
}