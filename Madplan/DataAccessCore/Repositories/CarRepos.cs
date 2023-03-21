using DataAccessCore.Context;
using DataAccessCore.Mapper;
using DTOCore.Model;
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

        public static ObservableCollection<Car> GetToList() 
        {
            using(CarContext context = new CarContext())
            {
                return CarMapper.Map(context.Cars.ToList());
     
            }
        }

        public static void AddRet(Car car)
        {
            using (CarContext context = new CarContext())
            {
                context.Cars.Add(CarMapper.Map(car));
                context.SaveChanges();
            }
        }
    }
}
