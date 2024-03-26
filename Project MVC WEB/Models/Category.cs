using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Project_MVC_WEB.Models;

public class Category
{
	public int CategoryId { get; set; }
    [DisplayName("category nama")]
	public string CategoryName { get; set; } = null!;
	public string? Description { get; set; }
	public ICollection<Product> Products { get; set; }
	
	public Category()
	{
		Products = new List<Product>();
	}
}
