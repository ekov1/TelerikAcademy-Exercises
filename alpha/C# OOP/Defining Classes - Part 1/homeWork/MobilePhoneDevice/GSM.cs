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
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
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

        #region Properties
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value.Length < 1)
                {
                    throw new Exception("phone model can NOT be an empty string");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value.Length < 1)
                {
                    throw new Exception("phone manufacturer can NOT be an empty string");
                }
                this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("phone price can NOT be less than 0");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value.Length < 1)
                {
                    throw new Exception("phone owner can NOT be an empty string");
                }
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }
        #endregion

        #region Methods    

        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            string dash = new string('-', 45);
            StringBuilder sb = new StringBuilder();
           
            sb.AppendLine(dash);
            sb.AppendLine(string.Format("Phone Specs:"));
            sb.AppendLine(string.Format("Model: {0}", this.model));
            sb.AppendLine(string.Format("Manufacturer: {0}", this.manufacturer));
            sb.AppendLine(string.Format("Price: {0} $", this.price));
            sb.AppendLine(string.Format("Owner: {0}", this.owner));
            sb.AppendLine();

            sb.AppendLine(dash);
            sb.AppendLine(string.Format("Battery Specs:"));
            sb.AppendLine(string.Format("{0}", this.battery.ToString()));

            sb.AppendLine(dash);
            sb.AppendLine("Display Specs:");
            sb.AppendLine(string.Format("{0}", this.display.ToString()));

            return sb.ToString();
        }
        #endregion
    }
}
