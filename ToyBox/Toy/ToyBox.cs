using System;
using System.Collections.Generic;
using System.Text;

namespace ToyBox
{
    class ToyBox
    {
        public List<Toy> Toys { get; set; }
        public string Owner { get; set; }
        public string Location { get; set; }

        public ToyBox()
        {
            Toys = new List<Toy>();
            Owner = string.Empty;
            Location = string.Empty;
        }

        public Toy GetRandomToy()
        {
            Random ran = new Random();
            int ranNum = ran.Next(1, Toys.Count);
            return Toys[ranNum];
        }
    }
}
