using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCRUD.Models;

namespace WebApiCRUD.Contexts
{
    public class ApiDbContext:DbContext
    {
        //using String ConnectionString;-------FirstApproach
 
        // private string _connectionString;
        //  public DbSet<Student> Students { get; set; }
        //public ApiDbContext()
        //{
        //    _connectionString = @"Server=DESKTOP-G2KIJII\SQLEXPRESS;Database=apidb6;User Id=sa;Password=subroto";
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(_connectionString);
        //    base.OnConfiguring(optionsBuilder);
        //}


        //Read Connection String From appSetting.json
        public DbSet<Student> Students { get; set; }
        public ApiDbContext()
        {
        }
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        {
        }
    }
}
