using DataAccessCore.Repositories;
using DTOCore.Model;
using System.Collections.ObjectModel;

namespace BusinessLogicCore.BLL
{
    public class CarBLL
    {
        public Car GetRet(int id)
        {
            return CarRepos.GetRet(id);
        }
        public ObservableCollection<Car> GetRetList() 
        {
            return CarRepos.GetToList();
        }

        public void AddRet(Car ret)
        {
            CarRepos.AddRet(ret);
        }
    }
}