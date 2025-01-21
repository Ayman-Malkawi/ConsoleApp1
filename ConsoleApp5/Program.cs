using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5;

namespace ConsoleApp5
{


    public class hotel
    {
        public int roomNumber;//field
        public string roomType;//field
        public double price;//field
        public bool isBooked;//field
        public const string hotelName = "Hotel";//Constant
};
  
      
    }
    internal class Program
    {
        //public static void jana()
        //{
        //    int x = 27;
        //    for (int i = 2; i < x; i++) 
        //    {
        //        if (x % i == 0)
        //        {
        //            Console.WriteLine("Not Prime");
        //            break;
        //        }
        //        else
        //        {

        //            Console.WriteLine("prime");
        //            break;

        //        }
        //    }
        //}


    static void Main(string[] args)
    {
        //jana();








        //task1
        //Console.WriteLine("inter the number");
        //int num = int.Parse(Console.ReadLine());
        //if (num % 2 == 0)
        //{
        //    Console.WriteLine("even");
        //}
        //else
        //{
        //    Console.WriteLine("odd");

        //}  

        //task2
        //Console.WriteLine("Enter 5 numbers!");
        //int[] numbr = new int[5]; 

        //for (int i = 0; i < numbr.Length; i++)
        //{
        //    Console.Write($"Enter number {i}: ");
        //    numbr[i] = int.Parse(Console.ReadLine());

        //}

        //Array.Sort(numbr);

        //Console.WriteLine($"The second smallest number is: {numbr[1]}");

        //task3
        //Console.Write("Enter a number: ");
        //int number = int.Parse(Console.ReadLine());

        //int result = 1;

        //for (int i = 1; i <= number; i++)
        //{
        //    result = result * i;
        //}

        //Console.WriteLine($"The factorial of {number} is: {result}");


        //task4 not completed
        //Console.WriteLine("insert number");
        //int numb = int.Parse(Console.ReadLine());




        //task5
        //Console.WriteLine("number is");
        //int[] numbers = { 3, 1, 4, 1, 5, 9 };
        //int larg = numbers[0];
        //foreach (int i in numbers) {
        //    if (i > larg)
        //    {
        //        larg= i;
        //    }

        //    Console.WriteLine(i);
        //}

        //task6
        //int n = 5; 
        //int number = 1;

        //for (int i = 1; i <= n; i++)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write(number + " ");
        //        number++;
        //    }
        //    Console.WriteLine();

        //}
        //task7
        hotel Room1 = new hotel();
        Room1.roomNumber = Convert.ToInt32(Console.ReadLine());
        Room1.roomType = Console.ReadLine();
        Room1.price = Convert.ToDouble(Console.ReadLine());
        Room1.isBooked = Convert.ToBoolean(Console.ReadLine());
        //hotel.hotelName = Console.ReadLine();
        Console.WriteLine($"{Room1.roomNumber} {Room1.roomType} {Room1.price} {Room1.isBooked} {hotel.hotelName}");
        //---------------------------------------------
        Console.WriteLine(hotel.hotelName);
        hotel Room2 = new hotel();
        Room2.roomNumber = Convert.ToInt32(Console.ReadLine());
        Room2.roomType = Console.ReadLine();
        Room2.price = Convert.ToDouble(Console.ReadLine());
        Room2.isBooked = Convert.ToBoolean(Console.ReadLine());
        //hotel.hotelName = Console.ReadLine();
        Console.WriteLine(hotel.hotelName);
        Console.WriteLine($"{Room2.roomNumber} {Room2.roomType} {Room2.price} {Room2.isBooked} {hotel.hotelName}");



    

    }
    }
