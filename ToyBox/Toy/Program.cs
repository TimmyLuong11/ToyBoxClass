using System;
using System.Collections.Generic;

namespace ToyBox
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            List<Toy> toyCollection = new List<Toy>();

            //Toy 1
            Toy t1 = new Toy();

            //Passing values to the toy class
            t1.Manufacturer = "The Lego Group";
            t1.Name = "Lego Classis Brick Set";
            t1.Price = 15.99;
            t1.SetNotes("This toy is for children ages 4+.");

            //Adding toy 1 to collection as well as outputting information to user
            toyCollection.Add(t1);
            Console.WriteLine("Toy 1");
            Console.WriteLine(t1);

            //Toy 2
            Toy t2 = new Toy();

            //Passing values to the toy class
            t2.Manufacturer = "Kellytoy Worldwide, Inc.";
            t2.Name = "20” Star Wars The Child Squishmallows Plush";
            t2.Price = 27.99;
            t2.SetNotes("This toy is for children ages 3+.");

            //Adding toy 2 to collection as well as outputting information to user
            toyCollection.Add(t2);
            Console.WriteLine("Toy 2");
            Console.WriteLine(t2);

            //Toy 3
            Toy t3 = new Toy();

            //Passing values to the toy class
            t3.Manufacturer = "Mattel";
            t3.Name = "Hot Wheels 50-Car Pack";
            t3.Price = 48.99;
            t3.SetNotes("This toy is for children ages 3+.");

            //Adding toy 3 to collection as well as outputting information to user
            toyCollection.Add(t3);
            Console.WriteLine("Toy 3");
            Console.WriteLine(t3);

            Toy t4 = new Toy()
            {
                Manufacturer = "Mattel",
                Name = "Hot Wheels",
                Price = 8.99
            };
            t4.SetNotes("This product is for ages 4+.");
            Console.WriteLine($"\n{t4.Name} is manufacturered by {t4.Manufacturer} and it cost {t4.Price.ToString("C")} and can be found on aisle {t4.GetAisle()}. {t4.GetNotes()} ");

         }
    }
}



