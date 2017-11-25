using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            //entering the shop
            Console.WriteLine("Welcome to the Pet Shop!");
            Console.WriteLine("We have a variety of pets here to take care of.");

            //Console.WriteLine("What would you like to do?");
            //Console.WriteLine("1. 'I'd like to have a look around.'");
            //Console.WriteLine("2. 'I see the animal I want.'");

            //int firstChoice = int.Parse(Console.ReadLine());

            //if (firstChoice == 1)
            //{
            //    Console.WriteLine("Take your time.");
            //}
            //else if (firstChoice == 2)
            //{

            //}
            //else
            //{

            //}

            //....well, I'll figure it out

            //you now have a pet

            Console.WriteLine("I see you've made a decision!");

            Console.WriteLine("Please tell me, what is your animal?");
            string animalType = Console.ReadLine().ToLower();

            Console.WriteLine("And what is it's name?");
            string name = Console.ReadLine();

            VirtualPet yourPet = new VirtualPet(name, animalType);

            Console.WriteLine("You have chosen a " + animalType + " and have named it " + name + ".");
            Console.WriteLine("Congratulations on your new pet!");
            Console.WriteLine("What would you like to do now?");

            //random number generator
            Random stat = new Random();

            //establishes your pet's stats to begin with
            yourPet.Hunger = stat.Next(1, 10);
            yourPet.Thirst = stat.Next(1, 10);
            yourPet.Waste = stat.Next(1, 10);
            yourPet.Boredom = stat.Next(1, 10);
            yourPet.Tired = stat.Next(1, 10);
            yourPet.Sickness = stat.Next(1, 10);                               

                Console.WriteLine("I'd like to...");
                Console.WriteLine("1. Feed " + name + ".");
                Console.WriteLine("2. Give " + name + " water.");
                Console.WriteLine("3. Take " + name + " outside to go potty.");
                Console.WriteLine("4. Play with " + name + ".");
                Console.WriteLine("5. Pet " + name + ".");
                Console.WriteLine("6. Heal " + name + ".");
            Console.WriteLine("7. Abandon my pet.");

                int userChoice = int.Parse(Console.ReadLine());
            do
            {

                switch (userChoice)
                {
                    case 1:
                        yourPet.Feed();
                        break;
                    case 2:
                        yourPet.Water();
                        break;
                    case 3:
                        yourPet.Potty();
                        break;
                    case 4:
                        yourPet.Play();
                        break;
                    case 5:
                        yourPet.Pet();
                        break;
                    case 6:
                        yourPet.Heal();
                        break;
                    case 7:
                        Console.WriteLine("Next time please consider the responsibility of a pet before committing to one.");
                        Environment.Exit(0);
                        break;
                }


                //statements about the stats of your pet




                Console.WriteLine("I'd like to...");
                Console.WriteLine("1. Feed " + name + ".");
                Console.WriteLine("2. Give " + name + "water.");
                Console.WriteLine("3. Take " + name + "outside to go potty.");
                Console.WriteLine("4. Play with " + name + ".");
                Console.WriteLine("5. Pet " + name + ".");
                Console.WriteLine("6. Heal " + name + ".");
                Console.WriteLine("7. Abandon my pet.");

                userChoice = int.Parse(Console.ReadLine());

            }
            while (userChoice < 8);

        }
    }
}
