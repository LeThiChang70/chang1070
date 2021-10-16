using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeThiChang1070.Models
{
    public class MotherLTC1070
    {
        [Key]
        [Required]
        [StringLength(20)]
        public string MotherID { get; set; }
        [Required]
        [StringLength(50)]
        public string MotherName { get; set; }
    }
}
