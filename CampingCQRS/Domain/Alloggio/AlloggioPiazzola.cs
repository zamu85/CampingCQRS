using System;
using System.Collections.Generic;
using System.ComponentDomain.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Alloggio
{
    public class AlloggioPiazzola : Alloggio
    {
        [Required]
        public bool SoloTenda { get; set; } = false;

        [Required]
        public bool AcquaInPiazzola { get; set; } = false;
    }
}