using FoodApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodApi.Data;

public class FoodApiDbContext(DbContextOptions<FoodApiDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Addition> Additions => Set<Addition>();
}

