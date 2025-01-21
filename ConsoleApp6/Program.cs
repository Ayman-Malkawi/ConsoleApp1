using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp6
{
    internal class Program
    {
        public class student
        {

            ~student() { Console.WriteLine("the program end"); }


            public student()
            {
                name = "";
                age = 1;
                id = 1;


            }
            public student(string name, int age , int id)
            {
                this.name = name;
                Age = age;
                this.id = id;


            }

            public void GetDetails()
            {

                Console.WriteLine($"name : {name}\nage : {age}\nid :{id}");
            }



            public string name {  get; set; }

            private int age;
            public int Age {  
                get { return age; }
                set
                {
                    if (value >= MinAge && value <= MaxAge)
                    {
                        age = value;
                    }
                    else
                    {
                        age = 0;
                    }
                }
                }
            public int id {  get; set; }
            public string email { get; set; }
            public const int MinAge = 18;
            public const int MaxAge = 40;
         
        }
        static void Main(string[] args)
        {
            student number1 = new student();
            number1.name = "ahmed";
            number1.Age = 22;
            number1.id = 1001;

            number1.GetDetails();


            student number2 = new student("ayman" , 17 , 1002);
            number2.GetDetails();



        }
    }
}


//1- A class is a template or blueprint we use it to make the code more organized
//2- An object is an instance of the class to spacify values to the class properties
//3- An object is an instance of the class (Part Of It)
//4- Encapsulation, Abstract, polymorphism and inheritance
//5- A property is a way to encabsulate the class feild so we can print or modify the feilds without a direct access to it
//6- A feild is a normal variable declared inside a class.
//7- A Constructor is a special method to initialize the object feilds and it will be executed automatically when we create an object
//8- Encapsulation is one of the OOP principles and it means to hide what is supposed to be hidden and only show what is neces

