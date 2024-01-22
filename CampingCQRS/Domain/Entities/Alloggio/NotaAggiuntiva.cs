using Domain.Common.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Alloggio
{
    public class NotaAggiuntiva : IEntity
    {
        public int Id { get; set; }

        public string Testo { get; set; }

        [Required]
        [ForeignKey("Camera")]
        public Alloggio Alloggio { get; set; }
    }
}
