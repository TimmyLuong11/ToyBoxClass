using System;
using System.Collections.Generic;

namespace ToyBox
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing Variables 
            string answer = string.Empty, person, area, name, maker, note, amount;
            double price;
            ToyBox boxOwner = new ToyBox();
            Toy ownerToy = new Toy();
            Dictionary<string, List<Toy>> toyID = new Dictionary<string, List<Toy>>();

            //Greating the user
            Console.WriteLine("Welcome to the ToyBox application!");
            
            //Looping for the user to add a toy box using a dictionary to make sure correct toy is going to the correct person
            do
            {
                Console.WriteLine("Please enter a name for a toy box:");
                person = Console.ReadLine();
                Console.WriteLine("Please enter a location for a toy box:");
                area = Console.ReadLine();
                boxOwner = new ToyBox()
                {
                    Owner = person,
                    Location = area
                };
                toyID.Add(boxOwner.Owner+ ',' + boxOwner.Location, new List<Toy>());

                //Looping for the user to add the toy to the toy box and adding to the dictionary for the correct person
                do
                {
                    Console.WriteLine("Please enter a name for your toy:");
                    name = Console.ReadLine();
                    Console.WriteLine("Please enter a manufacturer for your toy:");
                    maker = Console.ReadLine();
                    Console.WriteLine("Please enter a price for your toy:");
                    amount = Console.ReadLine();
                    while (double.TryParse(amount, out price) == false)
                    {
                        Console.WriteLine("You did not enter in a number amount! Please try again!");
                        amount = Console.ReadLine();
                    }
                    Console.WriteLine("Please enter any notes for your toy:");
                    note = Console.ReadLine();
                    ownerToy = new Toy()
                    {
                        Name = name,
                        Manufacturer = maker,
                        Price = price
                    };
                    ownerToy.SetNotes(note);
                    toyID[boxOwner.Owner + ',' + boxOwner.Location].Add(ownerToy);
                    Console.WriteLine("Would you like to enter in a toy? Type 'yes' or 'no'");
                    answer = Console.ReadLine();
                } while (answer[0] != 'n');

                Console.WriteLine("Would you like to enter in another person? Type 'yes' or 'no'");
                answer = Console.ReadLine();
            } while (answer[0] != 'n');

            //Outputting each toy in the each toy box
            foreach (var item in toyID)
            {
                String[] sp = item.Key.Split(',');
                Console.WriteLine($"\n{sp[0]} is located in {sp[1]} with toys of:");
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine(item.Value[i]);
                }
            }

            //Outputting a random toy in each toy box
            foreach (var item in toyID)
            {
                String[] sp = item.Key.Split(',');
                for (int i = 0; i < item.Value.Count; i++)
                {
                    boxOwner.Toys.Add(item.Value[i]);
                }
                Console.WriteLine($"\nA random toy in {sp[0]} toy box is:");
                Console.WriteLine(boxOwner.GetRandomToy());
                boxOwner.Toys.Clear();
            }

            //Thanking the user for using the program
            Console.WriteLine("\nThank you for adding your toy and toy boxes. Have a great day!");
         }
    }
}



