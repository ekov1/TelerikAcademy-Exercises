using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    // Problem 1. Define class

    // Define a class that holds information about a mobile phone device: model, manufacturer, price,
    // owner, battery characteristics (model, hours idle and hours talk) and display characteristics 
    // (size and number of colors).

    // Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        Battery battery;
        Display display;

        // Problem 2. Constructors

        // Define several constructors for the defined classes that take different sets of arguments 
        // (the full information for the class or part of it).
        // Assume that model and manufacturer are mandatory (the others are optional).
        // All unknown data fill with null.

        #region Constructors
        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public GSM(string model, string manufacturer)
          : this(model, manufacturer, null, null, null, null)
        {
        }
        public GSM(string model, string manufacturer, decimal? price)
           : this(model, manufacturer, price, null, null, null)
        {
        }

        public GSM(string model, string manufacturer, string owner)
           : this(model, manufacturer, null, owner, null, null)
        {
        }

        public GSM(string model, string manufacturer, Battery battery, Display display)
           : this(model, manufacturer, null, null, battery, display)
        {
        }



        #endregion
    }
}
