using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Alloggio
{
    public class AlloggioPiazzola : Alloggio
    {
        [Required]
        public bool SoloTenda { get; set; } = false;
        [Required]
        public bool AcquaInPiazzola { get; set; } = false;
    }
}