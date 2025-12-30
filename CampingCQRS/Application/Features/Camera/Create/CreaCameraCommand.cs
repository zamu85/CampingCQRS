using Application.Abstractions.Messaging;

namespace Application.Features.Camera.Create
{
    public record CreaCameraCommand : ICommand<int>
    {
        public bool IsMatrimoniale { get; set; }

        public bool LettoSingola { get; set; }

        public bool IsBagno { get; set; }

        public int Metratura { get; set; }
    }
}
