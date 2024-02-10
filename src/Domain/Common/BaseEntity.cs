using Domain.Common.Interfaces;

namespace Domain.Common
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
