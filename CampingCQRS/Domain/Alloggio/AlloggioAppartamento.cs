using System.ComponentDomain.DataAnnotations;
using System.ComponentDomain.DataAnnotations.Schema;

namespace Domain.Alloggio
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