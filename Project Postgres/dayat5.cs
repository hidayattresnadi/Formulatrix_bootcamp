using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkTutorial;

public class Northwind : DbContext
{
	public DbSet<Category> Categories { get; set; }
	public DbSet<Product> Products { get; set; }
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=myDB;Username=postgres;Password=postgres");
	}
}