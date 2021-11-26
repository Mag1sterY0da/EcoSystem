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
        public DbSet<Enterprice> Enterprices { get; set; }
        public DbSet<Lab> Labs { get; set; }
        public DbSet<Rec> Recs { get; set; }

        public EnterpriceContext(DbContextOptions options)
            : base(options)
        {
        }

    }
}
