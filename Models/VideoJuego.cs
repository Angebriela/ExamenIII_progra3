using System.Globalization;
using System.ComponentModel.DataAnnotations;
namespace ExamenIII.Models
{
    public class VideoJuego : Media
    {
        [Required]
        public string Plataforma { get; set; }
        [Required]
        public string TamanioInstalacion { get; set; }
    }
}
