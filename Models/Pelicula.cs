using System.Globalization;
using System.ComponentModel.DataAnnotations;
namespace ExamenIII.Models
{
    public class Pelicula : Media
    {
        [Required]
        public string Duracion { get; set; }
        [Required]
        public string Idioma { get; set; }
    }
}
