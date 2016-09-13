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
    public class ReferAFriendController : Controller
    {
        private readonly LeadsContext _context;
        private ToXml toXml = new ToXml();

        public ReferAFriendController(LeadsContext context)
        {
            _context = context;    
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.ReferAFriend.ToListAsync());
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referAFriend = await _context.ReferAFriend.SingleOrDefaultAsync(m => m.id == id);
            if (referAFriend == null)
            {
                return NotFound();
            }

            return View(referAFriend);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,DateSynced,IsSynced,pragraph_text_field_controller,text_field_controller,text_field_controller_0,text_field_controller_1,text_field_controller_2,text_field_controller_3,text_field_controller_4")] ReferAFriend referAFriend)
        {
            if (ModelState.IsValid)
            {
                referAFriend.id = Guid.NewGuid();
                _context.Add(referAFriend);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(referAFriend);
        }

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referAFriend = await _context.ReferAFriend.SingleOrDefaultAsync(m => m.id == id);
            if (referAFriend == null)
            {
                return NotFound();
            }
            return View(referAFriend);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("id,DateSynced,IsSynced,pragraph_text_field_controller,text_field_controller,text_field_controller_0,text_field_controller_1,text_field_controller_2,text_field_controller_3,text_field_controller_4")] ReferAFriend referAFriend)
        {
            if (id != referAFriend.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(referAFriend);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReferAFriendExists(referAFriend.id))
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
            return View(referAFriend);
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var referAFriend = await _context.ReferAFriend.SingleOrDefaultAsync(m => m.id == id);
            if (referAFriend == null)
            {
                return NotFound();
            }

            return View(referAFriend);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var referAFriend = await _context.ReferAFriend.SingleOrDefaultAsync(m => m.id == id);
            _context.ReferAFriend.Remove(referAFriend);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ReferAFriendExists(Guid id)
        {
            return _context.ReferAFriend.Any(e => e.id == id);
        }

        public async Task<IActionResult> BuildXml(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ReferAFriend referAFriend = await _context.ReferAFriend.SingleOrDefaultAsync(x => x.id == id);

            if (referAFriend == null)
            {
                return NotFound();
            }

            var xmlify = toXml.BuildFormXml(referAFriend);
            ViewBag.Xml = xmlify.ToString(SaveOptions.DisableFormatting);

            return View(referAFriend);
        }
    }
}
