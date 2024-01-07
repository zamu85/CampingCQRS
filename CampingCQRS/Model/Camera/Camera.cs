using System.ComponentModel.DataAnnotations;

namespace Model.Camera;

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