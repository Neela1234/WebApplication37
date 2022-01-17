using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication37.Models;

namespace WebApplication37.Data
{
    public class WebApplication37Context : DbContext
    {
        public WebApplication37Context (DbContextOptions<WebApplication37Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication37.Models.Customer> Customer { get; set; }
    }
}
