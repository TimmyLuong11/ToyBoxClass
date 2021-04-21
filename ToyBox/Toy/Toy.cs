using System;
using System.Collections.Generic;
using System.Text;

namespace ToyBox
{
    class Toy
    {
        //Declaring variables
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Notes;

        /// <summary>
        /// Get method for the private string 
        /// </summary>
        /// <returns>The note assigned</returns>
        public string GetNotes()
        {
            return Notes;
        }

        /// <summary>
        /// This is the set method for the private string 
        /// </summary>
        /// <param name="note">Note passed from the main class</param>
        public void SetNotes(string note)
        {
            Notes += note;
        }

        /// <summary>
        /// Default/Empty constructor that sets the instance of the Toy to starting values
        /// </summary>
        public Toy()
        {
            Manufacturer = string.Empty;
            Name = "";
            Price = 0;
            Notes = string.Empty;
        }

        /// <summary>
        /// Get the manufacturer information and manipulate the string
        /// </summary>
        /// <returns>The first character to upper case and add a random number to the end</returns>
        public string GetAisle()
        {
            int ranNum;
            Random ran = new Random();
            ranNum = ran.Next(1, 25);
            return $"{Manufacturer.ToUpper()[0]}{ranNum}";
        }
        
        public override string ToString()
        {
            return $"The toy name is: \t\t{Name} \nThe toy manufacturer by: \t{Manufacturer} \nThe toy cost is: \t\t{Price.ToString("C")} \nThe toy can be found in aisle:  {GetAisle()} \nNotes about the toy: \t\t{GetNotes()}";
        }
    }
}