using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Camera;

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