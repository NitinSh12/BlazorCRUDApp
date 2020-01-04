using BlazorCRUDApp.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUDApp.Server.Data
{
    public class RecipeDbOperations
    {
        RecipeContext rc = new RecipeContext();

        //To Get all recipes   
        public IEnumerable<Recipe> GetAllRecipes()
        {
            try
            {
                return rc.tblRecipe.ToList();
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        //To Add new recipe     
        public void AddRecipe(Recipe recipe)
        {
            try
            {
                rc.tblRecipe.Add(recipe);
                rc.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update particular recipe    
        public void UpdateRecipe(Recipe recipe)
        {
            try
            {
                rc.Entry(recipe).State = EntityState.Modified;
                rc.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the particular recipe    
        public Recipe GetRecipeDetail(int id)
        {
            try
            {
                Recipe recipe = rc.tblRecipe.Find(id);
                return recipe;
            }
            catch
            {
                throw;
            }
        }

        //To Delete particular recipe    
        public void DeleteRecipe(int id)
        {
            try
            {
                Recipe recipe = rc.tblRecipe.Find(id);
                rc.tblRecipe.Remove(recipe);
                rc.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
