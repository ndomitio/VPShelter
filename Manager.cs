using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Manager : Employee
    {
        //fields
        //properties
        public bool HasAuthority { get; set; }
        public OtherPets myCat { get; set; }
        public OtherPets myDog { get; set; }
        public OtherPets myDragon { get; set; }
        public OtherPets dog2 { get; set; }
        public OtherPets cat2 { get; set; }
        public List<OtherPets> PetList { get; set; }
        //constructors 

        public Manager()
        {
            //default constructor
        }

        public Manager(bool hasAuthority, VPShelter.OtherPets otherPets, VPShelter.OtherPets otherPets1, VPShelter.OtherPets otherPets2, VPShelter.OtherPets otherPets3)
        {
            this.HasAuthority = hasAuthority;
        }

        //methods 
        public int hostVisitor()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Enter 1: to adopt");
            Console.WriteLine("Enter 2: to play with the animals");
            Console.WriteLine("Enter 3: to check out the dragon!");
            Console.WriteLine("Enter 4: to leave");
            int visitorSelect1 = int.Parse(Console.ReadLine());
            return visitorSelect1;

        }

        public int ManagerGreet()
        {
            Console.WriteLine("Welcome to the animal shelter");
            Console.WriteLine("\nIf you are here to volunteer press 1.\nIf you are here to visit press 2.");
            int firstChoice1 = int.Parse(Console.ReadLine());
            return firstChoice1;
        }

        public override int GiveWater()
        {
            if ((myCat.HydrationLevel >= 40) || (myDog.HydrationLevel >= 40) || (cat2.HydrationLevel >= 40) || (dog2.HydrationLevel >= 40))
            {
                Console.WriteLine("Looks like the animals need water!");
                return ((myCat.HydrationLevel = 0) + (myDog.HydrationLevel = 0) + (dog2.HydrationLevel = 0) + (cat2.HydrationLevel = 0));
            }

            else
            {
                Console.WriteLine("Looks like everyone is good on water for now!");
                return (myCat.HydrationLevel) + (myDog.HydrationLevel) + (myDragon.HydrationLevel);

            }
        }


        public override void PlayWithAnimals()
        {
            Console.WriteLine("Hope it is nice outside, the animals would love to go for a walk!");
        }

        public override void Feed()
        {
            if ((myCat.Hunger >= 30) || (myDog.Hunger >= 30) || (cat2.Hunger >= 30) || (dog2.Hunger >= 30))
            {
                Console.WriteLine("Time to feed the animals!");
                myCat.Hunger = 0; myDog.Hunger = 0; cat2.Hunger = 0; dog2.Hunger = 0;
            }
            else
            {
                Console.WriteLine("No one is hungry right now :( ");

            }
        }

        public void Adopt()
        //console writeline the list and ask for user input to select and remove from list?
        {
            Console.WriteLine("Here are the animals that we have at our shelter to adopt");
            foreach (OtherPets pet in PetList)
            {
                Console.WriteLine("     Animal type:");
                Console.WriteLine(pet.PetType);
                Console.WriteLine("     Animal description:");
                Console.WriteLine(pet.PetDescription);
            }
            if (HasAuthority == true)
            {
                Console.WriteLine("\n\nWhich animal would you like to take home? If you would like a cat, press 1 or 3.  For a dog, press 2 or 4.");

                int adoptedAnimal = int.Parse(Console.ReadLine());

                if (adoptedAnimal == 1)
                {
                    PetList.Remove(myCat);
                }
                if (adoptedAnimal == 2)
                {
                    PetList.Remove(myDog);
                }
                if (adoptedAnimal == 3)
                {
                    PetList.Remove(cat2);
                }
                if (adoptedAnimal == 4)
                {
                    PetList.Remove(dog2);
                }
            }
            else Console.WriteLine("What would you like to do now");
        }
    }
}

