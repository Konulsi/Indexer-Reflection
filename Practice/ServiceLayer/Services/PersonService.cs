using DomainLayer.Models;
using ServiceLayer.Exceptions;
using ServiceLayer.Helpers.Constants;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class PersonService : IPersonService
    {
        private List<Person> GetAll()
        {
            List<Person> people = new List<Person>(); //bow list yaradiriq

            Person person1 = new Person()  // sonra obyektleri elave edirik
            {
                Id = 1,
                Name = "Konul",
                Surname = "Ibrahimova",
                Salary = 250
            };

            Person person2 = new Person()
            {
                Id = 2,
                Name = "Shaig",
                Surname = "Ibrahimov",
                Salary = 350
            };

            Person person3 = new Person()
            {
                Id = 3,
                Name = "Chinara",
                Surname = "Ibadova",
                Salary = 200
            };

            Person person4 = new Person()
            {
                Id = 4,
                Name = "Ferid",
                Surname = "Abdullayev",
                Salary = 2500
            };

            Person person5 = new Person()
            {
                Id = 5,
                Name = "Kenan",
                Surname = "Abdullayev",
                Salary = 500
            };

            people.Add(person1);  //people listine personlari tek tek elavee edirik
            people.Add(person2);    
            people.Add(person3);
            people.Add(person4);
            people.Add(person5);

            return people;

        }

        public List<Person> GetPeopleByCondition(Predicate<Person> predicate)
        {
            
            var result = new List<Person>();
            try
            {
                result = GetAll().FindAll(predicate);
                if (result.Count==0)
                {
                    throw new InvalidPersonException(ResponsMessage.PersonError);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           

            return result;
        
        }
    }
}
