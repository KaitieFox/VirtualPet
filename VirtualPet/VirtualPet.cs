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
        private int hunger;
        private int thirst;
        private int waste;
        private int boredom;
        private int sickness;
        private int tired;

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
            if (hunger > 5)
            {
                Console.WriteLine("Your animal is happy.");
                hunger -= 3;
                thirst++;
                waste++;
            }
            else
            {
                Console.WriteLine("Your animal is already full");                
            }            
        }

        public void Water()
        {
            thirst -= 2;
            waste++;
        }

        public void Potty()
        {
            waste = 0;
            hunger++;
        }

        public void Play()
        {
            boredom--;
            tired++;
            thirst++;
        }

        public void Pet()
        {
            tired--;
            if (tired > 3)
            {
                Console.WriteLine("Your pet is very happy");
            }
            else
            {
                Console.WriteLine("Your pet doesn't want your affection now.");
            }
        }

        public void Heal()
        {
            sickness = 0;
        }


    }
}
