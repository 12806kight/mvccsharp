using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace ModelViewController.Data
{
    public class ModelViewControllerContext : DbContext
    {
        public ModelViewControllerContext (DbContextOptions<ModelViewControllerContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
