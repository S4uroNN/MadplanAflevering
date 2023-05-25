using DataAccessCore.Context;
using DataAccessCore.Mapper;
using DTOCore.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessCore.Repositories
{
    public class CarRepos
    {
        public static Car GetCar(string make)
        {

            using (CarContext context = new CarContext())
            {
                return CarMapper.Map(context.Cars.Find(make));
            }
        }

        public static ObservableCollection<Car> GetToListObserver()
        {
            using (CarContext context = new CarContext())
            {
                return CarMapper.Map(context.Cars.ToList());

            }
        }
        public static List<Car> GetToList()
        {
            using (CarContext context = new CarContext())
            {
                return CarMapper.MapList(context.Cars.ToList());

            }
        }

        public static void AddCar(Car car)
        {
            using (CarContext context = new CarContext())
            {
                context.Cars.Add(CarMapper.Map(car));
                context.SaveChanges();
            }
        }

        public static void EditCar(Car car)
        {
            using (CarContext context = new CarContext())
            {
                Model.Car datacar = context.Cars.Find(car.ID);
                CarMapper.Update(car, datacar);

                context.SaveChanges();
            }
        }

        public static void DeleteCar(Car car)
        {
            using (CarContext context = new CarContext())
            {
                Model.Car datacar = context.Cars.Find(car.ID);
                context.Cars.Remove(datacar);
                context.SaveChanges();
            }
        }
        public static ObservableCollection<Car> GetCarsInService()
        {
            using (CarContext context = new CarContext())
            {
                return CarMapper.Map(context.Cars.Where(e => e.Service.ID == 1).ToList());

            }
        }

    }
}

