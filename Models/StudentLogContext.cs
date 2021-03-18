using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StudentLogs.Models
{
    public class StudentLogContext :DbContext
    {
        public StudentLogContext(DbContextOptions<StudentLogContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Contact> Contact { get; set; }
    }
}

