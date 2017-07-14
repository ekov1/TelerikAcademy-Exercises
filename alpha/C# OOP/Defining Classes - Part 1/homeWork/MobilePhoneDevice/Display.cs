﻿using System;
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
        public Display(string model, string manufacturer, decimal? price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        public Display(string model, string manufacturer)
            : this(model, manufacturer, null)
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
        // Problem 4. ToString

        // Add a method in the GSM class for displaying all information about it.
        // Try to override ToString().
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("Model: {0}", this.Model));
            sb.AppendLine(string.Format("Manufacturer: {0}", this.Manufacturer));

            return sb.ToString();
        }
        #endregion
    }
}
