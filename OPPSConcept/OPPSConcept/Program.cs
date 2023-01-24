using OPPSConcept.Inheritance;
using OPPSConcept.Polymorphism;
using System;
namespace OPPSConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to OPPS Concept");
            Console.WriteLine("Plese Choose a Number to Perform a Program: ");
            Console.WriteLine("1:Inheritance\n2:Polymorphism");
            int Options = Convert.ToInt32(Console.ReadLine());
            switch(Options)
            {
                case 1:
                    Class1 class1= new Class1();
                    class1.Test1();
                    class1.Test2();
                    break;
                case 2:
                    MethodOverLoading methodOverLoading = new MethodOverLoading();
                    methodOverLoading.Test();
                    methodOverLoading.Test(10, "Hello");
                    LoadChild loadChild = new LoadChild();
                    loadChild.Show();
                    loadChild.Show(10);
                    loadChild.Test();
                    break;
            }
        }
    }
}
