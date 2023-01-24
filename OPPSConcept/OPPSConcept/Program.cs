using OPPSConcept.Inheritance;
using System;
namespace OPPSConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to OPPS Concept");
            Console.WriteLine("Plese Choose a Number to Perform a Program: ");
            Console.WriteLine("1:Inheritance");
            int Options = Convert.ToInt32(Console.ReadLine());
            switch(Options)
            {
                case 1:
                    Class1 class1= new Class1();
                    class1.Test1();
                    class1.Test2();
                    break;
            }
        }
    }
}
