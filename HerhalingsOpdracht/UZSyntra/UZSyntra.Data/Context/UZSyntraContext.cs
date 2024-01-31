using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UZSyntra.Data.Models;

namespace UZSyntra.Data.Context
{
    public class UZSyntraContext : IdentityDbContext

    {
        public UZSyntraContext(DbContextOptions<UZSyntraContext> options) : base(options)
        {
        }

        public DbSet<Bed> Beds { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Intake> Intakes { get; set; }
        public DbSet<Bed> Patients { get; set; }
        public DbSet<Bed> Rooms { get; set; }
    }
}
