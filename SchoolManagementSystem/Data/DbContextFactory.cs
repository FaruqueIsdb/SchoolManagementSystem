﻿using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Data
{
    public class DbContextFactory : IDesignTimeDbContextFactory<SchoolDbContext>
    {
        public SchoolDbContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<SchoolDbContext>();
            optionBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database = SchoolSystemDb; Trusted_Connection=True;  trust server certificate = true;");

            return new SchoolDbContext(optionBuilder.Options);

        }
    }
}
