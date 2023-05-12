using System;
using System.Collections.Generic;
using System.Linq;
using EmergencyServices.enums;
using EmergencyServices.Model;

namespace EmergencyServices.Service
{
    public class PoliceService
    {
        private List<PersonModel> PolicePersons = new List<PersonModel>();
        public void AddToPolicePersons(PersonModel person)
        {
            PolicePersons.Add(person);
        }
        public void EMessage()
        {
            ConsoleHelper.Message();
        }
        public List<PersonModel> GetMenPolice()
        {
            return PolicePersons.Where(x => x.Gender == Gender.Male).ToList();
        }
        public List<PersonModel> GetWomenPolice()
        {
            return PolicePersons.Where(x => x.Gender == Gender.Female).ToList();
        }
    }
}
