using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class OtherPets : VirtualPet
    {

        //fields

        private string petType;
        private string dietType;
        //properties

        public string DietType
        {
            get { return this.dietType; }
            set { this.dietType = value; }
        }

        public string PetType
        {
            get { return petType; }
            set { this.petType = value; }
        }

        //constructors

        public OtherPets()
        {
            //default constructor
        }

        public OtherPets(string petType, string petName, int hydrationLevel, int hunger)
        {
            this.PetType = petType;
            this.PetName = petName;
            this.HydrationLevel = hydrationLevel;
            this.Hunger = hunger;
        }

        public OtherPets(string petType, string petName, string petDescription, string dietType, int hydrationLevel, int hunger)
        {
            this.PetType = petType;
            this.PetName = petName;
            this.PetDescription = petDescription;
            this.HydrationLevel = hydrationLevel;
            this.Hunger = hunger;
        }
        //methods


    }
}
