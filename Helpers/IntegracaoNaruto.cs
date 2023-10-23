using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NarutoUnicarioca.Helpers
{
    public class IntegracaoNaruto
    {
        public List<Character> characters { get; set; }
        public List<Character> akatsuki { get; set; }
        public List<Character> tailedBeasts { get; set; }
        public int currentPage { get; set; }
        public int pageSize { get; set; }
        public int totalCharacters { get; set; }
        public class Character
        {
            public int id { get; set; }
            public string name { get; set; }
            public List<string> images { get; set; }
            public Debut debut { get; set; }
            public List<string> jutsu { get; set; }
            public object personal { get; set; }
            public List<string> uniqueTraits { get; set; }
            public Family family { get; set; }
            public List<string> natureType { get; set; }
            public Rank rank { get; set; }
            public VoiceActors voiceActors { get; set; }
            public List<string> tools { get; set; }
        }

        public class Debut
        {
            public string novel { get; set; }
            public string movie { get; set; }
            public string appearsIn { get; set; }
            public string manga { get; set; }
            public string anime { get; set; }
            public string game { get; set; }
            public string ova { get; set; }
        }

        public class Family
        {
            [JsonProperty("incarnation with the god tree")]
            public string incarnationwiththegodtree { get; set; }

            [JsonProperty("depowered form")]
            public string depoweredform { get; set; }
            public string son { get; set; }
            public string nephew { get; set; }

            [JsonProperty("adoptive son")]
            public string adoptiveson { get; set; }

            [JsonProperty("adoptive brother")]
            public string adoptivebrother { get; set; }
            public string cousin { get; set; }

            [JsonProperty("adoptive father")]
            public string adoptivefather { get; set; }
            public string brother { get; set; }
            public string husband { get; set; }

            [JsonProperty("father")]
            public string father { get; set; }
            public string grandniece { get; set; }
            public string grandmother { get; set; }
            public string grandfather { get; set; }
            public string mother { get; set; }

            [JsonProperty("granduncle ")]
            public string granduncle { get; set; }
            public string daughter { get; set; }
            public string wife { get; set; }

            [JsonProperty("uncle ")]
            public string uncle { get; set; }
            public string granddaughter { get; set; }
        }

        public class NinjaRank
        {
            [JsonProperty("Part II")]
            public string PartII { get; set; }

            [JsonProperty("Part I")]
            public string PartI { get; set; }

            [JsonProperty("Boruto Manga")]
            public string BorutoManga { get; set; }
            public string Gaiden { get; set; }
        }

        public class Rank
        {
            public NinjaRank ninjaRank { get; set; }
            public string ninjaRegistration { get; set; }
        }

        public class VoiceActors
        {
            public object japanese { get; set; }
            public object english { get; set; }
        }
    }
}