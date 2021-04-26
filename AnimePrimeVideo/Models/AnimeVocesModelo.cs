using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimePrimeVideo.Models
{
    public class AnimeVocesModelo
    {
        public int ID { get; set; }
        public int AnimeID { get; set; }
        public AnimeModelo Anime { get; set; }
        public int VozID { get; set; }
        public VozModelo Voz { get; set; }
    }
}