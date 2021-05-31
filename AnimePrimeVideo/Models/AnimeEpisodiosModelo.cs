using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimePrimeVideo.Models
{
    public class AnimeEpisodiosModelo
    {
        public int ID { get; set; }
        public int AnimeID { get; set; }
        public string Episodios { get; set; }
    }
}