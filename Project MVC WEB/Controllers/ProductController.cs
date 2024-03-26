using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_MVC_WEB.Data;
using Project_MVC_WEB.Models;

public class ProductController : Controller
{
    private readonly DataContext _context;

	public ProductController(DataContext context)
	{
		_context = context;
	}

	public IActionResult Index()
	{
		var products = _context.Products.Include(c=>c.Category);
		return View(products);
	}

    public IActionResult Create()
	{
		return View();
	}
    [HttpPost]
    public IActionResult Create(Product product)
	{
		_context.Products.Add(product);
		_context.SaveChanges();
        return RedirectToAction("Index");
	}

    public IActionResult Delete(int? id){
        if(id is null || id is 0){
            return RedirectToAction("Index");
        }
        var product = _context.Products.Find(id);
        if(product is null){
            return RedirectToAction("Index");
        }
        _context.Products.Remove(product);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Update(int? id){
        if(id is null || id is 0){
            return RedirectToAction("Index");
        }
        var product = _context.Products.Find(id);
        if(product is null){
            return RedirectToAction("Index");
        }
        return View(product);
    }
    [HttpPost]
    public IActionResult Update(Product product){
        _context.Products.Update(product);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}
