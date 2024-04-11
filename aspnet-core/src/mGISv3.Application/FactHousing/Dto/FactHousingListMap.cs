using AutoMapper;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mGISv3.FactHousing.Dto
{
    public class FactHousingListMap : Profile
    {
        public FactHousingListMap()
        {
            CreateMap<FactHousingList, FactHousings>();

        }
    }
}
