using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_mlopezfleming_ContactManager.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Family" },
                new Category { CategoryId = 2, Name = "Friend" },
                new Category { CategoryId = 3, Name = "Work" },
                new Category { CategoryId = 4, Name = "Other" }
                );

            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    FirstName = "Mary Ellen",
                    LastName = "Walton",
                    Phone = "555-123-4567",
                    Email = "maryEllenWalton@gmail.com",
                    CategoryId = 1,
                    DateAdded = DateTime.Now
                },
                new Contact
                {
                    ContactId = 2,
                    FirstName = "Mark",
                    LastName = "Ton",
                    Phone = "303-123-4547",
                    Email = "markTon@gmail.com",
                    CategoryId = 2,
                    DateAdded = DateTime.Now
                },
                new Contact
                {
                    ContactId = 3,
                    FirstName = "Angel",
                    LastName = "Lara",
                    Phone = "303-445-7788",
                    Email = "angelLara@gmail.com",
                    CategoryId = 3,
                    DateAdded = DateTime.Now
                });

        }
    }
}
