using DataAccessCore.Model;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessCore.Mapper
{
    internal class CarMapper
    {
        public static DTOCore.Model.Car Map(Car car)
        {
            return new DTOCore.Model.Car(car.ID, car.Make, car.Model, car.Milage,car.Year,car.MOT);
        }
        public static Car Map(DTOCore.Model.Car car)
        {
            return new Car(car.ID, car.Make, car.Model, car.Milage, car.Year, car.MOT);
        }


        public static ObservableCollection<DTOCore.Model.Car> Map(List<Car> cars)
        {
            ObservableCollection<DTOCore.Model.Car> retur = new ObservableCollection<DTOCore.Model.Car>();
            foreach (Car car in cars)
            {
                retur.Add(CarMapper.Map(car));
            }
            return retur;
        }
        public static List<DTOCore.Model.Car> MapList(List<Car> cars)
        {
            List<DTOCore.Model.Car> retur = new List<DTOCore.Model.Car>();
            foreach (Car car in cars)
            {
                retur.Add(CarMapper.Map(car));
            }
            return retur;
        }

        public static void Update(DTOCore.Model.Car car, Car datacar)
        {
            datacar.Make = car.Make;
            datacar.Model = car.Model;
            datacar.Milage = car.Milage;
            datacar.MOT = car.MOT;
        }


    }
}
