using Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Camera
{
    [Table("Camere")]

    public class Camera : BaseEntity
    {
        [Required]
        public bool IsMatrimoniale { get; set; }

        [Required]
        public bool LettoSingola { get; set; }

        [Required]
        public bool IsBagno { get; set; }

        [Required]
        public int Metratura { get; set; }

        public int? AlloggioId { get; set; } = null!;
    }
}