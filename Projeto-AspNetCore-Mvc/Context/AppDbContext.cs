﻿using Microsoft.EntityFrameworkCore;
using Projeto_AspNetCore_Mvc.Models;

namespace Projeto_AspNetCore_Mvc.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias {get;set;}
        public DbSet<Lanche> Lanches { get; set; }
    }
}
