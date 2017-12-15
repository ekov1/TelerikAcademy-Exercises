using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Sitefinity.Model;
using Telerik.Sitefinity.Modules.News;
using Telerik.Sitefinity.News.Model;
using Telerik.Sitefinity.Taxonomies;
using Telerik.Sitefinity.Taxonomies.Model;
using Telerik.Sitefinity.Workflow;

namespace SitefinityWebApp.Mvc
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                NewsSnippets.CreateNewsNativeAPI(Guid.NewGuid(), i + "", "news");
            }

            var taxonomyManager = TaxonomyManager.GetManager();
            var categoryTaxonomy = taxonomyManager.GetTaxonomies<HierarchicalTaxonomy>().SingleOrDefault(s => s.Name == "Categories");

            var taxon = taxonomyManager.CreateTaxon<HierarchicalTaxon>();
            taxon.Taxonomy = categoryTaxonomy;
            taxon.Title = "the title";
           

            categoryTaxonomy.Taxa.Add(taxon);

            taxonomyManager.SaveChanges();

            NewsManager newsManager = NewsManager.GetManager();
            var news2 = newsManager.GetNewsItems().Take(5).OrderByDescending(x => x.PublicationDate).ToList();

            // Bonus

            HierarchicalTaxonomyAPI.CreateHierarchicalTaxonomyAndTaxon();

        }

        public partial class NewsSnippets
        {
            public static void CreateNewsNativeAPI(Guid masterNewsId, string newsTitle, string newsContent)
            {
                NewsManager newsManager = NewsManager.GetManager();
                NewsItem newsItem = newsManager.GetNewsItems().Where(item => item.Id == masterNewsId).FirstOrDefault();

                if (newsItem == null)
                {
                    //The news item is created as a master. The newsId is assigned to the master.
                    newsItem = newsManager.CreateNewsItem(masterNewsId);

                    //Set the properties of the news item.
                    newsItem.Title = newsTitle;
                    newsItem.Content = newsContent;
                    newsItem.DateCreated = DateTime.UtcNow;
                    newsItem.PublicationDate = DateTime.UtcNow;
                    newsItem.LastModified = DateTime.UtcNow;
                    newsItem.UrlName = Regex.Replace(newsTitle.ToLower(), @"[^\w\-\!\$\'\(\)\=\@\d_]+", "-");

                    //Recompiles and validates the url of the news item.
                    newsManager.RecompileAndValidateUrls(newsItem);

                    //Save the changes.
                    newsManager.SaveChanges();

                    //Publish the news item. The published version acquires new ID.
                    var bag = new Dictionary<string, string>();
                    bag.Add("ContentType", typeof(NewsItem).FullName);
                    WorkflowManager.MessageWorkflow(masterNewsId, typeof(NewsItem), null, "Publish", false, bag);
                }
            }
        }

        public partial class HierarchicalTaxonomyAPI
        {
            public static void CreateHierarchicalTaxonomyAndTaxon()
            {
                //gets an instance of the taxonomy manager
                TaxonomyManager manager = TaxonomyManager.GetManager();

                //creates hierarchical taxonomy - Language family
                var taxonomy = manager.CreateTaxonomy<HierarchicalTaxonomy>();
                taxonomy.Title = "Language family";
                taxonomy.Name = "Language family";
                taxonomy.TaxonName = "Language family";

                //creates a new taxon and adds it to the taxonomy - Language Groups
                var rootTaxonCateg = manager.CreateTaxon<HierarchicalTaxon>();
                rootTaxonCateg.Title = "Language Groups";
                rootTaxonCateg.Name = "Language Groups";
                rootTaxonCateg.UrlName = new Lstring(Regex.Replace("Language Groups", @"[^\w\-\!\$\'\(\)\=\@\d_]+", "-").ToLower());
                rootTaxonCateg.Description = "Language groups description";
                rootTaxonCateg.Taxonomy = taxonomy;
                taxonomy.Taxa.Add(rootTaxonCateg);

                //creates two sub-taxa and adds them to the Language Groups taxon.
                //1
                var taxonSubCateg = manager.CreateTaxon<HierarchicalTaxon>();
                taxonSubCateg.Title = "Languages";
                taxonSubCateg.Name = "Languages";
                taxonSubCateg.UrlName = new Lstring(Regex.Replace("Languages", @"[^\w\-\!\$\'\(\)\=\@\d_]+", "-").ToLower());
                taxonSubCateg.Description = "Languages description";
                taxonSubCateg.Parent = rootTaxonCateg;
                taxonSubCateg.Taxonomy = taxonomy;
                rootTaxonCateg.Subtaxa.Add(taxonSubCateg);

                //2
                var taxonChildSubCateg = manager.CreateTaxon<HierarchicalTaxon>();
                taxonChildSubCateg.Title = "Dialects";
                taxonChildSubCateg.Name = "Dialects";
                taxonChildSubCateg.UrlName = new Lstring(Regex.Replace("Dialects", @"[^\w\-\!\$\'\(\)\=\@\d_]+", "-").ToLower());
                taxonChildSubCateg.Description = "Dialects description";
                taxonChildSubCateg.Parent = taxonSubCateg;
                taxonChildSubCateg.Taxonomy = taxonomy;
                taxonSubCateg.Subtaxa.Add(taxonChildSubCateg);

                //Save all changes done up to now.
                manager.SaveChanges();
            }
        }
    }
}