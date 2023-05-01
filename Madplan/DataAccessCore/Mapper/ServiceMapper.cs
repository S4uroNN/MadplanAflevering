using DataAccessCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessCore.Mapper
{
    internal class ServiceMapper
    {
        public static DTOCore.Model.Service Map(Service service)
        {
            return new DTOCore.Model.Service(service.ID, service.Address);
        }

        public static Service Map(DTOCore.Model.Service service)
        {
            return new Service(service.Id, service.Address);
        }
    }
}
