using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderPickupApp.Data;
using OrderPickupApp.Models;

namespace OrderPickupApp.Controllers;

public class OrdersController : Controller
{
    private readonly OrdersContext _context;

    public OrdersController(OrdersContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Orders.ToListAsync());
    }

    public async Task<IActionResult> Details(int id)
    {
        var order = await _context.Orders.FindAsync(id);
        if (order == null) return NotFound();
        return View(order);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Order order)
    {
        if (!ModelState.IsValid)
            return View(order);

        _context.Add(order);
        order.PickupDate = DateTime.SpecifyKind(order.PickupDate, DateTimeKind.Utc);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
}