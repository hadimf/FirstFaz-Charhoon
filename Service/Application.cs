using System;
using System.Text.RegularExpressions;
using EmergencyServices.enums;
using EmergencyServices.Model;
using EmergencyServices.Service;

namespace EmergencyServices
{
    public class Application
    {
        static PersonService personService = new PersonService();
        static PoliceService police = new PoliceService();
        static FireStationService fireStation = new FireStationService();
        static EmergencyService emergency = new EmergencyService();


        public void AskRequest()
        {
            Request request;
            do
            {
                request = ConsoleHelper.GetRequest();
                CheckRequest(request);

            } while (request == Request.Service);
        }
        private static void CheckRequest(Request request)
        {
            switch (request)
            {
                case Request.Service:
                    PersonModel person = new PersonModel();
                    // Get information from person and Validating

                    person.FullName = ValidateIsString(ConsoleHelper.GetPersonFullName());
                    person.Gender = ValidateIsGender(ConsoleHelper.GetPersonGender());
                    person.NationalId = ValidateIsNationalId(ConsoleHelper.GetPersonNationId());
                    person.Address = ConsoleHelper.GetPersonAddress();
                    person.Injury = ValidateIsAccident(ConsoleHelper.GetPersonAccident());
                    CheckDepartment(person.Injury, person);
                    break;

                case Request.Report:
                    CheckReport(ConsoleHelper.ReportOptions());

                    break;
            }
        }

        private static void CheckReport(Report report)
        {
            switch (report)
            {
                case Report.AllReport:
                    ConsoleHelper.ShowPersons(personService.GetAllPersons());
                    break;
                case Report.FireStationReport:
                    ConsoleHelper.ShowPersons(fireStation.GetAllFireStationPersons());
                    break;
                case Report.EmergencyReport:
                    ConsoleHelper.ShowPersons(emergency.GetAllEmergencyPersons());
                    break;
                case Report.PoliceMenReport:
                    ConsoleHelper.ShowPersons(police.GetMenPolice());
                    break;
                case Report.PoliceWomenReport:
                    ConsoleHelper.ShowPersons(police.GetWomenPolice());
                    break;
                default:
                    ConsoleHelper.NotValid();
                    break;
            }
        }


        private static void CheckDepartment(Accident accident, PersonModel personModel)
        {
            personService.AddToPersons(personModel);
            switch (accident)
            {
                case Accident.Theft:
                    police.AddToPolicePersons(personModel);
                    police.EMessage();
                    break;
                case Accident.Fire:
                    fireStation.AddToFireStationPersons(personModel);
                    fireStation.EMessage();
                    break;
                case Accident.Breathlessness:
                    emergency.AddToEmergencyPersons(personModel);
                    emergency.EMessage();
                    break;

            }
        }

        // Validate Methods
        private static string ValidateIsString(string input)
        {
            bool isValid = Regex.IsMatch(input, @"^[a-zA-Z\s]+$");
            while (!isValid)
            {
                ConsoleHelper.NotValid();
                input = ConsoleHelper.GetPersonFullName();
                isValid = Regex.IsMatch(input, @"^[a-zA-Z\s]+$");
            }

            return input;
        }
        private static Gender ValidateIsGender(Gender gender)
        {
            bool isValid = Enum.IsDefined(typeof(Gender), gender);
            while (!isValid)
            {
                ConsoleHelper.NotValid();
                gender = ConsoleHelper.GetPersonGender();
                isValid = Enum.IsDefined(typeof(Gender), gender);
            }
            return gender;
        }
        private static string ValidateIsNationalId(string input)
        {
            bool isValid = Regex.IsMatch(input, @"^\d{10}$");
            while (!isValid)
            {
                ConsoleHelper.NotValid();
                input = ConsoleHelper.GetPersonNationId();
                isValid = Regex.IsMatch(input, @"^\d{10}$");
            }
            return input;
        }
        private static Accident ValidateIsAccident(Accident accident)
        {
            bool isValid = Enum.IsDefined(typeof(Accident), accident);
            while (!isValid)
            {
                ConsoleHelper.NotValid();
                accident = ConsoleHelper.GetPersonAccident();
                isValid = Enum.IsDefined(typeof(Accident), accident);
            }
            return accident;
        }

    }
}
