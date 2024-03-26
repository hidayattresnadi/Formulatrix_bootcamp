// See https://aka.ms/new-console-template for more information
﻿using Microsoft.EntityFrameworkCore.Storage;
using EntityFrameworkTutorial;
using Microsoft.EntityFrameworkCore;
class Program 
{
	static void Main() {
		using (Northwind db = new Northwind())
		{
			bool status = db.Database.CanConnect();
			Console.WriteLine($"Can connect: {status}");
			//Retrieve
				//LINQ
				//Select
				//Order
				//OrderByDesc
				//Where
				//FirstOrDefault
				//SelectMany
			
			List<Category> categories = db.Categories.ToList();
			foreach(var category in categories) 
			{
				Console.WriteLine($"{category.CategoryId} {category.CategoryName} {category.Description}");
			}
            // db.Categories.Find mencari berdasarkan primary key datanya

			Category? category1 = db.Categories.Find(8);

			Category? category2 = db.Categories.Where(c => c.CategoryId == 1).FirstOrDefault();
            // Category? category3 = db.Categories.Where(c => c.Products.Add() == 1).FirstOrDefault();
            Console.WriteLine(category2.CategoryId);
            Console.WriteLine(category2.CategoryName);
            Console.WriteLine("lollo");

			Category? result = db.Categories.Where(c => c.CategoryName.Contains("Seafood")).FirstOrDefault();
			if (result != null)
			{
				Console.WriteLine($"{result.CategoryId} {result.CategoryName} {result.Description}");
			}

			//Create
			// Category category3 = new Category()
			// {
			// 	CategoryName = "Yanto",
			// 	Description = "Yanto is a human"
			// };
			// db.Categories.Add(category3);
			// db.SaveChanges();

			//Update
			// Category? yanto = db.Categories.Find(9);
			// //Category? yanto = db.Categories.Where(c => c.CategoryName == "Yanto").FirstOrDefault();
			// if (yanto != null)
			// {
			// 	yanto.Description = "Yanto is a human being";
			// 	db.SaveChanges();
			// }


			//Delete
			// if(yanto is not null) 
			// {
			// 	db.Categories.Remove(yanto);
			// 	db.SaveChanges();
			// }

			//Retrieve With the Product
			string search = "Beverages";
			IEnumerable<Category> categories2 = db.Categories
			.Where(c => c.CategoryName.Contains(search))
			.Include(c => c.Products).ToList(); //Include => Eager Loading
			
			foreach(var category in categories2) 
			{
				Console.WriteLine($"{category.CategoryId} {category.CategoryName} {category.Description}");
				Console.WriteLine(category.Products.Count());
				foreach(var product in category.Products) 
				{
					Console.WriteLine($"\t{product.ProductName}");
				}
			}
			
			//Create new Product
			// Product product2 = new Product()
			// {
			// 	ProductName = "Yanto's Drink",
			// 	CategoryId = 1
			// };
			// db.Products.Add(product2);
			// db.SaveChanges();
		}
	}
}
