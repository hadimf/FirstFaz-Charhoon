using System;
using System.Collections.Generic;
using EmergencyServices.enums;
using EmergencyServices.Model;

namespace EmergencyServices
{
    public class ConsoleHelper
    {
        public static Request GetRequest()
        {
            Console.WriteLine("Which one do u want?");
            Console.WriteLine("1.Service 2.Report");
            Request request = (Request)Enum.Parse(typeof(Request), Console.ReadLine());
            return request;
        }

        // Get Person Information
        public static string GetPersonAddress()
        {
            Console.WriteLine("what is your address ?");
            return Console.ReadLine();
        }

        public static string GetPersonFullName()
        {
            Console.WriteLine("What is your full name ?");
            return Console.ReadLine();
        }

        public static Gender GetPersonGender()
        {
            Console.WriteLine("What is your gender ?");
            Console.WriteLine("1.Male 2.Female");
            Gender gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine());
            return gender;
        }

        public static string GetPersonNationId()
        {
            Console.WriteLine("what is your national id?");
            return Console.ReadLine();
        }
        public static Accident GetPersonAccident()
        {
            Console.WriteLine("which on is happened ?");
            Console.WriteLine("1.theft");
            Console.WriteLine("2.fire");
            Console.WriteLine("3.breathlessness");
            return (Accident)Enum.Parse(typeof(Accident), Console.ReadLine());
        }

        public static Report ReportOptions()
        {
            Console.WriteLine("1.All Report");
            Console.WriteLine("2.FireStation Report");
            Console.WriteLine("3.Emergency Report");
            Console.WriteLine("4.Police Men Report");
            Console.WriteLine("5.Police Women Report");
            return (Report)Enum.Parse(typeof(Report), Console.ReadLine());
        }

        public static void ShowPersons(List<PersonModel> persons)
        {
            foreach (var person in persons)
            {
                Console.WriteLine("Name : " + person.FullName);
                Console.WriteLine("Gender : " + person.Gender);
                Console.WriteLine("National Id : " + person.NationalId);
                Console.WriteLine("Injury : " + person.Injury);
                Console.WriteLine("Address : " + person.Address);
            }
        }
        public static void Message()
        {
            Console.Clear();
            Console.WriteLine("Our troops will be sent to the place soon");
        }

        public static void NotValid()
        {
            Console.WriteLine("Not Valid!!!");
            Console.WriteLine("try Again...");
        }
    }
}
