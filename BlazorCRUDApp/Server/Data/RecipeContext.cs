using BlazorCRUDApp.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUDApp.Server.Data
{
    public class RecipeContext:DbContext
    {
        public virtual DbSet<Recipe> tblRecipe { get; set; }
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=recipe_db;User Id=postgres;Password = sa@123; CommandTimeout = 20");
            }
        }
    }
}
