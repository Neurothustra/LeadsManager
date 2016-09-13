using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LeadsManager.Data;
using LeadsManager.Models;
using System.Xml.Linq;

namespace LeadsManager.Controllers
{
    public class OpenHousesController : Controller
    {
        private readonly LeadsContext _context;
        private ToXml toXml = new ToXml();

        public OpenHousesController(LeadsContext context)
        {
            _context = context;    
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.OpenHouse.ToListAsync());
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var openHouse = await _context.OpenHouse.SingleOrDefaultAsync(m => m.id == id);
            if (openHouse == null)
            {
                return NotFound();
            }

            return View(openHouse);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,DateSynced,IsSynced,ad_type,apartment_number,city,confirm_email,country,email_address,employer_name,employer_name_other,first_name,how_did_you_hear,last_name,maiden_name,middle_name,military_branch,name_of_event,name_of_state,open_house_session,other_country,primary_phone,primary_phone_type,program_concentration,program_degree,programs_interested,referral_source,referred_by,referred_by_whom,secondary_phone,secondary_phone_type,street_address,stte,suffix,zip_code")] OpenHouse openHouse)
        {
            if (ModelState.IsValid)
            {
                openHouse.id = Guid.NewGuid();
                _context.Add(openHouse);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(openHouse);
        }

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var openHouse = await _context.OpenHouse.SingleOrDefaultAsync(m => m.id == id);
            if (openHouse == null)
            {
                return NotFound();
            }
            return View(openHouse);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("id,DateSynced,IsSynced,ad_type,apartment_number,city,confirm_email,country,email_address,employer_name,employer_name_other,first_name,how_did_you_hear,last_name,maiden_name,middle_name,military_branch,name_of_event,name_of_state,open_house_session,other_country,primary_phone,primary_phone_type,program_concentration,program_degree,programs_interested,referral_source,referred_by,referred_by_whom,secondary_phone,secondary_phone_type,street_address,stte,suffix,zip_code")] OpenHouse openHouse)
        {
            if (id != openHouse.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(openHouse);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OpenHouseExists(openHouse.id))
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
            return View(openHouse);
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var openHouse = await _context.OpenHouse.SingleOrDefaultAsync(m => m.id == id);
            if (openHouse == null)
            {
                return NotFound();
            }

            return View(openHouse);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var openHouse = await _context.OpenHouse.SingleOrDefaultAsync(m => m.id == id);
            _context.OpenHouse.Remove(openHouse);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool OpenHouseExists(Guid id)
        {
            return _context.OpenHouse.Any(e => e.id == id);
        }

        public async Task<IActionResult> BuildXml(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OpenHouse openHouse = await _context.OpenHouse.SingleOrDefaultAsync(x => x.id == id);

            if (openHouse == null)
            {
                return NotFound();
            }

            var xmlify = toXml.BuildFormXml(openHouse);
            ViewBag.Xml = xmlify.ToString(SaveOptions.DisableFormatting);

            return View(openHouse);
        }
    }
}
