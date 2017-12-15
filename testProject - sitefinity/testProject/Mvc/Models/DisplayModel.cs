using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Telerik.Sitefinity.News.Model;

namespace SitefinityWebApp.Mvc.Models
{
    public class DisplayModel
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string Message { get; set; }

        public List<NewsItemModel> news { get; set; }
    }
}