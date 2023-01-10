using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IPersonService
    {

        List<Person> GetPeopleByCondition(Predicate<Person> predicate);
    }
}
