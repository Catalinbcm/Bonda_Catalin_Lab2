using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bonda_Catalin_Lab2.Models;

namespace Bonda_Catalin_Lab2.Data
{
    public class Bonda_Catalin_Lab2Context : DbContext
    {
        public Bonda_Catalin_Lab2Context (DbContextOptions<Bonda_Catalin_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Bonda_Catalin_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Bonda_Catalin_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Bonda_Catalin_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
