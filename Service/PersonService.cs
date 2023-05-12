using System;
using System.Collections.Generic;
using EmergencyServices.Model;

namespace EmergencyServices.Service
{
    public class PersonService
    {
        private List<PersonModel> persons = new List<PersonModel>();

        public void AddToPersons(PersonModel person)
        {
            persons.Add(person);
        }

        public List<PersonModel> GetAllPersons()
        {
            return persons;
        }
    }
}
