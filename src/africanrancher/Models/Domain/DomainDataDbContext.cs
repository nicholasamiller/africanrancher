﻿using Microsoft.Data.Entity;

namespace africanrancher.Models.Domain
{
    public class DomainDataDbContext : DbContext
    {
        public DomainDataDbContext()
        {
        }

        public DbSet<BreedType> Breeds { get; set; }
        
        // We use the Table Per Hierarchy (TPH) strategy to map Female Cows and Male Cows to a single table, for performance and simplicity, at the expense of some non-normalization.
        public DbSet<Cow> Cows { get; set; }  
        
        public DbSet<Heard> Heards { get; set; } 

        public DbSet<HeardMovement> HeardMovements { get; set; } 
        public DbSet<Weighing> Weighings { get; set; }
        public DbSet<Ailment> Ailments { get; set; } 
        public DbSet<Treatment> Treatments { get; set; } 


    }
}
