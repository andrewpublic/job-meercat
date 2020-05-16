using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IssueTracker.Models;

namespace IssueTracker.Controllers
{
    public class IssuesController : Controller
    {
        // GET: Issues
        public ActionResult Random()
        {
            var issue = new Issue() { Name = "First Bug" };
            return View(issue);
        }
    }
}