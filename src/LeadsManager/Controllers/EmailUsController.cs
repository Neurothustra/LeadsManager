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
    public class EmailUsController : Controller
    {
        private readonly LeadsContext _context;
        private ToXml toXml = new ToXml();

        public EmailUsController(LeadsContext context)
        {
            _context = context;    
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.EmailUs.ToListAsync());
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emailUs = await _context.EmailUs.SingleOrDefaultAsync(m => m.id == id);
            if (emailUs == null)
            {
                return NotFound();
            }

            return View(emailUs);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,DateSynced,IsSynced,dropdown_list_field_controller,pragraph_text_field_controller,text_field_controller,text_field_controller_0,text_field_controller_1,text_field_controller_2")] EmailUs emailUs)
        {
            if (ModelState.IsValid)
            {
                emailUs.id = Guid.NewGuid();
                _context.Add(emailUs);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(emailUs);
        }

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emailUs = await _context.EmailUs.SingleOrDefaultAsync(m => m.id == id);
            if (emailUs == null)
            {
                return NotFound();
            }
            return View(emailUs);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("id,DateSynced,IsSynced,dropdown_list_field_controller,pragraph_text_field_controller,text_field_controller,text_field_controller_0,text_field_controller_1,text_field_controller_2")] EmailUs emailUs)
        {
            if (id != emailUs.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emailUs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmailUsExists(emailUs.id))
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
            return View(emailUs);
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emailUs = await _context.EmailUs.SingleOrDefaultAsync(m => m.id == id);
            if (emailUs == null)
            {
                return NotFound();
            }

            return View(emailUs);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var emailUs = await _context.EmailUs.SingleOrDefaultAsync(m => m.id == id);
            _context.EmailUs.Remove(emailUs);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool EmailUsExists(Guid id)
        {
            return _context.EmailUs.Any(e => e.id == id);
        }

        public async Task<IActionResult> BuildXml(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EmailUs emailUs = await _context.EmailUs.SingleOrDefaultAsync(x => x.id == id);

            if (emailUs == null)
            {
                return NotFound();
            }

            var xmlify = toXml.BuildFormXml(emailUs);
            ViewBag.Xml = xmlify.ToString(SaveOptions.DisableFormatting);

            return View(emailUs);
        }
    }
}
