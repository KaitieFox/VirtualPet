﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        //fields
        private string name;
        private string animalType;        

        //properties
        public string Name { get; set; }
        public string AnimalType { get; set; }
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public int Waste { get; set; }
        public int Boredom { get; set; }
        public int Sickness { get; set; }
        public int Tired { get; set; }

        //constructor
        public VirtualPet()
        {

        }

        public VirtualPet(string name, string animalType)
        {
            this.name = name;
            this.animalType = animalType;
        }

        //methods
        public void Feed()
        {
            Hunger -= 3;
            Thirst++;
            Tired++;
        }

        public void Water()
        {
            Thirst -= 2;
            Waste++;
            Hunger++;
            
        }

        public void Potty()
        {
            Waste = 0;
            Hunger++;
            
        }

        public void Play()
        {
            Boredom-=2;
            Hunger++;
            Thirst += 2;
            
        }

        public void Pet()
        {
            Tired--;
            if (Tired > 3)
            {
                Console.WriteLine("Your pet is very happy");
            }
            else
            {
                Console.WriteLine("Your pet doesn't want your affection now.");
            }
            
        }

        public int Heal()
        {
            Sickness = 0;
            return Sickness;
        }

        public void Stats()
        {
            Console.WriteLine("Hunger: " + Hunger);
            Console.WriteLine("Thirst: " + Thirst);
            Console.WriteLine("Waste: " + Waste);
            Console.WriteLine("Boredom: " + Boredom);
            Console.WriteLine("Tired: " + Tired);
            Console.WriteLine("Sickness: " + Sickness);
        }

        public void Tick()
        {
            Random random = new Random();
            int tick = random.Next(1, 10);

            if (tick<3)
            {
                Hunger++;
                Boredom += 2;
                Tired++;
            }
            else if (tick>3 && tick<7)
            {
                Console.WriteLine("Your pet loves you probably.\n");
            }
            else if(tick>7)
            {
                Thirst += 2;
                Tired++;
                Sickness += 2;
            }
            else
            {
                Console.WriteLine("Your pet has ascended.");
                Environment.Exit(0);
            }
        }





    }
}
