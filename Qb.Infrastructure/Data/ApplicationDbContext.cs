using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using Qb.Domain.Entities;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    // DbSets for your entities
    public DbSet<User> Users { get; set; }    
    public DbSet<Category> Categories { get; set; } 
    
    public DbSet<Answer> Answers { get; set; }
    
    public DbSet<Question> Questions { get; set; }
    
    public DbSet<Quiz> Quizzes { get; set; }
    
    public DbSet<Battle> Battles { get; set; }
    
    public DbSet<History> Histories { get; set; }
    
}