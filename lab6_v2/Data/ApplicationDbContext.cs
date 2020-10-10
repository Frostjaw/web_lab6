using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using lab6_v2.Models;

namespace lab6_v2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<lab6_v2.Models.Category> Category { get; set; }

        public DbSet<lab6_v2.Models.Post> Post { get; set; }

        public DbSet<lab6_v2.Models.Topic> Topic { get; set; }

        public DbSet<lab6_v2.Models.Image> Image { get; set; }
    }
}
