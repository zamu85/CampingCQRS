using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Alloggio
{
    public class AlloggioPiazzola : Alloggio
    {
        [Required]
        public bool SoloTenda { get; set; } = false;

        [Required]
        public bool AcquaInPiazzola { get; set; } = false;
    }
}