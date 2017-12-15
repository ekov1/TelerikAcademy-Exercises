using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;
using Telerik.Sitefinity.Modules.News;
using Telerik.Sitefinity.Taxonomies;
using Telerik.Sitefinity.Taxonomies.Model;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "Display", Title = "Display", SectionName = "MvcWidgets")]
    [Telerik.Sitefinity.Web.UI.ControlDesign.ControlDesigner(typeof(WidgetDesigners.Display.DisplayDesigner))]
    public class DisplayController : Controller
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [Category("String Properties")]
        public string Message { get; set; }

        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {
            var taxonomyManager = TaxonomyManager.GetManager();
            var taxon = taxonomyManager.GetTaxa<HierarchicalTaxon>().Where(t => t.Title == "the title").ToList();

            NewsManager newsManager = NewsManager.GetManager();
            var news2 = newsManager.GetNewsItems()
                .Where(x => x.Organizer.TaxonExists(taxon[0].Name, taxon[0].Id) == false)
                .ToList();

            var model = new DisplayModel();

            model.news = news2;

            return View("Default", model);
        }
    }
}