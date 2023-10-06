using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCBlog.Models;

    public class YourDbContext : DbContext
    {
        public YourDbContext (DbContextOptions<YourDbContext> options)
            : base(options)
        {
        }

        public DbSet<MVCBlog.Models.Post> Post { get; set; } = default!;

        public DbSet<MVCBlog.Models.Blog> Blog { get; set; } = default!;
    }
