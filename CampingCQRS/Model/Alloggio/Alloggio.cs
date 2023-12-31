using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Alloggio
{
    [Table("Alloggi")]
    public class Alloggio
    {
        [Key]
        public int IdAlloggio { get; set; }

        [Required]
        public string NomeAlloggio { get; set; }

        [Required]
        public int Superficie { get; set; }

        [Required]
        public string NumeroAlloggio { get; set; }

        [Required]
        public bool CaneAmmesso { get; set; }

        [ForeignKey("Elettricita")]
        public Elettricita.Elettricita Elettricita { get; set; } = null!;

    }
}