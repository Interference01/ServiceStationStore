﻿using Microsoft.EntityFrameworkCore;
using ServiceStationStore.Models;

namespace ServiceStationStore.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
