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
        #region Constructors
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
                    throw new Exception("display model can NOT be an empty string");
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
                    throw new Exception("display manufacturer can NOT be an empty string");
                }
                this.manufacturer = value;
            }
        }
        #endregion

        #region Methods    

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("Model: {0}", this.model));
            sb.AppendLine(string.Format("Manufacturer: {0}", this.manufacturer));

            return sb.ToString();
        }
        #endregion
    }
}
