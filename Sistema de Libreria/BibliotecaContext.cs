using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Libreria
{
    public class BibliotecaContext:DbContext
    {
        public DbSet<Libros> Libros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Prestamos> Prestamos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data source=Biblioteca.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Prestamos>().HasOne(l => l.Libros).WithMany(p => p.Prestamos).HasForeignKey(l => l.LibroId);
            modelBuilder.Entity<Prestamos>().HasOne(u => u.Usuario).WithMany(p => p.Prestamos).HasForeignKey(p => p.UsuarioId);


            modelBuilder.Entity<Libros>().HasData(
                new Libros { LibroId = 1, Titulo = "Moby Dick", Autor ="Herman Melville", Genero = "Novela", AñosPublicacion = 1851, Stock = 29, Cantidad = 30 },
                new Libros { LibroId = 2, Titulo = "Don Quixote", Autor ="Miguel de cervantes", Genero ="Novela", AñosPublicacion = 1605, Stock = 8, Cantidad = 8}
                );
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { UsuarioId =1, Nombre ="Daniel Jose Perez",CorreoElectronico ="danieljosez2003@gmail.com",Direccion="Carretera Sanchez", Telefono = "809-479-2355"}
                );
            modelBuilder.Entity<Prestamos>().HasData(
                new Prestamos {  PrestamoId = 1, UsuarioId = 1, LibroId = 1, FechaPrestamo = DateTime.Today , FechaDevolucion = DateTime.Parse("1/11/24"), Devuelto = false, Procesado = false },
                new Prestamos { PrestamoId = 3, UsuarioId = 1, LibroId = 2, FechaPrestamo = DateTime.Today,FechaDevolucion = DateTime.Parse("24/10/24"), Devuelto = false, Procesado = false}
                );
            
        }



    }
}
