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
    public class InquiriesController : Controller
    {
        private readonly LeadsContext _context;
        private ToXml toXml = new ToXml();

        public InquiriesController(LeadsContext context)
        {
            _context = context;    
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Inquiry.ToListAsync());
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inquiry = await _context.Inquiry.SingleOrDefaultAsync(m => m.id == id);
            if (inquiry == null)
            {
                return NotFound();
            }

            return View(inquiry);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,DateSynced,IsSynced,ad_type,apartment_number,city,confirm_email,country,diploma_or_ged,email_address,evaluation,first_name,how_did_you_hear,how_soon_start,last_name,maiden_name,middle_name,military,name_of_event,other_country,previously_attended,primary_phone,primary_phone_type,program_concentration,program_degree,programs_interested,referral_employer,referral_other_employer,referral_other_school,referral_school,referral_source,referred_by,referred_by_whom,secondary_phone,secondary_phone_type,state_name,street_address,stte,suffix,zip_code")] Inquiry inquiry)
        {
            if (ModelState.IsValid)
            {
                inquiry.id = Guid.NewGuid();
                _context.Add(inquiry);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(inquiry);
        }

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inquiry = await _context.Inquiry.SingleOrDefaultAsync(m => m.id == id);
            if (inquiry == null)
            {
                return NotFound();
            }
            return View(inquiry);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("id,DateSynced,IsSynced,ad_type,apartment_number,city,confirm_email,country,diploma_or_ged,email_address,evaluation,first_name,how_did_you_hear,how_soon_start,last_name,maiden_name,middle_name,military,name_of_event,other_country,previously_attended,primary_phone,primary_phone_type,program_concentration,program_degree,programs_interested,referral_employer,referral_other_employer,referral_other_school,referral_school,referral_source,referred_by,referred_by_whom,secondary_phone,secondary_phone_type,state_name,street_address,stte,suffix,zip_code")] Inquiry inquiry)
        {
            if (id != inquiry.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inquiry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InquiryExists(inquiry.id))
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
            return View(inquiry);
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inquiry = await _context.Inquiry.SingleOrDefaultAsync(m => m.id == id);
            if (inquiry == null)
            {
                return NotFound();
            }

            return View(inquiry);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var inquiry = await _context.Inquiry.SingleOrDefaultAsync(m => m.id == id);
            _context.Inquiry.Remove(inquiry);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool InquiryExists(Guid id)
        {
            return _context.Inquiry.Any(e => e.id == id);
        }

        public async Task<IActionResult> BuildXml(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Inquiry inquiry = await _context.Inquiry.SingleOrDefaultAsync(x => x.id == id);

            if (inquiry == null)
            {
                return NotFound();
            }

            var xmlify = toXml.BuildFormXml(inquiry);
            ViewBag.Xml = xmlify.ToString(SaveOptions.DisableFormatting);

            return View(inquiry);
        }
    }
}
