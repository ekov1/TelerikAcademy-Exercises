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
        private BatteryType? batteryType;
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
         public Battery(string model, string manufacturer, BatteryType? batteryType)
            : this(null, null)
        {
            this.batteryType = batteryType;
        }
        #endregion


        //Problem 3. Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
        public enum BatteryType
        {
            LiIon,
            NiMH,
            NiCd
        }
    }
}
