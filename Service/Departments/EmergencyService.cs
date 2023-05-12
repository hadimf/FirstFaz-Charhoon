using System;
using System.Collections.Generic;
using EmergencyServices.Model;

namespace EmergencyServices.Service
{
    public class EmergencyService
    {
        private List<PersonModel> EmergencyPersons = new List<PersonModel>();
        public void AddToEmergencyPersons(PersonModel person)
        {
            EmergencyPersons.Add(person);
        }
        public void EMessage()
        {
            ConsoleHelper.Message();
        }
        public List<PersonModel> GetAllEmergencyPersons()
        {
            return EmergencyPersons;
        }
    }
}
