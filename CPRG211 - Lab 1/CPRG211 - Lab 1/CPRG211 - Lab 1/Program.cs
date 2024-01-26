using System.Diagnostics;
using System.Diagnostics.Metrics;
using static CPRG211___Lab_1.Program;

//Created by Christopher Duke
namespace CPRG211___Lab_1
{
     class Program
    {
        static void Main(string[] args)
        {
            //Declare person Objects
            Person person1 = new Person { personId = 1, firstName = "Ian", lastName = "Brooks", favoriteColour = "Red", age = 30, isWorking = true };
            Person person2 = new Person { personId = 2, firstName = "Gina", lastName = "James", favoriteColour = "Green", age = 18, isWorking = false };
            Person person3 = new Person { personId = 3, firstName = "Mike", lastName = "Briscoe", favoriteColour = "Blue", age = 45, isWorking = true };
            Person person4 = new Person { personId = 4, firstName = "Mary", lastName = "Beals", favoriteColour = "Yellow", age = 28, isWorking = true };
            Relation relation1 = new Relation { RelationshipType = "Sister" };
            Relation relation2 = new Relation { RelationshipType = "Brother" };
            //Call Methods in other classes based upon declared objects
            Person.DisplayPersonInfo(person2);
            Person.ToString(person3);
            Person.ChangeFavoriteColour(person1);
            Person.DisplayPersonInfo(person1);
            Person.GetAgeInTenYears(person4);
            Relation.ShowRelationShip(person2, person4, relation1);
            Relation.ShowRelationShip(person1, person3, relation2);

            //Add all created person objects to list
            List<Person> people = new List<Person> { person1, person2, person3, person4 };

            //Add all Age values and output average
            double averageAge = people.Average(p => p.age);
            Console.WriteLine($"Average age is: {averageAge}");

           //Order list by lowest age value and output lowest age firstname
            Person youngest = people.OrderBy(p => p.age).First();
            Console.WriteLine($"The youngest person is: {youngest.firstName}");

            //Order list by Highest Age value and output Highest Age firstname
            Person oldest = people.OrderBy(p => p.age).Last();
            Console.WriteLine($"The oldest person is: {oldest.firstName}");

            //Iterate through list, find all first names that start with M, output all attributes using ToString
            foreach(Person person in people)
            {
                if (person.firstName.StartsWith("M"))
                {
                    Person.ToString(person);
                }
            }

            //Iterate through list find all favorite colors that match Blue, output all attributes of match using ToString
            foreach (Person person in people)
            {
                if (person.favoriteColour == "Blue")
                {
                    Person.ToString(person);
                }
            }

        }

        
        

    }
}


