using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPSConcept.Encapsulation
{
    public class Person
    {
        private string Name;
        private int Age;
        public void setName(string Name)
        {
            if(Name.Length > 4)
            {
                this.Name = Name;
            }
            else
            {
                Console.WriteLine(" Plese Enter the Correct Name: ");
            }
            
        }
        public string getName(string Name)
        {
           // Console.WriteLine("Your Name is: " +this.Name);
           return Name;
        }
        public void setAge(int Age)
        {
            if (Age > 0)
            {
                this.Age = Age;
            }
            else
            {
                Console.WriteLine(" Plese Enter the Correct Age: ");
            }

        }
        public int getAge(int Age)
        {
             return Age;
        }

    }
}
