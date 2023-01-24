using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPSConcept.Polymorphism
{
    public class MethodOverLoading
    {
        public void Test()
        {
            Console.WriteLine("1st Method");
        }
        public void Test(int i)
        {
            Console.WriteLine("2nd Method");
        }
        public void Test(int a,  string s)
        {
            Console.WriteLine("3rd Method");
        }

    }
}
