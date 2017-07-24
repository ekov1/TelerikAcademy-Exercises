using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    // Problem 8. Calls

    // Create a class Call to hold a call performed through a GSM.
    // It should contain date, time, dialled phone number and duration (in seconds).
    public class Call
    {
        #region Fields
        private DateTime date;
        private TimeSpan time;
        private string dialledPhoneNumber;
        private int duration;
        #endregion

        #region Constructors
        public Call(string dialledPhoneNumber, int duration)
        {
            this.DialledPhoneNumber = dialledPhoneNumber;
            this.Duration = duration;
            this.Date = DateTime.Now.Date;
            this.Time = DateTime.Now.TimeOfDay;
        }
        #endregion

        #region Properties
        public DateTime Date
        {
            get
            {
                return this.date;
            }

            private set
            {
                this.date = value;
            }
        }

        public TimeSpan Time
        {
            get
            {
                return this.time;
            }

            private set
            {
                this.time = value;
            }
        }

        public string DialledPhoneNumber
        {
            get
            {
                return this.dialledPhoneNumber;
            }

            private set
            {
                this.dialledPhoneNumber = value;
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            private set
            {
                this.duration = value;
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("date: {0}", this.Date));
            sb.AppendLine(string.Format("time: {0}", this.Time));
            sb.AppendLine(string.Format("DialledPhoneNumber: {0}", this.DialledPhoneNumber));
            sb.AppendLine(string.Format("Duration in sec: {0}", this.Duration));
            return sb.ToString();
        }
        #endregion
    }
}
