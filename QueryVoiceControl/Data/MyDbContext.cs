using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QueryVoiceControl.Models;
using Microsoft.EntityFrameworkCore;

namespace QueryVoiceControl.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Studente> Studenti { get; set; }
        public DbSet<Professore> Professori { get; set; }
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Studente>().ToTable("Studenti");
            modelBuilder.Entity<Professore>().ToTable("Professori");
        }
    }
}
