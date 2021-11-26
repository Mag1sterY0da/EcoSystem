using DAL.Entities;
using DAL.Repositories.Impl;
using DAL.Repositories.Interfaces;
using DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;

namespace DAL.EF
{
    public class EFUnitOfWork
        : IUnitOfWork
    {
        private EnterpriceContext db;
        private EnterpriceRepository EnterpriceRepository;
        private LabRepository LabRepository;
        private RecRepository RecRepository;

        public EFUnitOfWork(EnterpriceContext context)
        {
            db = context;
        }
        public IEnterpriceRepository Enterprices
        {
            get
            {
                if (EnterpriceRepository == null)
                    EnterpriceRepository = new EnterpriceRepository(db);
                return EnterpriceRepository;
            }
        }

        public ILabRepository Labs
        {
            get
            {
                if (LabRepository == null)
                    LabRepository = new LabRepository(db);
                return LabRepository;
            }
        }

        public IRecRepository Recss
        {
            get
            {
                if (RecRepository == null)
                    RecRepository = new RecRepository(db);
                return RecRepository;
            }
        }

        IEnterpriceRepository IUnitOfWork.Enterprices => throw new NotImplementedException();

        ILabRepository IUnitOfWork.Labs => throw new NotImplementedException();

        IRecRepository IUnitOfWork.Recs => throw new NotImplementedException();

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

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

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        void IUnitOfWork.Save()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}