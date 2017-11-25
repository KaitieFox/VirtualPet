using System;
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
        public int Feed()
        {            
                Hunger -= 3;
            Thirst++;
            Tired++;                
            return Hunger;                    
        }

        public int Water()
        {
            thirst -= 2;            
            return thirst;
        }

        public int Potty()
        {
            waste = 0;            
            return waste;
        }

        public int Play()
        {
            boredom--;            
            return boredom;
        }

        public int Pet()
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
            return tired;
        }

        public int Heal()
        {
            sickness = 0;
            return sickness;
        }


    }
}
