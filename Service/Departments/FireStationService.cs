using System;
using System.Collections.Generic;
using EmergencyServices.Model;

namespace EmergencyServices.Service
{
    public class FireStationService
    {
        private List<PersonModel> FireStationPersons = new List<PersonModel>();
        public void AddToFireStationPersons(PersonModel person)
        {
            FireStationPersons.Add(person);
        }
        public void EMessage()
        {
            ConsoleHelper.Message();
        }
        public List<PersonModel> GetAllFireStationPersons()
        {
            return FireStationPersons;
        }

    }
}
