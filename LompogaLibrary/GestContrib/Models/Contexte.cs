using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LompogaLibrary;
using LompogaLibrary.Administation;
using LompogaLibrary.Localisation;
using Microsoft.EntityFrameworkCore;

namespace GestContrib.Models
{
    public class Contexte : DbContext
    {
        //public Contexte ( DbContextOptions<Contexte> options ) : base(options)
        //{
        //    Database.Migrate();
        //}
        protected override void OnConfiguring ( DbContextOptionsBuilder optionsBuilder )
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"data source=CERGITECH18-PC\MSSQLSERVER2014; initial catalog=TestDB;persist security info=True;user id=sa;Password=Cergi2015");
        }

        protected override void OnModelCreating ( ModelBuilder modelBuilder )
        {
            base.OnModelCreating(modelBuilder);
        }
        #region Identification

        //Entitiies Identifications
        public DbSet<Personne> Personnes { get; set; }
        #endregion


        #region Administration

        public DbSet<Agent> Agents { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Droits> Droits { get; set; }
        public DbSet<Profil> Profils { get; set; }
        public DbSet<HabilitationProfil> HabilitationProfils { get; set; }
        public DbSet<HabilitationSpéciale> habilitationSpéciales { get; set; }

        #endregion
        //Entitiies de localisations
        public DbSet<Quartier> Quartiers { get; set; }
        #region

        #endregion
    }
}
