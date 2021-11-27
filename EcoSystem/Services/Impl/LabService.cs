using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoSystem.Services.Impl
{
    public class LabService
       : ILabService
    {
        private readonly IUnitOfWork _database;
        private int pageSize = 10;
​
        public LabService(
            IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            _database = unitOfWork;
        }
​
        /// <exception cref="MethodAccessException"></exception>
        public IEnumerable<LabDTO> GetStreets(int pageNumber)
        {
            var user = SecurityContext.GetUser();
            var userType = user.GetType();
            if (userType != typeof(Director)
                && userType != typeof(Accountant))
            {
                throw new MethodAccessException();
            }
            var osbbId = user.OSBBID;
            var streetsEntities =
                _database
                    .Streets
                    .Find(z => z.OSBBID == osbbId, pageNumber, pageSize);
            var mapper =
                new MapperConfiguration(
                    cfg => cfg.CreateMap<Street, StreetDTO>()
                    ).CreateMapper();
            var streetsDto =
                mapper
                    .Map<IEnumerable<Street>, List<StreetDTO>>(
                        streetsEntities);
            return streetsDto;
        }
    }
}
