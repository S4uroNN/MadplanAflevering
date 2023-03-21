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
        public ObservableCollection<Car> GetRetList() 
        {
            return CarRepos.GetToList();
        }

        public void AddRet(Car car)
        {
            CarRepos.AddRet(car);
        }
    }
}