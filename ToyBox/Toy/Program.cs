using System;
using System.Collections.Generic;

namespace ToyBox
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = string.Empty, person, area, name, manu,note, amount;
            double price;

            Console.WriteLine("Welcome to the ToyBox application!");

            ToyBox user = new ToyBox();
            Toy t1 = new Toy();
            do
            {
                if (answer == "yes")
                {
                    Console.WriteLine("Please enter a name for a toy box:");
                    person = Console.ReadLine();
                    Console.WriteLine("Please enter a location for a toy box:");
                    area = Console.ReadLine();
                    user = new ToyBox()
                    {
                        Owner = person,
                        Location = area
                    };

                }
                do
                {
                    if (answer == "yes")
                    {
                        Console.WriteLine("Please enter a name for your toy:");
                        name = Console.ReadLine();
                        Console.WriteLine("Please enter a manufacturer for your toy:");
                        manu = Console.ReadLine();
                        Console.WriteLine("Please enter a price for your toy:");
                        amount = Console.ReadLine();
                        while (double.TryParse(amount, out price) == false)
                        {
                            Console.WriteLine("You did not enter in a number amount! Please try again!");
                            amount = Console.ReadLine();
                        }
                        Console.WriteLine("Please enter any notes for your toy:");
                        note = Console.ReadLine();
                        t1 = new Toy()
                        {
                            Name = name,
                            Manufacturer = manu,
                            Price = price
                        };
                        t1.SetNotes(note);
                        user.Toys.Add(t1);
                    }
                    Console.WriteLine("Would you like to enter in a toy? Type 'yes' or 'no'");
                    answer = Console.ReadLine();


                } while (answer != "no");
                Console.WriteLine("Would you like to enter in another person? Type 'yes' or 'no'");
                answer = Console.ReadLine();
            } while (answer != "no");

            Console.WriteLine($"{user.Owner} is located in {user.Location} with toys of: ");
            for (int i = 0; i < user.Toys.Count; i++)
            {
                Console.WriteLine(user.Toys[i]);
            }
            

          



            //Console.WriteLine(tb1.GetRandomToy());

         }
    }
}



