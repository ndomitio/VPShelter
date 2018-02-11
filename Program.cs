using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPet myDragon = new VirtualPet(string.Empty, "red and scary", "dragon", 50, 50);
            OtherPets myCat = new OtherPets("cat", string.Empty, "tuxedo", "canned food", 50, 50);
            OtherPets myDog = new OtherPets("dog", string.Empty, "black lab", "dry food", 50, 50);
            OtherPets dog2 = new OtherPets("dog", string.Empty, "golden retriever", "dry food", 50, 50);
            OtherPets cat2 = new OtherPets("cat", string.Empty, "maine coon", "canned food", 50, 50);

            Manager Manager1 = new Manager(true, myDog, myCat, dog2, cat2);

            VolunteerEmployee Vol1 = new VolunteerEmployee(1001, true, true, false, myCat, myDog, cat2, dog2);
            VolunteerEmployee Vol2 = new VolunteerEmployee(1002, true, true, false, myCat, myDog, cat2, dog2);
            VolunteerEmployee Vol3 = new VolunteerEmployee(1003, true, true, false, myCat, myDog, cat2, dog2);


            List<VolunteerEmployee> EmployeeList = new List<VolunteerEmployee>();
            List<OtherPets> PetList = new List<OtherPets>();

            EmployeeList.Add(Vol1);
            EmployeeList.Add(Vol2);
            EmployeeList.Add(Vol3);

            //PetList.Add(Mydragon);
            PetList.Add(myCat);
            PetList.Add(myDog);
            PetList.Add(cat2);
            PetList.Add(dog2);

            //allows changes resulting from method in manager/volunteer class to affect the Petlist that is present in the program class
            Manager1.PetList = PetList;

            Vol1.MyCat = myCat;
            Vol1.MyDog = myDog;
            Vol1.Cat2 = cat2;
            Vol1.Dog2 = dog2;

            int visitorSelect;
            int volunteerSelect = 0;
            int firstChoice = Manager1.ManagerGreet();
            switch (firstChoice)
            {
                case 1:
                    do
                    {
                        volunteerSelect = Vol1.VolunteerOptions();
                        if (volunteerSelect == 1)
                        {
                            Console.Clear();
                            Vol1.AnimalStatus();
                        }
                        if (volunteerSelect == 2)
                        {
                            Console.Clear();
                            Vol1.PlayWithAnimals();
                        }
                        if (volunteerSelect == 3)
                        {
                            Console.Clear();
                            Vol1.Feed();
                        }
                        if (volunteerSelect == 4)
                        {
                            Console.Clear();
                            Vol1.GiveWater();
                        }
                        if (volunteerSelect == 5)
                        {
                            System.Environment.Exit(0);
                        }


                    } while (volunteerSelect != 5);




                    break;
                case 2:
                    do
                    {
                        visitorSelect = Manager1.hostVisitor();

                        if (visitorSelect == 1)
                        {
                            Console.Clear();
                            Manager1.Adopt();
                        }
                        if (visitorSelect == 2)
                        {
                            Console.Clear();
                            Manager1.PlayWithAnimals();
                        }
                        if (visitorSelect == 3)
                        {
                            Console.Clear();
                            myDragon.Dragon();
                        }
                    } while (visitorSelect != 4);
                    break;
            }
        }
    }
}
