using DataAccessCore.Model;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessCore.Mapper
{
    internal class CarMapper
    {
        public static DTOCore.Model.Car Map(Car car)
        {
            return new DTOCore.Model.Car(car.ID, car.Make, car.Model, car.Milage, car.Owners);
        }
        public static Car Map(DTOCore.Model.Car car)
        {
            return new Car(car.ID, car.Make, car.Model, car.Milage, car.Owners);
        }

        public static ObservableCollection<DTOCore.Model.Car> Map(List<Car> rets)
        {
            ObservableCollection<DTOCore.Model.Car> retur = new ObservableCollection<DTOCore.Model.Car>();
            foreach (Car ret in rets)
            {
                retur.Add(CarMapper.Map(ret));
            }
            return retur;
        }

        public static void Update(DTOCore.Model.Car car, Car datacar)
        {
            datacar.Make = car.Make;
            datacar.Model = car.Model;
            datacar.Milage = car.Milage;
            datacar.Owners = car.Owners;
        }


    }
}
