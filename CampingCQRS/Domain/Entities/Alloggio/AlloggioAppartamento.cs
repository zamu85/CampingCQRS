using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Alloggio
{
    public class AlloggioAppartamento : Alloggio
    {
        [Required]
        public int PostiDisponibili { get; set; }

        [Required]
        [ForeignKey("Camera")]
        public ICollection<Camera.Camera> Camere { get; set; } = new List<Camera.Camera>();
    }
}