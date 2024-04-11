using Abp.Application.Services;
using mGISv3.FactHousing.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mGISv3.FactHousing
{
    public interface IFactHousingService : IAsyncCrudAppService<FactHousingList, Guid>
    {
    }
}
