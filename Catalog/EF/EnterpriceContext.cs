using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class EnterpriceContext
        : DbContext
    {
        public DbSet<Enterprice> Phones { get; set; }
        public DbSet<Lab> Orders { get; set; }
        public DbSet<Rec> Numbers { get; set; }
​
        public EnterpriceContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}
