using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nume_Pren_Lab2.Models;

namespace Onu_Andrei_Lab2.Data
{
    public class Onu_Andrei_Lab2Context : DbContext
    {
        public Onu_Andrei_Lab2Context (DbContextOptions<Onu_Andrei_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Nume_Pren_Lab2.Models.Book> Book { get; set; } = default!;
    }
}
