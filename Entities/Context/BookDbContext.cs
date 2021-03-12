
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Entities.Context
{
    public class BookDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TelephoneBook;Trusted_Connection=true");
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
