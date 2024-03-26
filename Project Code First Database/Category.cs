using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirst;

public class Category
{
	//ClassNameId = Primary Key jadi semisal di awal kita make CategoryId, nanti si categoryId ini otomatis jadi primary key
	[Key]
	public int CategoryId { get; set; }
    // required itu ketentuan harus diisi, max length berarti maksimal hanya 15 huruf
	[Required, MaxLength(15)]
    // buat ubah tipe data
	public string CategoryName { get; set; }
	[Column(TypeName = "ntext")]
	public string? Description { get; set; }
	public ICollection<Product> Products { get; set; }
	public Category() 
	{
		Products = new HashSet<Product>();
	}
}