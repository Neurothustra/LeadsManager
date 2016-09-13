using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LeadsManager.Models;
using LeadsManager.Data;

namespace LeadsManager.Controllers
{
    public class TalismaController : Controller
    {
        private readonly TalismaContext _context;

        public TalismaController(TalismaContext context)
        {
            _context = context;    
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Talisma.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var talisma = await _context.Talisma.SingleOrDefaultAsync(m => m.aSyncMailID == id);
            if (talisma == null)
            {
                return NotFound();
            }

            return View(talisma);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("aSyncMailID,bHasAttachment,mMsgContent,nAliasID,nDeliveryStatus,nEventID,nLanguageID,nMailType,nTeamID,tBcc,tCc,tFrom,tSubject,tTo")] Talisma talisma)
        {
            if (ModelState.IsValid)
            {
                _context.Add(talisma);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(talisma);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var talisma = await _context.Talisma.SingleOrDefaultAsync(m => m.aSyncMailID == id);
            if (talisma == null)
            {
                return NotFound();
            }
            return View(talisma);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("aSyncMailID,bHasAttachment,mMsgContent,nAliasID,nDeliveryStatus,nEventID,nLanguageID,nMailType,nTeamID,tBcc,tCc,tFrom,tSubject,tTo")] Talisma talisma)
        {
            if (id != talisma.aSyncMailID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(talisma);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TalismaExists(talisma.aSyncMailID))
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
            return View(talisma);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var talisma = await _context.Talisma.SingleOrDefaultAsync(m => m.aSyncMailID == id);
            if (talisma == null)
            {
                return NotFound();
            }

            return View(talisma);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var talisma = await _context.Talisma.SingleOrDefaultAsync(m => m.aSyncMailID == id);
            _context.Talisma.Remove(talisma);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool TalismaExists(int id)
        {
            return _context.Talisma.Any(e => e.aSyncMailID == id);
        }
    }
}
