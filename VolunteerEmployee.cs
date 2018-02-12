using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VolunteerEmployee : Employee
    {
        //fields

        private bool likesCats;
        private bool likesDogs;
        private bool getsPaid;
        //properties

        public OtherPets MyCat { get; set; }
        public OtherPets MyDog { get; set; }
        public OtherPets MyDragon { get; set; }
        public OtherPets Cat2 { get; set; }
        public OtherPets Dog2 { get; set; }

        public bool LikesCats
        {
            get { return this.likesCats; }
            set { this.likesCats = value; }
        }

        public bool LikesDogs
        {
            get { return this.likesDogs; }
            set { this.likesDogs = value; }
        }

        public bool GetsPaid
        {
            get { return this.getsPaid; }
            set { this.getsPaid = false; }
        }
        //constructors
        public VolunteerEmployee()
        {
            //default constructor
        }

        public VolunteerEmployee(int employeeID, bool likesCats, bool likesDogs, bool getsPaid, VPShelter.OtherPets otherPets, VPShelter.OtherPets otherPets1, VPShelter.OtherPets otherPets2, VPShelter.OtherPets otherPets3)
        {
            this.EmployeeID = employeeID;
            this.likesCats = likesCats;
            this.likesDogs = likesDogs;
        }

        //methods
        public void AnimalStatus()
        {
            Console.WriteLine("animal:" + MyCat.PetType + " hunger rating:" + MyCat.Hunger + " hydration rating:" + MyCat.HydrationLevel);
            Console.WriteLine("animal:" + MyDog.PetType + " hunger rating:" + MyDog.Hunger + " hydration rating:" + MyDog.HydrationLevel);
            Console.WriteLine("animal:" + Cat2.PetType + " hunger rating:" + Cat2.Hunger + " hydration rating:" + Cat2.HydrationLevel);
            Console.WriteLine("animal:" + Dog2.PetType + " hunger rating:" + Dog2.Hunger + " hydration rating:" + Dog2.HydrationLevel);

        }


        public int VolunteerOptions()
        {
            
            Console.WriteLine("\nEnter 1: to see how everyone is doing today");
            Console.WriteLine("Enter 2: to play with the animals");
            Console.WriteLine("Enter 3: to feed the animals");
            Console.WriteLine("Enter 4: to give the animals fresh water");
            Console.WriteLine("Enter 5: to go back");
            Console.WriteLine("Enter 6: to go home" );
            int volunteerSelect1 = int.Parse(Console.ReadLine());
            return volunteerSelect1;
        }
        public override int GiveWater()
        {
            if
            (((MyCat.HydrationLevel >= 40) || (MyDog.HydrationLevel >= 40) || (Cat2.HydrationLevel >= 40) || (Dog2.HydrationLevel >= 40)))
            {
                Console.WriteLine("Looks like the animals need water!");
                return ((MyCat.HydrationLevel = 0) + (MyDog.HydrationLevel = 0) + (Cat2.HydrationLevel = 0) + (Dog2.HydrationLevel = 0));
            }

            else
            {
                Console.WriteLine("Everyone is good on water for now!");
                return (MyCat.HydrationLevel) + (MyDog.HydrationLevel) + (Cat2.HydrationLevel) + (Dog2.HydrationLevel);

            }

        }


        public override void PlayWithAnimals()
        {
            Console.WriteLine("Hope it is nice outside, the animals love the outdoors!");
        }

        public override void Feed()
        {
            if ((MyCat.Hunger >= 30) || (MyDog.Hunger >= 30) || (Cat2.Hunger >= 30) || (Dog2.Hunger >= 30))
            {
                Console.WriteLine("Time to feed the animals!");
                MyCat.Hunger = 0; MyDog.Hunger = 0; Cat2.Hunger = 0; Dog2.Hunger = 0;

            }
            else
            {
                Console.WriteLine("No one is hungry right now :( ");

            }
        }
    }
}

