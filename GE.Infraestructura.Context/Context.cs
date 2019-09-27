using System;
using GE.Aplicacion.CadenaConexion;
using GE.Dominio.Entity;
using GE.Dominio.Entity.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using static GE.Aplicacion.CadenaConexion.CadenaConexion;

namespace GE.Infraestructura.Context
{
    public class Context : DbContext
    {

        public Context()
        {
            
        }

        public Context(DbContextOptions<Context> Option) : base(Option)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(AccesoCadenaConexion);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {

                entity.ToTable("Cliente");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("Id");

                entity.Property(e => e.Apellido)
                    .HasColumnName("Apellido")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("Nombre")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Dni)
                    .HasColumnName("Dni")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Domicilio)
                    .HasColumnName("Domicilio")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("Telefono")
                    .HasMaxLength(20)
                    .IsUnicode(false);               

                entity.Property(e => e.FechaDeIngreso)
                    .HasColumnName("FechaIngreso").IsRequired();
                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("FechaNacimiento").IsRequired();

                entity.Property(e => e.Sexo)
                    .HasColumnName("Sexo").IsRequired();
                entity.Property(e => e.GrupoSanguineo)
                    .HasColumnName("GrupoSanguineo").IsRequired();
            });
        }



        public DbSet<Cliente> Cliente { get; set; }

        //public DbSet<Factura> Factura { get; set; }

        //public  DbSet<ClienteControl> ClienteControl { get; set; }
    }
}
