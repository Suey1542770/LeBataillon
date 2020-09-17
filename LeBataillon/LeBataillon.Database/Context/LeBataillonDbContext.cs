using System;
using System.Collections.Generic;
using System.Linq;
using LeBataillon.Database.Initializer.DataFixtures;
using Microsoft.EntityFrameworkCore;
using LeBataillon.Database.Models;

namespace LeBataillon.Database.Context
{
    public class LeBataillonDbContext : DbContext
    {

        public DbSet<Player> Players { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseLazyLoadingProxies();

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var Data = new List<Player>();
            for (int i = 1; i < 100; i++)
            {
                var name = SampleData.GenerateName(i);
                Data.Add(new Player(i, $"{name}Alias", $"{name}@bataillonMail.com", SampleData.GeneratePhoneNumber(i), SampleData.GenerateName(i + 1), SampleData.GenerateLastName(i), SampleData.GenerateLevel()));
            }
            modelBuilder.Entity<Player>().HasData(Data);
        
        
        
        
        }


    }
}