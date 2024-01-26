using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211___Lab_1
{
    public class Relation
    {
        //Declare Variable
        public string RelationshipType;


        //Create Enum with valid Relationship types
        public enum Relationships
        {
            Sister,
            Brother,
            Father,
            Mother
        }
        //Method to Determine Relationship between two person objects
        public static void ShowRelationShip(Person person1, Person person2, Relation relations)
        {
            //String for Title of Relationship
            string relationship = "";
            //Receive RelationshipType variable
            string relationshipInput = relations.RelationshipType;

            // Check if Input of Relationship is found within enum (non case sensitive)
            if (Enum.TryParse<Relationships>(relationshipInput,true,out Relationships validRelationship))
            {
                // once determined valid input determine Relationship name
                if (validRelationship == Relationships.Sister)
                {
                    relationship = "Sisterhood";
                }
                else if (validRelationship == Relationships.Brother)
                {
                    relationship = "Brotherhood";

                }
                else if (validRelationship == Relationships.Mother || validRelationship == Relationships.Father)
                {
                    relationship = "Parent/Child";
                }
            }
            // Catch Unknown Inputs
            else
            {
                relationship = "Unknown";
            }


            // Write output to console when called
            Console.WriteLine($"Relationship between {person1.firstName} and {person2.firstName} is: {relationship}");

        }
    }
}
