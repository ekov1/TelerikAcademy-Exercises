using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    // Problem 1. Define class

    // Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
    public class Display
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        // Problem 2. Constructors

        // Define several constructors for the defined classes that take different sets of arguments 
        // (the full information for the class or part of it).
        // Assume that model and manufacturer are mandatory (the others are optional).
        // All unknown data fill with null.
        public Display(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        public Display(string model, string manufacturer, decimal price)
            : this(null, null)
        {
            this.price = price;
        }
    }
}
