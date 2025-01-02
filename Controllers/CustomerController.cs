using DemoMvc.Data;
using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoMvc.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Customer.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Customer cus)
        {
            if(ModelState.IsValid)
            {
                _context.Add(cus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cus);
        }
        public async Task<IActionResult> Edit(string id)
        {
            if(id == null)
            {
                return NotFound();
            }   
            var cus = await _context.Customer.FindAsync(id);
            if (cus == null)
            {
                return NotFound();
            }
            return View(cus);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CustomerID,FullName,Address,Email")] Customer cus)
        {
            if (id != cus.CustomerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(cus.CustomerID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cus);
        }
        public async Task<IActionResult> Delete (string id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var cus = await _context.Customer
            .FirstOrDefaultAsync(m => m.CustomerID == id);
            if(cus == null)
            {
                return NotFound();
            }
            return View(cus);
        }

        private bool CustomerExists(string id)
        {
            return _context.Customer.Any(e => e.CustomerID == id);
        }
    }
}