using Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Elettricita
{
    [Table("Elettricita")]
    public class Elettricita : BaseEntity
    {
        [Required]
        public double Potenza { get; set; }
    }
}