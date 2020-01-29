using Microsoft.EntityFrameworkCore;
using System;
using SistemaFarmacia.Entidades;


namespace DAL
{
    public class Contexto: DbContext 
    {
        public DbSet<Usuarios> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer(@"Server=DESKTOP-DITM7A1;Database=SystemPharmacyDB;Trusted_Connection=True")) ;
        }
    }
}
