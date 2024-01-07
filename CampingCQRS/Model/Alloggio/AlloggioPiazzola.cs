using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Alloggio
{
    public class AlloggioPiazzola : Alloggio
    {
        public bool SoloTenda { get; set; } = false;

        public bool AcquaInPiazzola { get; set; } = false;
    }
}