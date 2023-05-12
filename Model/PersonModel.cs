using System;
using EmergencyServices.enums;

namespace EmergencyServices.Model
{
    public class PersonModel
    {
        public string FullName { get; set; }
        public Gender Gender { get; set; }
        public string NationalId { get; set; }
        public string Address { get; set; }
        public Accident Injury { get; set; }
        

    }
}
