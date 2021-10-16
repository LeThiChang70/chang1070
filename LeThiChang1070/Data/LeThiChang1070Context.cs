using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LeThiChang1070.Models;

namespace LeThiChang1070.Data
{
    public class LeThiChang1070Context : DbContext
    {
        public LeThiChang1070Context (DbContextOptions<LeThiChang1070Context> options)
            : base(options)
        {
        }

        public DbSet<LeThiChang1070.Models.PersonLTC1070> PersonLTC1070 { get; set; }

        public DbSet<LeThiChang1070.Models.TeacherLTC1070> TeacherLTC1070 { get; set; }

        public DbSet<LeThiChang1070.Models.DoctorLTC1070> DoctorLTC1070 { get; set; }

        public DbSet<LeThiChang1070.Models.MotherLTC1070> MotherLTC1070 { get; set; }
    }
}
