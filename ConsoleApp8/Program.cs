using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{



    internal class Program
    {
        class Calculator
        {
            //two int
            public void calc(int x, int y)
            {
                Console.WriteLine(x +y);

            }
            //three int
            public void calc(int x, int y, int w)
            {
                Console.WriteLine(x + y + w);

            }
            //two doub
            public void calc(double x, double y)
            {
                Console.WriteLine(x + y);

            }


        }

        class shape
        {

            public virtual void draw()
            {
                Console.WriteLine("Drawing shape");
            }

          

        }



        class Circle : shape
        {

            public override void draw()
            {
                Console.WriteLine("Drawing a Circle");
            }
        }



        class Rectangle : shape
        {


            public override void draw()
            {

                Console.WriteLine("Drawing a Rectangle");
            }
        }

        abstract class animal
        {
            public abstract void makeSound();

public void sleep()
            {
                Console.WriteLine("Animal is sleeping");

            }
        }

         class Dog : animal
        {
            public override void makeSound()
            {
                Console.WriteLine("Dog barks");

            }

        }
        class cat :animal
        {
            public override void makeSound()
            {
               Console.WriteLine("Cat meows");
            }

        }
        



      interface  playable
        {

            void play();
        }

        class Guitar :playable 
        {
           public void play()
            {
                Console.WriteLine("Playing the guitar");

            }

        }

        class Piano : playable
        {

            public void play()
            {

                Console.WriteLine("Playing the piano");
            }
        }





        static void Main(string[] args)
        {
            shape shape=new shape();
            shape.draw();

            Circle c = new Circle();

            c.draw();

            Rectangle r =new Rectangle();
            r.draw();




            Dog d = new Dog();
            d.makeSound();

            cat t =new cat();
         
            t.makeSound();



            Guitar g = new Guitar();
            g.play();



            Piano p = new Piano();
            p.play();





        }
    }

}
