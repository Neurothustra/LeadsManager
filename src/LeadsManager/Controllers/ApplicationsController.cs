using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LeadsManager.Models;
using LeadsManager.Data;
using System.Xml.Linq;

namespace LeadsManager.Controllers
{
    public class ApplicationsController : Controller
    {
        private readonly LeadsContext _context;
        private ToXml toXml = new ToXml();

        public ApplicationsController(LeadsContext context)
        {
            _context = context;    
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Application.ToListAsync());
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Application.SingleOrDefaultAsync(m => m.id == id);
            if (application == null)
            {
                return NotFound();
            }

            return View(application);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,DateSynced,IsSynced,ad_type,apartment_name,citizenship_country,city,college_other,confirm_email,country,current_employer,currently_employed,date_of_birth,diploma_or_ged,email_address,employer_name,employer_other,ethnicity,first_name,gender_id,h_s_graduation_year,h_s_state,high_school_name,highest_level_education,how_did_you_hear,how_soon_start,last_name,maiden_name,middle_name,military_branch,name_of_event,name_of_state,other_country,previously_attended,primary_phone,primary_phone_type,program_concentration,program_degree,programs_interested,race,referral_source,referred_by,referred_by_whom,school_name,secondary_phone,seconday_phone_type,social_security,street_address,stte,suffix,zip_code")] Application application)
        {
            if (ModelState.IsValid)
            {
                application.id = Guid.NewGuid();
                _context.Add(application);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(application);
        }

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Application.SingleOrDefaultAsync(m => m.id == id);
            if (application == null)
            {
                return NotFound();
            }
            return View(application);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("id,DateSynced,IsSynced,ad_type,apartment_name,citizenship_country,city,college_other,confirm_email,country,current_employer,currently_employed,date_of_birth,diploma_or_ged,email_address,employer_name,employer_other,ethnicity,first_name,gender_id,h_s_graduation_year,h_s_state,high_school_name,highest_level_education,how_did_you_hear,how_soon_start,last_name,maiden_name,middle_name,military_branch,name_of_event,name_of_state,other_country,previously_attended,primary_phone,primary_phone_type,program_concentration,program_degree,programs_interested,race,referral_source,referred_by,referred_by_whom,school_name,secondary_phone,seconday_phone_type,social_security,street_address,stte,suffix,zip_code")] Application application)
        {
            if (id != application.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(application);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicationExists(application.id))
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
            return View(application);
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Application.SingleOrDefaultAsync(m => m.id == id);
            if (application == null)
            {
                return NotFound();
            }

            return View(application);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var application = await _context.Application.SingleOrDefaultAsync(m => m.id == id);
            _context.Application.Remove(application);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ApplicationExists(Guid id)
        {
            return _context.Application.Any(e => e.id == id);
        }

        public async Task<IActionResult> BuildXml(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Application application = await _context.Application.SingleOrDefaultAsync(x => x.id == id);

            if (application == null)
            {
                return NotFound();
            }

            var xmlify = toXml.BuildFormXml(application);
            ViewBag.Xml = xmlify.ToString(SaveOptions.DisableFormatting);

            return View(application);
        }
    }
}
