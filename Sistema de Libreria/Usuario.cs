using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Libreria
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public string? CorreoElectronico { get; set; } 
        [Required]
        public string? Telefono { get; set; }
        [Required]
        public string? Direccion { get; set; }
        public virtual ObservableCollectionListSource<Prestamos>? Prestamos { get; set; } // uno a muchos

    }
}
