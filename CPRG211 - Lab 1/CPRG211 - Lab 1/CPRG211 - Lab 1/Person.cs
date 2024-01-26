using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211___Lab_1
{
    public class Person
    {

        // Declare Public Variables
        public int personId;
        public string firstName;
        public string lastName;
        public string favoriteColour;
        public int age;
        public bool isWorking;

        // Method to Write Full name and Favorite Color of person object
        public static void DisplayPersonInfo(Person person)
        {
            string name = person.firstName + " " + person.lastName;
            Console.WriteLine($"{person.personId}: {name}'s favorite color is {person.favoriteColour}");
        }

        // Method to change favorite color of Person Object to White
        public static void ChangeFavoriteColour(Person person)
        {
            string name = person.firstName + " " + person.lastName;
            string newColor = "White";
            person.favoriteColour = newColor;
        }

        // Method to add 10 to person object Age
        public static void GetAgeInTenYears(Person person)
        {
            int newAge = person.age + 10;
            string name = person.firstName + " " + person.lastName;
            Console.WriteLine($"{name} Age in 10 years is {newAge}");
        }
        // Method to Write all parameters of person object to console
        public static void ToString(Person person)
        {
            Console.WriteLine($"PersonId: {person.personId}");
            Console.WriteLine($"FirstName: {person.firstName}");
            Console.WriteLine($"LastName: {person.lastName}");
            Console.WriteLine($"FavoriteColour: {person.favoriteColour}");
            Console.WriteLine($"Age: {person.age}");
            Console.WriteLine($"IsWorking: {person.isWorking}");
        }
    }
}
