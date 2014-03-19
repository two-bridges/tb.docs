using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Dynamic;

namespace tb.docs.Controllers
{
    public class DocsController : Controller
    {
        //
        // GET: /Docs/
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Docs/GithubSetup
        [AllowAnonymous]
        public ActionResult GithubSetup()
        {
            return View();
        }

        
        // GET: /Docs/DevSetup
        [AllowAnonymous]
        public ActionResult DevSetup(string page)
        {
            
            ViewBag.current_page = page;
            Dictionary<string, PageConfig> oPages = new Dictionary<string, PageConfig>();
            oPages.Add("git", new PageConfig("git", "Github"));
            oPages.Add("another", new PageConfig("another", "Another Page"));
            ViewBag.pages = oPages;

            foreach (var oPage in ViewBag.pages)
            {

                if (oPage.Value.Name == page)
                {
                    oPage.Value.isActive = true;
                }
            }
            return View();
        }

        private PageConfig page_config(string name, string label)
        {
            return new PageConfig(name, label);
        }

    }

    public class PageConfig
    {
        public PageConfig(string name, string label)
        {
            this.Name = name;
            this.Label = label;
        }

        public string Name { get; set; }
        public string Label { get; set; }
        public Boolean isActive { get; set; }
    }
}

