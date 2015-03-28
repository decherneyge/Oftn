using Oftn.Framework.Counters;
using Oftn.Framework.DBContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;




namespace Oftn.Controllers
{
    [Authorize]
    public class BasicCounterController : Controller
    {
        // GET: BasicCounter
        public ActionResult Index()
        {

            var userId = User.Identity.GetUserId();

            return View(getCountersForCurrentUser(userId));
        }

        private List<BasicCounter> getCountersForCurrentUser(string userId)
        {
            List<BasicCounter> usersCounters = new List<BasicCounter>();
            using (var context = new CounterContext())
            {
                usersCounters.AddRange(context.Counters.Where(c => c.OwnerId == userId));
            }

            return usersCounters;
        }
    }
}