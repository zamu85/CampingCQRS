using System.ComponentDomain.DataAnnotations;
using System.ComponentDomain.DataAnnotations.Schema;

namespace Domain.Camera;

[Table("Camere")]

public class Camera
{
    [Key]
    public int IdCamera { get; set; }

    [Required]
    public bool IsMatrimoniale { get; set; }

    [Required]
    public bool LettoSingola { get; set; }

    [Required]
    public bool IsBagno { get; set; }
}