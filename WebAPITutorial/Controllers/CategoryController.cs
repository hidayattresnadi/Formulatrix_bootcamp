using System.Net.NetworkInformation;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPITutorial.Data;
using WebAPITutorial.Model.DTOs;
using WebAPITutorial.Models;

namespace WebAPITutorial.Controllers;

public class CategoryController : APIBaseController
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;
    public CategoryController(DataContext context,IMapper mapper)
	{
		_context = context;
        _mapper=mapper;
	}
	[HttpGet]
	public IActionResult GetAllCategory()
	{
		var categories = _context.Categories.Include(c=>c.Products);
        // DTO Data Transfer Object : jadi biar data-data yang dari database itu disaring lagi sehinngga dimunculkan data2 yang hanya emang perlu aja
        // List<CategoryDTO> categoriesRespond = new();
        // foreach (var category in categories)
        // {
        //     categoriesRespond.Add(new CategoryDTO{
        //         CategoryName=category.CategoryName,
        //         Description=category.Description
        //     });  
        // }
        // versi Mapper
        List<CategoryDTO> categoriesRespond = _mapper.Map<List<CategoryDTO>>(categories);
		return Ok(categoriesRespond);
	}
    // otomatis dapet id barangnya dari param
    [HttpGet("{id}")]
    public IActionResult GetCategory(int id)
	{
		var category = _context.Categories.Include(c=>c.Products).FirstOrDefault(c=>c.CategoryId==id);
        if(category is null){
            return NotFound("Category not found");
        }
		return Ok(category);
	}

    [HttpPost]
    public IActionResult AddCategory([FromBody]Category? category)
	{
        if(category is null){
            return NotFound("please fill the required data");
        }
        _context.Categories.Add(category);
        _context.SaveChanges();
		return Ok(category);
	}

    // versi DTO

    public IActionResult AddCategory1([FromBody]CategoryDTO? category)
	{
        if(category is null){
            return NotFound("please fill the required data");
        }
        Category category1 = new();
        category1.CategoryName=category.CategoryName;
        category1.Description=category.Description;
        _context.Categories.Add(category1);
        _context.SaveChanges();
		return Ok(category);
	}
    // versi Mapper
    public IActionResult AddCategoryMapper([FromBody]CategoryDTO? category)
	{
        if(category is null){
            return NotFound("please fill the required data");
        }
        Category category1 = _mapper.Map<Category>(category);
        _context.Categories.Add(category1);
        _context.SaveChanges();
		return Ok(category);
	}

    [HttpPut("{id}")]
    public IActionResult UpdateCategory(int id,[FromBody]Category? category){
        if(category is null) {
            return NotFound("Please fill required data");
        }
        var foundCategory = _context.Categories.FirstOrDefault(c=>c.CategoryId==id);
        if(foundCategory is null){
            return NotFound("id of category is not found");
        }
        if(category.CategoryName is null){
            return NotFound("Please fill categoryName");
        }
        if(category.Description is null){
            return NotFound("Please fill description");
        }
        foundCategory.CategoryName=category.CategoryName;
        foundCategory.Description=category.Description;
        _context.SaveChanges();
        return Ok(category);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteCategory(int id){
        var foundCategory = _context.Categories.FirstOrDefault(c=>c.CategoryId==id);
        if(foundCategory is null){
            return NotFound("id of category is not found");
        }
        _context.Categories.Remove(foundCategory);
        _context.SaveChanges();
        return Ok(foundCategory);
    }
}