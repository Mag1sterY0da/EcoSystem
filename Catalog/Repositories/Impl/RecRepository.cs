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
        public Prototype CloneRecPull(int id, string Date, Boolean Pollution, string Pollution_type, int Pollution_metrics)
        {            
            Prototype prototype = new ConcretePrototype1(id, Date, Pollution, Pollution_type, Pollution_metrics);
            Prototype clone = prototype.Clone();
            return clone;
        }
        public Prototype CloneRecNoPull(int id, string Date, Boolean Pollution, string Pollution_type)
        {
            Prototype prototype = new ConcretePrototype2(id, Date, Pollution, Pollution_type);
            Prototype clone = prototype.Clone();
            return clone;
        }
    }
}
