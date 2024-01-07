using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Model.Alloggio
{
    public class Alloggio
    {
        public int IdAlloggio { get; set; }

        public string NomeAlloggio { get; set; }

        public int Superficie { get; set; }

        public string NumeroAlloggio { get; set; }

        public bool CaneAmmesso { get; set; }

        public Elettricita.Elettricita Elettricita { get; set; } = null;

    }
}