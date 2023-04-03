﻿using Microsoft.EntityFrameworkCore;

namespace Task.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Member> Members;
    }
}
