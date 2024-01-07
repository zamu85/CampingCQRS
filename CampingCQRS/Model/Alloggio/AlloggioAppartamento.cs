using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Alloggio
{
    public class AlloggioAppartamento : Alloggio
    {
        [Required]
        public int PostiDisponibili { get; set; }

        [Required]
        [ForeignKey("Camera")]
        public IList<Camera.Camera> Camere { get; set; } = new List<Camera.Camera>();

        public IList<string> NoteAggiuntive { get; set; } = new List<string>();

    }
}