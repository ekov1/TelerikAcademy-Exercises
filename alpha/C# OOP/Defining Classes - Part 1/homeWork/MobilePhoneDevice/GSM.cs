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
        private Battery battery;
        private Display display;
        private List<Call> callHistory;


        // Problem 6. Static field

        // Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
        public static GSM iphone4s = new GSM("Iphone4S", "Apple", 1000, "Steve Jobs",
            new Battery("appleBat", "appleBat", Battery.BatteryTypes.LiIon), new Display("appleDis", "appleDis"));

        #region Constructors
        // Problem 2. Constructors

        // Define several constructors for the defined classes that take different sets of arguments 
        // (the full information for the class or part of it).
        // Assume that model and manufacturer are mandatory (the others are optional).
        // All unknown data fill with null.
        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.CallHistory = new List<Call>();
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
        //Problem 5. Properties

        // Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
        // Ensure all fields hold correct data at any given time.
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
                if (value != null && value.Length < 1)
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

        //  Problem 9. Call history

        // Add a property CallHistory in the GSM class to hold a list of the performed calls.
        // Try to use the system class List<Call>.

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }

        #endregion

        #region Methods    
        // Problem 10. Add/Delete calls

        // Add methods in the GSM class for adding and deleting calls from the calls history.
        // Add a method to clear the call history.

        public void AddCall(Call someCall)
        {
            this.CallHistory.Add(someCall);
        }

        public void RemoveCall(Call someCall)
        {
            this.CallHistory.Remove(someCall);
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        // Problem 11. Call price

        // Add a method that calculates the total price of the calls in the call history.
        // Assume the price per minute is fixed and is provided as a parameter.

        public double CalcPriceOfCalls()
        {
            double pricePerSec = 0.001;
            double sum = 0;

            foreach (var call in this.CallHistory)
            {
                sum += (call.Duration * pricePerSec);
            }

            return sum;
        }

        // Problem 4. ToString

        // Add a method in the GSM class for displaying all information about it.
        // Try to override ToString().
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            string dash = new string('-', 45);
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(dash);
            sb.AppendLine(string.Format("Phone Specs:"));
            sb.AppendLine(string.Format("Model: {0}", this.Model));
            sb.AppendLine(string.Format("Manufacturer: {0}", this.Manufacturer));
            sb.AppendLine(string.Format("Price: {0} $", this.Price));
            sb.AppendLine(string.Format("Owner: {0}", this.Owner));
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
