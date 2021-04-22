using System;
using System.Collections.Generic;
using System.Text;

namespace ToyBox
{
    class ToyBox
    {
        //Initializing Variables
        public List<Toy> Toys { get; set; }
        public string Owner { get; set; }
        public string Location { get; set; }

        /// <summary>
        /// Default/Empty constructor that sets the instance of the Toy to starting values
        /// </summary>
        public ToyBox()
        {
            Toys = new List<Toy>();
            Owner = string.Empty;
            Location = string.Empty;
        }

        /// <summary>
        /// The method will return a random toy in each toy box
        /// </summary>
        /// <returns>A random toy in each toy box</returns>
        public Toy GetRandomToy()
        {
            Random ran = new Random();
            int ranNum = ran.Next(0, Toys.Count);
            return Toys[ranNum];
        }
    }
}
