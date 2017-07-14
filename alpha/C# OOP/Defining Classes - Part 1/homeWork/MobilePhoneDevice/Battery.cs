using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    // Problem 1. Define class

    // Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
    public class Battery
    {
        private string model;
        private string manufacturer;
        private BatteryTypes? batteryType;
        // Problem 2. Constructors

        // Define several constructors for the defined classes that take different sets of arguments 
        // (the full information for the class or part of it).
        // Assume that model and manufacturer are mandatory (the others are optional).
        // All unknown data fill with null.

        #region Constructors
        public Battery(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }
        public Battery(string model, string manufacturer, BatteryTypes? batteryType)
           : this(null, null)
        {
            this.batteryType = batteryType;
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
                    throw new Exception("battery model can NOT be an empty string");
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
                    throw new Exception("battery manufacturer can NOT be an empty string");
                }
                this.manufacturer = value;
            }
        }

        public BatteryTypes? BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }
        #endregion

        //Problem 3. Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
        public enum BatteryTypes
        {
            LiIon,
            NiMH,
            NiCd
        }

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
