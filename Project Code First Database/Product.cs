using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirst;

public class Product
{
	[Key]
	public int ProductId { get; set; }
	[Required, MaxLength(40)]
	public string ProductName { get; set; } = null!;
	public int CategoryId { get; set; }
	[Column("UnitInStock", TypeName = "smallint")]
	public short Stock { get; set; }
	public int Price { get; set; }
	public Category Category { get; set; }
}