using DAL.EF;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Impl
{
    public class RecRepository
       : BaseRepository<Rec>, IRecRepository
    {
        public RecRepository(DbContext context) : base(context)
        {
        }

        internal RecRepository(EnterpriceContext context)
            : base(context)
        {
        }
    }
}
