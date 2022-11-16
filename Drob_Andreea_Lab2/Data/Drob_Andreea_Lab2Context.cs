using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Drob_Andreea_Lab2.Models;

namespace Drob_Andreea_Lab2.Data
{
    public class Drob_Andreea_Lab2Context : DbContext
    {
        public Drob_Andreea_Lab2Context (DbContextOptions<Drob_Andreea_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Drob_Andreea_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Drob_Andreea_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Drob_Andreea_Lab2.Models.Author> Author { get; set; }

        public DbSet<Drob_Andreea_Lab2.Models.Category> Category { get; set; }

        public DbSet<Drob_Andreea_Lab2.Models.Member> Member { get; set; }

        public DbSet<Drob_Andreea_Lab2.Models.Borrowing> Borrowing { get; set; }
    }
}
