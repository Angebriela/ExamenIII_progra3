using System.ComponentModel.DataAnnotations;

namespace ExamenIII.Models
{
    public class Media
    {
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Genero { get; set; }
        [Required]
        public string Lanzamiento { get; set; }
    }
}
