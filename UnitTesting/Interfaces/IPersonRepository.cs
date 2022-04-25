using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.Entities;

namespace UnitTesting.Interfaces
{
    public interface IPersonRepository
    {
        public Person GetPerson(int id);
    }
}
