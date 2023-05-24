using DataAccessCore.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessCore.Mapper
{
    internal class PersonMapper
    {
        public static DTOCore.Model.Person Map(Person person)
        {
            return new DTOCore.Model.Person(person.Id, person.Name, person.Age);
        }
        public static Person Map(DTOCore.Model.Person person)
        {
            return new Person(person.Id, person.Name, person.Age);

        }

        public static ObservableCollection<DTOCore.Model.Person> Map(List<Person> owners)
        {
            ObservableCollection<DTOCore.Model.Person> retur = new ObservableCollection<DTOCore.Model.Person>();
            foreach (Person owner in owners)
            {
                retur.Add(PersonMapper.Map(owner));
            }
            return retur;
        }
    }
}
