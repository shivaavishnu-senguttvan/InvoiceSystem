using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
using Invoice.Infrastructure;
using Invoice.Models;

namespace Invoice.Data
{
    public class InvoiceDbContext :
        IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>
    {

        public InvoiceDbContext(DbContextOptions<InvoiceDbContext> options)
              : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Users> UserList { get; set; }
        public DbSet<Invoice.Models.Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
