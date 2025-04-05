using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions options) : base(options)
	{
	}

	public DbSet<Expense> Expenses { get; set; }
	public DbSet<Revenue> Revenues { get; set; }
	public DbSet<TransactionCategory> TransactionCategories { get; set; }
}