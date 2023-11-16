using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            var bigBird = new Bird();
            bigBird.CanFly = true;
            bigBird.Colors = "Yellow";
            bigBird.BeakType = "Cone";
            bigBird.TailType = "Turkey";


            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            var puffTheMagicDragon = new Reptile();
            
            puffTheMagicDragon.IsColdBlooded = true;
            puffTheMagicDragon.Color = "Green";
            puffTheMagicDragon.IsVenomous = false;
            puffTheMagicDragon.Habitat = "Land of Honnalee";

            var myAnimals = new Animal[] { bigBird, puffTheMagicDragon };


            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"{animal.GetType().Name} has {animal.NumberOfLegs} legs");
                Console.WriteLine($"{animal.GetType().Name} is a {animal.LandOrSea} animal.");
                Console.WriteLine($"{animal.GetType().Name} has a tail? {animal.HasTail}!");
                Console.WriteLine($"{animal.GetType().Name} is {animal.Age} years old");
                Console.WriteLine();

            }

            


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
