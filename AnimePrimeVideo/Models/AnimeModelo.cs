using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimePrimeVideo.Models
{
    public class AnimeModelo
    {
        public int ID { get; set; }
        public string FotoAnime { get; set; }
        public string Titulo { get; set; }
        public string Estado { get; set; }
        public string Tipo { get; set; }
        public GeneroModelo Genero { get; set; }
        public int GeneroID { get; set; }
        public string EstrenoAño { get; set; }
        public string Resumen { get; set; }
        public string Opening { get; set; }
        public string Ending { get; set; }
        public List<int> AnimeEpiID { get; set; }
        public List<AnimeEpisodiosModelo> AnimeEpi { get; set; }
        public List<int> AnimeVozID { get; set; }
        public List<AnimeVocesModelo> AnimeVoz { get; set; }

    }
}