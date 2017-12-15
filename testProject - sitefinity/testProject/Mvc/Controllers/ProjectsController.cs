using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;
using Telerik.Sitefinity.DynamicModules.Model;
using Telerik.Sitefinity.DynamicModules;
using Telerik.Sitefinity.Utilities.TypeConverters;
using Telerik.Sitefinity.Model;

using Telerik.Sitefinity;
using Telerik.Sitefinity.Versioning;
using Telerik.Sitefinity.Data;
using Telerik.Sitefinity.Security;
using System.Text.RegularExpressions;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "Projects", Title = "Projects", SectionName = "MvcWidgets")]
    [Telerik.Sitefinity.Web.UI.ControlDesign.ControlDesigner(typeof(WidgetDesigners.Projects.ProjectsDesigner))]
    public class ProjectsController : Controller
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [Category("String Properties")]
        public string Message { get; set; }

        #region Managers
        public DynamicModuleManager DynamicModuleManager
        {
            get
            {
                if (dynamicModuleManager == null)
                {
                    dynamicModuleManager = DynamicModuleManager.GetManager();
                }
                return dynamicModuleManager;
            }
        }
        #endregion


        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {
            return View("Default", RetrieveCollectionOfProjects());
        }

        public ActionResult Detail(string urlName)
        {
            var projectModel = new ProjectsModel();
         
            DynamicContent project = RetrieveCollectionOfProjects().Where(p => p.UrlName == urlName).SingleOrDefault();

            projectModel.Title = project.GetString("Title");

            projectModel.Bugs = RetrieveCollectionOfBugs()
                .Where(b => b.SystemParentId == DynamicModuleManager.Lifecycle.GetMaster(project).Id);

            return View("Detail", projectModel);
        }

        public ActionResult Bugs(string urlName)
        {
            DynamicContent bug = RetrieveCollectionOfBugs()
                .Where(p => p.UrlName == urlName).SingleOrDefault();

            return View("BugDetail", bug);
        }

        // Demonstrates how a collection of Projects can be retrieved
        public IQueryable<DynamicContent> RetrieveCollectionOfProjects()
        {
            // Set the provider name for the DynamicModuleManager here. All available providers are listed in
            // Administration -> Settings -> Advanced -> DynamicModules -> Providers
            var providerName = String.Empty;

            // Set a transaction name
            var transactionName = "someTransactionName";

            DynamicModuleManager dynamicModuleManager = DynamicModuleManager.GetManager(providerName, transactionName);
            Type projectsType = TypeResolutionService.ResolveType("Telerik.Sitefinity.DynamicTypes.Model.BugTracking.Projects");
            CreateProjectsItem(dynamicModuleManager, projectsType, transactionName);

            // This is how we get the collection of Project items
            var myCollection = dynamicModuleManager.GetDataItems(projectsType)
                .Where(p => p.Status == Telerik.Sitefinity.GenericContent.Model.ContentLifecycleStatus.Live && p.Visible == true); 
            // At this point myCollection contains the items from type projectsType
            return myCollection;
        }

        // Creates a new projects item
        private void CreateProjectsItem(DynamicModuleManager dynamicModuleManager, Type projectsType, string transactionName)
        {
            DynamicContent projectsItem = dynamicModuleManager.CreateDataItem(projectsType);

            // This is how values for the properties are set 
            projectsItem.SetValue("Title", "Some Title");
            projectsItem.SetValue("Description", "Some Description");


            projectsItem.SetString("UrlName", "SomeUrlName");
            projectsItem.SetValue("Owner", SecurityManager.GetCurrentUserId());
            projectsItem.SetValue("PublicationDate", DateTime.UtcNow);


            projectsItem.SetWorkflowStatus(dynamicModuleManager.Provider.ApplicationName, "Draft");

            // Create a version and commit the transaction in order changes to be persisted to data store
            var versionManager = VersionManager.GetManager(null, transactionName);
            versionManager.CreateVersion(projectsItem, false);
            TransactionManager.CommitTransaction(transactionName);
        }

        //// Demonstrates how a collection of Projects can be retrieved
        //public IQueryable<DynamicContent> RetrieveCollectionOfProjects()
        //{
        //    // This is how we get the collection of Project items
        //    var myCollection = dynamicModuleManager
        //        .GetDataItems(projectsType)
        //        .Where(p => p.Status == Telerik.Sitefinity.GenericContent.Model.ContentLifecycleStatus.Live && p.Visible == true);
        //    // At this point myCollection contains the items from type projectsType
        //    return myCollection;
        //}

        //private readonly Type projectsType = TypeResolutionService.ResolveType("Telerik.Sitefinity.DynamicTypes.Model.BugTracking.Projects");
        private DynamicModuleManager dynamicModuleManager;

        // Demonstrates how a collection of Bugs can be retrieved
        public IQueryable<DynamicContent> RetrieveCollectionOfBugs()
        {
            // Set the provider name for the DynamicModuleManager here. All available providers are listed in
            // Administration -> Settings -> Advanced -> DynamicModules -> Providers
            var providerName = String.Empty;

            // Set a transaction name
            var transactionName = "someTransactionName";

            DynamicModuleManager dynamicModuleManager = DynamicModuleManager.GetManager(providerName, transactionName);
            Type bugType = TypeResolutionService.ResolveType("Telerik.Sitefinity.DynamicTypes.Model.BugTracking.Bug");
            CreateBugItem(dynamicModuleManager, bugType, transactionName);

            // This is how we get the collection of Bug items
            var myCollection = dynamicModuleManager.GetDataItems(bugType)
                .Where(p => p.Status == Telerik.Sitefinity.GenericContent.Model.ContentLifecycleStatus.Live && p.Visible == true); 
            // At this point myCollection contains the items from type bugType
            return myCollection;
        }

        // Creates a new bug item
        private void CreateBugItem(DynamicModuleManager dynamicModuleManager, Type bugType, string transactionName)
        {
            DynamicContent bugItem = dynamicModuleManager.CreateDataItem(bugType);

            // This is how values for the properties are set 
            bugItem.SetValue("Title", "Some Title");
            bugItem.SetValue("Description", "Some Description");
            // Set the selected value 
            bugItem.SetValue("Priority", "Option2");


            bugItem.SetString("UrlName", "SomeUrlName");
            bugItem.SetValue("Owner", SecurityManager.GetCurrentUserId());
            bugItem.SetValue("PublicationDate", DateTime.UtcNow);



            bugItem.SetWorkflowStatus(dynamicModuleManager.Provider.ApplicationName, "Draft");

            // Create a version and commit the transaction in order changes to be persisted to data store
            var versionManager = VersionManager.GetManager(null, transactionName);
            versionManager.CreateVersion(bugItem, false);
            TransactionManager.CommitTransaction(transactionName);
        }

      private readonly  Type projectsType = TypeResolutionService.ResolveType("Telerik.Sitefinity.DynamicTypes.Model.BugTracking.Projects");
        private readonly Type bugType = TypeResolutionService.ResolveType("Telerik.Sitefinity.DynamicTypes.Model.BugTracking.Bug");

        [HttpPost]
        public ActionResult CreateBug(BugsModel bug)
        {
            DynamicContent masterProject = DynamicModuleManager.GetDataItem(projectsType, bug.SystemParentId);

            var newBug = dynamicModuleManager.CreateDataItem(bugType);

            newBug.SetValue("Title", bug.Title);
            newBug.UrlName = Regex.Replace(bug.Title.ToLower(), @"[^\w\-\!\$\'\(\)\=\@\d_]+", "-");
            newBug.SetValue("Description", bug.Description);
            newBug.SetValue("SystemParentId", masterProject.OriginalContentId);
            newBug.ApprovalWorkflowState = "Published";

            DynamicModuleManager.Lifecycle.Publish(newBug);

            DynamicModuleManager.SaveChanges();

            return RedirectToAction("Detail", new { urlName = masterProject.UrlName });
        }

        public ActionResult CreateBug(string projectUrlName)
        {
            BugsModel bugsModel = new BugsModel();
            Guid liveProjectId = RetrieveCollectionOfProjects().Where(p => p.UrlName == projectUrlName).SingleOrDefault().Id;
            bugsModel.SystemParentId = liveProjectId;

            return View("BugForm", bugsModel);
        }

    }
}