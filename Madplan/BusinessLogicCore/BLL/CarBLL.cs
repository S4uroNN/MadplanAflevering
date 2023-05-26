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
        public ObservableCollection<Car> GetCarListObserv()
        {
            return CarRepos.GetToListObserver();
        }
        public List<Car> GetCarList()
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

        public void UpdateCar(Car car) 
        {
            CarRepos.EditCar(car);
        }


        public ObservableCollection<Person> GetPersonel()
        {
            return PersonRepos.GetToList();
        }

        public void AddPerson(Person person)
        {
            PersonRepos.AddPerson(person);
        }
        public void RemovePerson(Person person)
        {
            PersonRepos.DeletePerson(person);
        }

        public Service GetService(int id)
        {
            return ServiceRepos.GetService(id);
        }

        public void AddCarToService(Service service, Car car)
        {
            ServiceRepos.AddCarToService(service, car);  
        }

        public void DeleteCarFromService(Service service, Car car)
        {
            ServiceRepos.RemoveCarFromService(service, car);
        }

        public ObservableCollection<Car> GetCarsInService()
        {
            return CarRepos.GetCarsInService();
        }
    }
}