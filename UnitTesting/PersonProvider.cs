using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.Entities;
using UnitTesting.Interfaces;

namespace UnitTesting
{
    public class PersonProvider
    {
        private readonly IPersonRepository repository;

        public PersonProvider(IPersonRepository repository)
        {
            this.repository = repository;
        }

        public Person GetPerson(int id)
        {
            var result = repository.GetPerson(id);

            if (result == null)
                throw new Exception("Result is null");

            if (string.IsNullOrEmpty(result.FirstName))
                throw new Exception("FirstName is null or empty");

            if (string.IsNullOrEmpty(result.LastName))
                throw new Exception("LastName is null or empty");

            return result;
        }
    }
}
