using DAL.Entities;
using DAL.Repositories.Impl;
using DAL.Repositories.Interfaces;
using DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class EFUnitOfWork
        : IUnitOfWork
    {
        private EnterpriceContext db;
        private EnterpriceRepository enterpriceRepository;
        private LabRepository labRepository;
        private RecRepository recRepository;

        public EFUnitOfWork(DbContextOptions options)
        {
            db = new EnterpriceContext(options);
        }
        public IRepository<Enterprice> Enterprices
        {
            get
            {
                if (enterpriceRepository == null)
                    enterpriceRepository = new EnterpriceRepository(db);
                return enterpriceRepository;
            }
        }
​
        public IRepository<Lab> Labs
        {
            get
            {
                if (labRepository == null)
                    labRepository = new LabRepository(db);
                return labRepository;
            }
        }
        public IRepository<Rec> Recs
        {
            get
            {
                if (recRepository == null)
                    recRepository = new RecRepository(db);
                return recRepository;
            }
        }

        IEnterpriceRepository IUnitOfWork.Enterprices => throw new NotImplementedException();

        ILabRepository IUnitOfWork.Labs => throw new NotImplementedException();

        IRecRepository IUnitOfWork.Recs => throw new NotImplementedException();

        public void Save()
        {
            db.SaveChanges();
        }
​
        private bool disposed = false;
​
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }
​
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
