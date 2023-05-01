using DataAccessCore.Repositories;
using DTOCore.Model;
using System.Collections.ObjectModel;

namespace BusinessLogicCore.BLL
{
    public class CarBLL
    {
        public Car GetCar(string make)
        {
            return CarRepos.GetCar(make);
        }
        public ObservableCollection<Car> GetCarList()
        {
            return CarRepos.GetToList();
        }

        public void AddCar(Car car)
        {
            CarRepos.AddCar(car);
        }

        public void RemoveCar(Car car)
        {
            CarRepos.DeleteCar(car);
        }
    }
}