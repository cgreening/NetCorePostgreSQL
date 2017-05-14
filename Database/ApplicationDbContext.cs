using System;
using Microsoft.EntityFrameworkCore;

namespace MyFirstWebAPI.Database
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<Entities.Test> TestRecords { get; set; }
  }
}