using DataAccessCore.Context;
using DataAccessCore.Mapper;
using DTOCore.Model;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessCore.Repositories
{
    public class PersonRepos
    {
        public static Person GetPerson(int id)
        {
            using (CarContext context = new CarContext())
            {
                return PersonMapper.Map(context.Owners.Find(id));
            }
        }

        public static ObservableCollection<Person> GetToList()
        {
            using (CarContext context = new CarContext())
            {
                return PersonMapper.Map(context.Owners.ToList());

            }
        }

        public static void AddPerson(Person person)
        {
            using (CarContext context = new CarContext())
            {
                context.Owners.Add(PersonMapper.Map(person));
                context.SaveChanges();
            }
        }

        public static void DeletePerson(Person person)
        {
            using (CarContext context = new CarContext())
            {
                Model.Person datacar = context.Owners.Find(person.Id);
                context.Owners.Remove(datacar);
                context.SaveChanges();
            }
        }

        
    }
}
