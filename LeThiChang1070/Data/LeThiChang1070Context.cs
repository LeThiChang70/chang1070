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
    }
}
