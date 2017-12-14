using System;
using System.Linq;
using Telerik.Sitefinity.DynamicModules.Model;

namespace SitefinityWebApp.Mvc.Models
{
    public class ProjectsModel
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string Message { get; set; }
        public string Title { get; set; }

        public string UrlName { get; set; }

        public IQueryable<DynamicContent> Bugs { get; set; }
    }
}