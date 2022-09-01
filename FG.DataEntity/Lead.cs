using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FG.DataEntity
{
    public class Lead
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Letters only allowed")]
        public string Lname { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Letters only allowed")]
        public string LProject_Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9''-'\s]{1,40}$", ErrorMessage = "Letters only allowed")]
        public string LStatus { get; set; }
        [Required]
        public string LAdded { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Letters only allowed")]
        public string LType { get; set; }
        [Required]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string LContact { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Letters only allowed")]
        public string LAction { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Letters only allowed")]
        public string LAssignee { get; set; }
        [Required]
        public string LBid_Date { get; set; }
        [Required]
        [Key]
        public int Lid { get; set; }
    }
}
