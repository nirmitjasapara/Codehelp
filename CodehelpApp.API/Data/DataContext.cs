using CodehelpApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CodehelpApp.API.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options) {}
    public DbSet<Value> Values {get; set;}
    public DbSet<User> Users { get; set; }
    public DbSet<Question> Questions { get; set; }
  }
}
