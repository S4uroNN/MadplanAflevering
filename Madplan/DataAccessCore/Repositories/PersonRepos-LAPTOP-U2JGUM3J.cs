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
    internal class PersonRepos
    {
        public static Person GetPerson(int id)
        {
            using(CarContext context = new CarContext())
            {
                return PersonMapper.Map(context.Owners.Find(id));
            }
        }
    }
}
