using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeThiChang1070.Models
{
    public class DoctorLTC1070
    {
        [Key]
        [Required]
        [MaxLength(20)]
        public int DortorID { get; set; }
        [Required]
        [StringLength(50)]
        public string DoctorName { get; set; }
    }
}
