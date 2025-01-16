using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
    
        {
            Console.WriteLine("inter your value");
            string value=  Console.ReadLine();
            Console.WriteLine("your input :  "+value);


            //////////////////////////////////////
            ///

            double d = 5.5;
            Console.WriteLine("double is : " + d);
            string s = "ayman";
            Console.WriteLine("string is : " + s);
            char c = 'a';
            Console.WriteLine("char is : " + c);
            bool b = true;
            Console.WriteLine("bool is : " + b);
            int i = 0;
            Console.WriteLine("int is : " + i);
            const int j = 1;
            Console.WriteLine("const is : " + j);

            ////////////////////////////////////////
            ///

            string[] car = { "bmw", "merceds", "porcha" };
            for (int x = 0; x < car.Length; x++)
            {
                Console.WriteLine(car[x]);
            }

            /////////////////////////////////
            ///
            Console.WriteLine("inter Fname");
            string firstname = Console.ReadLine();

            Console.WriteLine("inter Lname");

            string lastname = Console.ReadLine();
            Console.WriteLine("inter birth");

            string dateofbirth = Console.ReadLine();
            Console.WriteLine(firstname+" "+lastname+" "+dateofbirth);

            ///////////
            ///
            string[]first=new string[10];
            for (int x = 0; x < first.Length; x++)
            { 
                Console.WriteLine("put in array");
                string aaaa = Console.ReadLine();
                first[x] = aaaa;


            }foreach (string q in first)
            {

                Console.WriteLine(q);
            }



        }
        
    }
}
    