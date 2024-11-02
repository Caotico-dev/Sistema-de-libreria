using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Libreria
{
    public class Libros
    {
        [Key]
        public int LibroId { get; set; }
        [Required]
        public string? Titulo { get; set; }
        [Required]
        public string? Autor { get; set; }
        [Required]
        public string? Genero { get; set; }
        [Required]
        public int AñosPublicacion { get; set; }
        [Required]    
        public int Stock { get; set; }
        [Required]
        public int Cantidad {  get; set; }
        public virtual ObservableCollectionListSource<Prestamos>? Prestamos { get; set; } // uno a muchos
    }
}
