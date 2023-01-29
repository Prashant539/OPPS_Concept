﻿using OPPSConcept.Abstraction;
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
            Console.WriteLine("1:Inheritance\n2:Polymorphism\n3:Abstraction");
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
                case 3:
                    AbsChild absChild = new AbsChild();
                    absChild.Sub(10, 20);
                    absChild.Add(20, 30);
                    absChild.Div(20, 10);
                    absChild.Mul(20, 20);
                    break;
            }
        }
    }
}
