using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieU.Models;

namespace MovieU.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<TvShow> TvShows { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}