﻿using CrudDDD.Domain.Entities;
using CrudDDD.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace CrudDDD.Infra.Data.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>(new UserMap().Configure);
        }


    }
}
