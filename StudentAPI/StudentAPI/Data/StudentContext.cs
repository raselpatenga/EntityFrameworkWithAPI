using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Data
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentContext(DbContextOptions options) : base(options)
        {
        }
    }
}
