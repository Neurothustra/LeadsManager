using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LeadsManager.Data;
using LeadsManager.Models;
using System.Xml.Linq;

namespace LeadsManager.Controllers
{
    public class LandingPagesController : Controller
    {
        private readonly LeadsContext _context;
        private ToXml toXml = new ToXml();

        public LandingPagesController(LeadsContext context)
        {
            _context = context;    
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.LandingPage.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landingPage = await _context.LandingPage.SingleOrDefaultAsync(m => m.Id == id);
            if (landingPage == null)
            {
                return NotFound();
            }

            return View(landingPage);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Address,Age,City,Country,DateCreated,DateSynced,DesiredStart,Email,FirstName,FormName,HSGradYear,HighestEduCompleted,IsSynced,Key,LastName,MilitaryAffiliation,OptInConsent,Phone,PreferredContact,Prefix,ProgramInterest,State,VendorName,ZipCode")] LandingPage landingPage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(landingPage);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(landingPage);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landingPage = await _context.LandingPage.SingleOrDefaultAsync(m => m.Id == id);
            if (landingPage == null)
            {
                return NotFound();
            }
            return View(landingPage);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Address,Age,City,Country,DateCreated,DateSynced,DesiredStart,Email,FirstName,FormName,HSGradYear,HighestEduCompleted,IsSynced,Key,LastName,MilitaryAffiliation,OptInConsent,Phone,PreferredContact,Prefix,ProgramInterest,State,VendorName,ZipCode")] LandingPage landingPage)
        {
            if (id != landingPage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(landingPage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LandingPageExists(landingPage.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(landingPage);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landingPage = await _context.LandingPage.SingleOrDefaultAsync(m => m.Id == id);
            if (landingPage == null)
            {
                return NotFound();
            }

            return View(landingPage);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var landingPage = await _context.LandingPage.SingleOrDefaultAsync(m => m.Id == id);
            _context.LandingPage.Remove(landingPage);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool LandingPageExists(int id)
        {
            return _context.LandingPage.Any(e => e.Id == id);
        }

        public async Task<IActionResult> BuildXml(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            LandingPage landingPage = await _context.LandingPage.SingleOrDefaultAsync(x => x.Id == id);

            if (landingPage == null)
            {
                return NotFound();
            }

            var xmlify = toXml.BuildFormXml(landingPage);
            ViewBag.Xml = xmlify.ToString(SaveOptions.DisableFormatting);

            return View(landingPage);
        }
    }
}
