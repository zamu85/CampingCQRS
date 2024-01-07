using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Elettricita
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