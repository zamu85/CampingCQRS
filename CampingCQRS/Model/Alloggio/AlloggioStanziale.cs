using System.Net.NetworkInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Alloggio
{
    public class AlloggioStanziale : Alloggio
    {
        public int PostiDisponibili { get; set; }

        public IList<Camera> Camere { get; set; } = new List<Camera>();

        public IList<string> NoteAggiuntive { get; set; } = new List<string>();

    }

    public class Camera
    {
        public int IdCamera { get; set; }

        public bool IsMatrimoniale { get; set; }

        public bool LettoSingola { get; set; }

        public bool IsBagno { get; set; }
    }
}