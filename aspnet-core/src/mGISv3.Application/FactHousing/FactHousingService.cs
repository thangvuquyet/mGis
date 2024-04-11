using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using mGISv3.Authorization;
using mGISv3.FactHousing.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mGISv3.FactHousing
{
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class FactHousingService : AsyncCrudAppService<FactHousings, FactHousingList, Guid>, IFactHousingService
    {

        public FactHousingService(IRepository<FactHousings, Guid> repository) : base(repository) { }
    }
}
