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

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




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
            Bird blueJay = new Bird()
            {
                AnimalSound = "flap flap",
                BirdNoise = "tweet tweet",
                BirdSize = "small",
                CanFly = true,
                CanSwim = false,
                HasWings = true,
                LikesToEat = "worms",
                LivesUnderwater = false
            };
            Console.WriteLine($"Blue Jay Sound: {blueJay.AnimalSound}" +
                $" Noise: {blueJay.BirdNoise} Size: {blueJay.BirdSize}" +
                $" Flies: {blueJay.CanFly} Can Swim: {blueJay.CanSwim}" +
                $" Has Wings: {blueJay.HasWings}" +
                $" Favorite Food: {blueJay.LikesToEat}" +
                $" Lives Underwater: {blueJay.LivesUnderwater}");


            Reptile turtle = new Reptile()
            {
                AnimalSound = "scoot scoot",
                EatsFlies = false,
                HasAShell = true,
                ReptileNoise = "hiss",
                HasLegs = true,
                HasWings = false,
                LikesToEat = "leaves",
                LivesUnderwater = false
            };
            Console.WriteLine($"Turtle Sound: {turtle.AnimalSound}" +
                $" Eats flies: {turtle.EatsFlies} Has a shell: {turtle.HasAShell}" +
                $" Turtle Noise: {turtle.ReptileNoise} Has legs: {turtle.HasLegs}" +
                $" Has Wings: {turtle.HasWings}" +
                $" Favorite Food: {turtle.LikesToEat}" +
                $" Lives Underwater: {turtle.LivesUnderwater}");
        }
    }
}
