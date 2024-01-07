namespace Model.Alloggio
{
    public class AlloggioStanziale : Alloggio
    {
        public int PostiDisponibili { get; set; }

        public IList<Camera.Camera> Camere { get; set; } = new List<Camera.Camera>();

        public IList<string> NoteAggiuntive { get; set; } = new List<string>();

    }
}