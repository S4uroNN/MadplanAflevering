using DataAccessCore.Context;
using DataAccessCore.Mapper;
using DTOCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessCore.Repositories
{
    public class ServiceRepos
    {
        public static Service GetService(int id)
        {

            using (CarContext context = new CarContext())
            {
                return ServiceMapper.Map(context.Services.Find(id));
            }
        }

        public static void AddCarToService(Service service, Car car)
        {
            using (CarContext context = new CarContext())
            {
                Model.Service _service = context.Services.Find(service.Id);
                Model.Car _car = context.Cars.Find(car.ID);

                if(car !=null && service != null)
                {
                    _car.Service = _service;
                    context.SaveChanges();
                }
                
            }
        }
        public static void RemoveCarFromService(Service service, Car car)
        {
            using (CarContext context = new CarContext())
            {
                Model.Service _service = context.Services.Find(service.Id);
                Model.Car _car = context.Cars.Find(car.ID);

                if(car !=null && service !=null)
                {
                    _car.Service = null;
                    context.SaveChanges();
                }
            }
            
        }

    }
}
