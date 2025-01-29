using Microsoft.EntityFrameworkCore;
using PizzaStore.Models;

namespace PizzaStore.Data;

public class PizzaDB : DbContext
{
    public PizzaDB(DbContextOptions options) : base(options) { }
    public DbSet<Pizza> Pizzas { get; set; } = null;
}