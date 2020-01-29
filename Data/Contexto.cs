using Microsoft.EntityFrameworkCore;
using System;
using SistemaFarmacia.Entidades;


namespace SistemaFarmacia.DAL
{
    public class Contexto: DbContext 
    {
        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer(@"Server=DESKTOP-DITM7A1;Database=SystemPharmacyDB;Trusted_Connection=True")) ;
        }
    }
}
