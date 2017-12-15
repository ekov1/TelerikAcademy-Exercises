using System;
using System.Collections;
using System.Linq;

namespace SitefinityWebApp.Mvc.Models
{
    public class DisplayModel
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string Message { get; set; }

        public IEnumerable news { get; set; }
    }
}