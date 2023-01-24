using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPSConcept.Polymorphism
{
    public class LoadParent 
    {
        public void Show()
        {
            Console.WriteLine("Parent's Show Method is Called");
        }
        public virtual void Test() //Overridable
        {
            Console.WriteLine("Parent's Test Method is Called");
        }
    }
    public class LoadChild : LoadParent
    {
        //Overloading parent's ShowMethod in child class
        public void Show(int i)
        {
            Console.WriteLine("Child's Show Method is Called");
        }
        //Overriding parent's Test method in child class
        public override void Test()
        {
            Console.WriteLine("Child's Test Method is called");
        }
    }
}
