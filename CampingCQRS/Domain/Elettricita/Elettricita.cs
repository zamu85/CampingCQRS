using System;
using System.Collections.Generic;
using System.ComponentDomain.DataAnnotations;
using System.ComponentDomain.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Elettricita
{
    [Table("Elettricita")]
    public class Elettricita
    {
        [Required]
        public double Potenza { get; set; }

        [Key]
        public int IdElettricita { get; set; } = 0;
    }
}