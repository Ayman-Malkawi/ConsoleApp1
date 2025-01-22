using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{


    class Vehicle
    {

        public string Brand { get; set; }
        public string Model { get; set; }
    }

    class Car : Vehicle

       


    {
        public void Start()
        {
            Console.WriteLine("Vehicle is starting");


        }
        public int NumberOfDoors {  get; set; }


    }

    class Program
    {




        static void Main(string[] args)
        {

            Vehicle v = new Vehicle();
            v.Brand = "merceds";
            v.Model = "Mercedes-Benz E-Class";
            




            Car c = new Car();
            c.NumberOfDoors = 4;
            c.Start();



        }
    }
}




//Constructor: A method that initializes an object when it's created.
//OOP Concepts: Encapsulation, Inheritance, Polymorphism, and Abstraction.
//Encapsulation: Protecting data by controlling access using methods or properties.
//Sealed Class: A class that cannot be inherited.
//Inheritance: A child class using the properties and methods of a parent class.







