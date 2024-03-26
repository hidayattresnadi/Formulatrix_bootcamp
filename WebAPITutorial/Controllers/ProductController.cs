using WebAPITutorial.Data;
using WebAPITutorial.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace WebAPITutorial.Controllers;

public class ProductController : APIBaseController{
    private readonly DataContext _context;
    private readonly IMapper _mapper;
    public ProductController(DataContext context,IMapper mapper)
	{
		_context = context;
        _mapper=mapper;
	}

    [HttpGet]
    public IActionResult GetAllProducts()
	{
		var products = _context.Products.Include(p=>p.Category);
		return Ok(products);
	}

    [HttpGet("{id}")]
    public IActionResult GetProduct(int id)
	{
		var product = _context.Products.Include(p=>p.Category).FirstOrDefault(p=>p.CategoryId==id);
        if(product is null){
            return NotFound("product is not found");
        }
		return Ok(product);
	}



}