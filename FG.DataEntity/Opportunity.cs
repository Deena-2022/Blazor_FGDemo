using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FG.DataEntity
{
    public class Opportunity
    {
        [Key]
        [Required]
        public string Customer { get; set; }
        [Required]
        public string Created { get; set; }
        [Required]
        public string Modified { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Name_Number { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Salesperson { get; set; }
        [Required]
        public string Action { get; set; }
        [Required]
        public string Due_Date { get; set; }
    }
}
