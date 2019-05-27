using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JobPortal.Models
{
    public class HorseRegistrationDbContext:DbContext
    {
        public HorseRegistrationDbContext(DbContextOptions<HorseRegistrationDbContext>options) : base(options:options) { }
        public DbSet<Member> Members { get; set; }
        public DbSet<Horse> Horses { get; set; }
        public DbSet<Account> Account { get; set; }
    }
}
