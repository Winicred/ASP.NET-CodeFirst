using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyWorld.Models;

namespace MyWorld.Controllers
{
    public class CountriesCityController : Controller
    {
        private CountryCityContext db = new CountryCityContext();

        // GET: CountriesCity
        public ActionResult Index()
        {
            return View(db.Countries.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Countries country = db.Countries.Find(id);
            country = db.Countries.Include(c => c.Cities).FirstOrDefault(c => c.Id == id);
            if (country == null)
            {
                return HttpNotFound();
            }
            return View(country);
        }
        public ActionResult CountryCityList(int? id)
        {
            var countryCity = db.Cities.Where(p => p.CountryId == id);
            return PartialView(countryCity);
        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        
        public FileContentResult GetImage(int id)
        {
            Cities cities = db.Cities.FirstOrDefault(g => g.Id == id);
            if (cities != null)
            {
                return File(cities.Photo, cities.PhotoType);
            }

            return null;
        }
    }
}
