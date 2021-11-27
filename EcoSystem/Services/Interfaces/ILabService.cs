using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoSystem.Services.Interfaces
{
    public interface ILabService
    {
        IEnumerable<LabDTO> GetLabs(int page);
    }
}
