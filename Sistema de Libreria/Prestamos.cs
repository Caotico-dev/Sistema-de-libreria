using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Libreria
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }
        [Required]
        public int UsuarioId { get; set; }
        [Required]
        public int LibroId { get; set; }
        [Required]
        public DateTime? FechaPrestamo { get; set; }
        [Required]
        public DateTime? FechaDevolucion { get; set; }
        [Required]
        public bool Devuelto { get; set; }
        [Required]
        public bool Procesado { get; set; } 

        //muchos a uno
        public virtual Usuario? Usuario { get; set; }
        public virtual Libros? Libros { get; set; }  
    }
}
