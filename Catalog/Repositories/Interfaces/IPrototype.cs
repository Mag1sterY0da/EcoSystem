using DAL.Repositories.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    internal abstract class IPrototype
    {       
        public abstract Prototype Clone();
    }
}
