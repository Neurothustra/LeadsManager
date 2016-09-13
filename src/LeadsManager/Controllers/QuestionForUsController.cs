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
    public class QuestionForUsController : Controller
    {
        private readonly LeadsContext _context;
        private ToXml toXml = new ToXml();

        public QuestionForUsController(LeadsContext context)
        {
            _context = context;    
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.QuestionForUs.ToListAsync());
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionForUs = await _context.QuestionForUs.SingleOrDefaultAsync(m => m.id == id);
            if (questionForUs == null)
            {
                return NotFound();
            }

            return View(questionForUs);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,DateSynced,IsSynced,dropdown_list_field_controller,pragraph_text_field_controller,text_field_controller,text_field_controller_0,text_field_controller_1,text_field_controller_2")] QuestionForUs questionForUs)
        {
            if (ModelState.IsValid)
            {
                questionForUs.id = Guid.NewGuid();
                _context.Add(questionForUs);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(questionForUs);
        }

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionForUs = await _context.QuestionForUs.SingleOrDefaultAsync(m => m.id == id);
            if (questionForUs == null)
            {
                return NotFound();
            }
            return View(questionForUs);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("id,DateSynced,IsSynced,dropdown_list_field_controller,pragraph_text_field_controller,text_field_controller,text_field_controller_0,text_field_controller_1,text_field_controller_2")] QuestionForUs questionForUs)
        {
            if (id != questionForUs.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(questionForUs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestionForUsExists(questionForUs.id))
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
            return View(questionForUs);
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionForUs = await _context.QuestionForUs.SingleOrDefaultAsync(m => m.id == id);
            if (questionForUs == null)
            {
                return NotFound();
            }

            return View(questionForUs);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var questionForUs = await _context.QuestionForUs.SingleOrDefaultAsync(m => m.id == id);
            _context.QuestionForUs.Remove(questionForUs);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool QuestionForUsExists(Guid id)
        {
            return _context.QuestionForUs.Any(e => e.id == id);
        }

        public async Task<IActionResult> BuildXml(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            QuestionForUs questionForUs = await _context.QuestionForUs.SingleOrDefaultAsync(x => x.id == id);

            if (questionForUs == null)
            {
                return NotFound();
            }

            var xmlify = toXml.BuildFormXml(questionForUs);
            ViewBag.Xml = xmlify.ToString(SaveOptions.DisableFormatting);

            return View(questionForUs);
        }
    }
}
