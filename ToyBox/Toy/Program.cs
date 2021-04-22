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
            Dictionary<string, List<Toy>> peo = new Dictionary<string, List<Toy>>();
            do
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
                peo.Add(user.Owner+ ',' + user.Location, new List<Toy>());

                do
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
                    peo[person + ',' + area].Add(t1);
                    Console.WriteLine("Would you like to enter in a toy? Type 'yes' or 'no'");
                    answer = Console.ReadLine();
                } while (answer[0] != 'n');

                Console.WriteLine("Would you like to enter in another person? Type 'yes' or 'no'");
                answer = Console.ReadLine();
            } while (answer[0] != 'n');

            foreach (var item in peo)
            {
                String[] sp = item.Key.Split(',');
                Console.WriteLine($"\n{sp[0]} is located in {sp[1]} with toys of:");
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine(item.Value[i]);
                }
            }
            foreach (var item in peo)
            {
                String[] sp = item.Key.Split(',');
                for (int i = 0; i < item.Value.Count; i++)
                {
                    user.Toys.Add(item.Value[i]);
                }
                Console.WriteLine($"\nA random toy in {sp[0]} toy box is:");
                Console.WriteLine(user.GetRandomToy());
                user.Toys.Clear();
            }

            Console.WriteLine("\nThank you for adding your toy and toy boxes. Have a great day!");
         }
    }
}



