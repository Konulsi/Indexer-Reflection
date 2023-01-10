using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Controllers
{
    public class PersonController
    {
        private readonly IPersonService _service;

        public PersonController()
        {
            _service = new PersonService();

        }

        public void GetPersonBySalary()
        {

            var result = _service.GetPeopleByCondition(m => m.Salary > 1000);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name}  {item.Surname}");
            }
        }


    }
}
