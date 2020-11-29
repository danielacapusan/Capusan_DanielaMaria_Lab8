using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Capusan_DanielaMaria_Lab8.Models;

namespace Capusan_DanielaMaria_Lab8.Data
{
    public class Capusan_DanielaMaria_Lab8Context : DbContext
    {
        public Capusan_DanielaMaria_Lab8Context (DbContextOptions<Capusan_DanielaMaria_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Capusan_DanielaMaria_Lab8.Models.Book> Book { get; set; }

        public DbSet<Capusan_DanielaMaria_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Capusan_DanielaMaria_Lab8.Models.Category> Category { get; set; }
    }
}
