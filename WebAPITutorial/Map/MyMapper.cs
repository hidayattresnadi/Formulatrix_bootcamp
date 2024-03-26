using AutoMapper;
using WebAPITutorial.Model.DTOs;
using WebAPITutorial.Models;
namespace WebAPITutorial.Map;

public class MyMapper : Profile
{
	public MyMapper()
	{
		//CreteMap<Destination, Source>
        // kaya convert dari CategoryDTO class jadi Category Class
        // biar bisa bolak balik tujuannya, klo ga make reverse map, penerapannya jadi kaya di bawah lagi
		CreateMap<CategoryDTO, Category>().ReverseMap();
        CreateMap<ProductDTO,Product>().ReverseMap();
        // kaya gini
		//CreateMap<Category, CategoryDTO>()
		//CreateMap<CategoryDTO, Category>()
	}
}