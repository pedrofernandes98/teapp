using System;
using System.Collections.Generic;
using System.Text;

namespace PH_MarvelApp.Models
{
    public class User
    {
        public string nomeResponsavel { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string nomeCrianca { get; set; }
        public DateTime DataNascimento { get; set; }
        public int sexoCriaca { get; set; }
        
    }
}
