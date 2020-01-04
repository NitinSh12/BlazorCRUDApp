using System.Collections.Generic;
using BlazorCRUDApp.Server.Data;
using BlazorCRUDApp.Shared.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorCRUDApp.Server.Controllers
{
    [Route("api/[controller]")]
    public class RecipeController : Controller
    {
        private RecipeDbOperations dbOpereations = new RecipeDbOperations();
        // GET: api/<controller>
        [HttpGet("recipes")]
        public IEnumerable<Recipe> GetRecipes()
        {
            return dbOpereations.GetAllRecipes();
        }

        // GET api/<controller>/5
        [HttpGet("detail/{id}")]
        public Recipe GetRecipeDetail(int id)
        {
            return dbOpereations.GetRecipeDetail(id);
        }

        // POST api/<controller>
        [HttpPost("create")]
        public void Post([FromBody]Recipe recipe)
        {
            if (ModelState.IsValid)
                dbOpereations.AddRecipe(recipe);
        }

        // PUT api/<controller>/5
        [HttpPut("edit")]
        public void Put([FromBody]Recipe recipe)
        {
            if (ModelState.IsValid)
                dbOpereations.UpdateRecipe(recipe);
        }

        // DELETE api/<controller>/5
        [HttpDelete("delete/{id}")]
        public void Delete(int id)
        {
            dbOpereations.DeleteRecipe(id);
        }
    }
}
