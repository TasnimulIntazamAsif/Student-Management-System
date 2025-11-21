using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions <AppDBContext> contextOptions):base(contextOptions) 
        { 
        
        
        }

        public DbSet<Student> Students { get; set; }
        

    }
}
