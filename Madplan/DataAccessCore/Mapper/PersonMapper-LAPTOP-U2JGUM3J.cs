using DataAccessCore.Model;
using System;
using System.Collections.Generic;
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
    }
}
