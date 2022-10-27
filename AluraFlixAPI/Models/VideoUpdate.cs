using System.ComponentModel.DataAnnotations;

namespace AluraFlixAPI.Models
{
    public class VideoUpdate
    {
        [Required, MaxLength(60)]
        public string Titulo { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public string Url { get; set; }
    }
}
