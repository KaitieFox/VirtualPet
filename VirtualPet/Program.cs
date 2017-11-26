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

            System.Threading.Thread.Sleep(1000);

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

            //initial stats
            yourPet.Stats();

            Console.WriteLine();
            System.Threading.Thread.Sleep(100);

            //initial action items
            Console.WriteLine("I'd like to...");
            Console.WriteLine("1. Feed " + name + ".");
            Console.WriteLine("2. Give " + name + " water.");
            Console.WriteLine("3. Take " + name + " outside to go potty.");
            Console.WriteLine("4. Play with " + name + ".");
            Console.WriteLine("5. Pet " + name + ".");
            Console.WriteLine("6. Heal " + name + ".");
            Console.WriteLine("7. See how my pet is doing.");
            Console.WriteLine("8. Do nothing.");
            Console.WriteLine("9. Abandon my pet.");

            //initial user input            
            int userChoice = int.Parse(Console.ReadLine());

            do
            {

                switch (userChoice)
                {
                    case 1:
                        yourPet.Feed();
                        if (yourPet.Hunger > 5)
                        {
                            Console.WriteLine("Your pet is still hungry!");
                        }
                        else if (yourPet.Hunger < 0)
                        {
                            yourPet.Hunger = 0;
                        }
                        break;

                    case 2:
                        yourPet.Water();
                        if (yourPet.Thirst > 5)
                        {
                            Console.WriteLine("Your pet is still thirsty!");
                        }
                        else if (yourPet.Thirst < 0)
                        {
                            yourPet.Thirst = 0;
                        }
                        break;

                    case 3:
                        yourPet.Potty();
                        if (yourPet.Waste == 0)
                        {
                            Console.WriteLine("Your pet is relieved.");
                        }
                        
                        break;

                    case 4:
                        yourPet.Play();
                        if (yourPet.Boredom < 0)
                        {
                            yourPet.Boredom = 0;
                        }

                        break;

                    case 5:
                        yourPet.Pet();
                        if (yourPet.Tired < 0)
                        {
                            yourPet.Tired = 0;
                        }
                        break;

                    case 6:
                        yourPet.Heal();
                        break;

                    case 7:
                        yourPet.Stats();
                        break;

                    case 8:
                        yourPet.Tick();
                        break;

                    case 9:
                        Console.WriteLine("Next time please consider the responsibility of a pet before committing to one.");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Careful how you handle your pet!");
                        break;
                }                           
              
                

                Console.WriteLine();
                System.Threading.Thread.Sleep(100);

                

                //action items
                Console.WriteLine("I'd like to...");
                Console.WriteLine("1. Feed " + name + ".");
                Console.WriteLine("2. Give " + name + " water.");
                Console.WriteLine("3. Take " + name + " outside to go potty.");
                Console.WriteLine("4. Play with " + name + ".");
                Console.WriteLine("5. Pet " + name + ".");
                Console.WriteLine("6. Heal " + name + ".");
                Console.WriteLine("7. See how my pet is doing.");
                Console.WriteLine("8. Do nothing.");
                Console.WriteLine("9. Abandon my pet.");

                //user input
                userChoice = int.Parse(Console.ReadLine());

            }
            while (userChoice < 9);

        }
    }
}
