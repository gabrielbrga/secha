using System;
using Microsoft.EntityFrameworkCore;
using API.Models;

public class AppDataContext : DbContext
{
    public DbSet<Carro> Carros { get; set; }
    public DbSet<Modelo> Modelos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=gabriel.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Modelo>().HasData(
            new Modelo() {Id = 1, Name = "hatch"},
            new Modelo() {Id = 2, Name = "suv"},
            new Modelo() {Id = 3, Name = "sedan"} 
        );
    }
    
} 