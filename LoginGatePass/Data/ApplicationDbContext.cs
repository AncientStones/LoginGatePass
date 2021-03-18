using LoginGatePass.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginGatePass.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //Adding the 'Visitors' model that was added to the database
        public DbSet<Visitor> Visitors { get; set; } //DbSet of type 'Visitors'
    }
}
