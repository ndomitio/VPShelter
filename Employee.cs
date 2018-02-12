using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public abstract class Employee
    {
        //fields

        private int employeeID;

        //properties

        public int EmployeeID
        {
            get { return this.employeeID; }
            set { this.employeeID = value; }
        }
        //constructors
        public Employee()
        {
            //default constructor
        }

        //methods

        public abstract void Feed();

        public abstract int GiveWater();

        public abstract void PlayWithAnimals();

        public virtual void Adopt()
        { }
        


    }

}

