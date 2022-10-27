using System.ComponentModel.DataAnnotations;

namespace AluraFlixAPI.Models
{
    public class Video
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required, MaxLength(60)]
        public string Titulo { get; set; }
        [Required, MaxLength(500)]
        public string Descricao { get; set; }
        [Required, Url]
        public string Url { get; set; }
    }
}
