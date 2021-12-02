using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface IRecRepository
        : IRepository<Rec>
    {
        void CloneRecNoPull(int id)
        {
        }
        void CloneRecPull(int id)
        {

        }
            
    }

}
