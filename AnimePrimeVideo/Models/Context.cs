using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AnimePrimeVideo.Models
{
    public class Context : DbContext
    {
        public DbSet<VozModelo> ActorVoz { get; set; }
        public DbSet<GeneroModelo> Genero { get; set; }
        public DbSet<AnimeModelo> Animes { get; set; }
        public DbSet<AnimeVocesModelo> AnimeVoces { get; set; }
    }
}