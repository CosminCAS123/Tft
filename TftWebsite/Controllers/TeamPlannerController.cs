using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TftWebsite.Controllers
{
    public class TeamPlannerController : Controller
    {


        // GET: TeamPlannerController/Create
        //create page
        //main page
        
        public ActionResult Create()
        {
            return View();
        }

        // POST: TeamPlannerController/Create
        //click create button
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TeamPlannerController/Edit/username
        //edit existing team page
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TeamPlannerController/Edit/5
        //edit existing team in the db
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TeamPlannerController/Delete/5
        //delete page
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TeamPlannerController/Delete/5
        //clicking delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
