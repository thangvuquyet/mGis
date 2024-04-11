using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mGISv3.FactHousing
{
    public class FactHousings : FullAuditedEntity<Guid>
    {
        public long HouseID { get; set; }

        public long DateID { get; set; }

        public string Address { get; set; }

        public long WardID { get; set; }

        public long HouseTypeID { get; set; }

        public long CertID { get; set; }

        public long Floor { get; set; }

        public long No_Room { get; set; }

        public long Area { get; set; }

    }
}
