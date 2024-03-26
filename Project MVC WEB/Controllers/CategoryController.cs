using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_MVC_WEB.Data;
using Project_MVC_WEB.Models;

namespace Project_MVC_WEB.Controllers;

public class CategoryController : Controller
{
	private readonly DataContext _context;

	public CategoryController(DataContext context)
	{
		_context = context;
	}

	public IActionResult Index()
	{
		var categories = _context.Categories;
		return View(categories);
	}
    // di bawah buat render page createnya

    public IActionResult Create()
	{
		return View();
	}

    // d bawah buat masukin data ke database dari usernya
    [HttpPost]

    public IActionResult Create(Category category){
    // input the ccategory to database
		_context.Categories.Add(category);
		_context.SaveChanges();
        // make redirectToAction biar kembali ke controller CategoryController trus eksekusi IActionResult Index()
		return RedirectToAction("Index");
    }

    public IActionResult Delete(int? id)
	{
        if(id is null || id is 0 ){
            return RedirectToAction("Index");
        }
        var category = _context.Categories.Find(id);
        if(category is null){
            TempData["error"] = "Category not found";
            return RedirectToAction("Index");
        }
        TempData["success"] = $"Category with name {category.CategoryName} has been deleted successfully";
        _context.Categories.Remove(category);
        _context.SaveChanges();
		return RedirectToAction("Index");
	}

    public IActionResult Update(int? id){
        if(id is null || id is 0 ){
            TempData["error"] = "Category is not valid";
            return RedirectToAction("Index");
        }
        var category = _context.Categories.Find(id);
        if(category is null){
            TempData["error"] = "Category not found";
            return RedirectToAction("Index");
        }
        TempData["success"] = $"Category with name {category.CategoryName} has been updated successfully";
        return View(category);
    }

    [HttpPost]

    public IActionResult Update(Category category){
        _context.Categories.Update(category);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}