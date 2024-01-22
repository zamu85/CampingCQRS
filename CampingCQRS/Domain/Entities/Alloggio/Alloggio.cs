using Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Alloggio
{
    [Table("Alloggi")]
    public class Alloggio : BaseEntity
    {
        [Required]
        public string NomeAlloggio { get; set; }

        [Required]
        public int Superficie { get; set; }

        [Required]
        public string NumeroAlloggio { get; set; }

        [Required]
        public bool CaneAmmesso { get; set; }

        public Elettricita.Elettricita? Elettricita { get; set; }

        public ICollection<NotaAggiuntiva> NoteAggiuntive { get; set; } = new List<NotaAggiuntiva>();
    }
}