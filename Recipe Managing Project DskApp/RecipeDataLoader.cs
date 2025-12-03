using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Recipe_Managing_Project_DskApp.Models;
using Recipe_Managing_Project_DskApp;
using Recipe_Managing_Project_DskApp.DB;

namespace Recipe_Managing_Project_DskApp.Data
{
    internal class RecipeDataLoader
    {
    }
}
public static class RecipeDataLoader
{
    
    public static List<Recipe> LoadRecipes(string xmlPath)
    {
        var recipes = new List<Recipe>();
        var xdoc = XDocument.Load(xmlPath);
        foreach (var xRecipe in xdoc.Descendants("Recipe"))
        {
            
            var name = (string)xRecipe.Element("Name");
            var instructions = "No instructions provided";

            var ingredients = xRecipe.Elements("ingredients")
                .Select(x => (string)x.Attribute("name"))
                .Where(x => !string.IsNullOrEmpty(x))
                .ToList();
            var intolerances = xRecipe.Elements("intolerances")?
                .Attributes()
                .Where(x => x.Value.Equals("True", StringComparison.OrdinalIgnoreCase))
                .Select(x => x.Name.LocalName)
                .ToList() ?? new List<string>();
            var recipe = new Recipe
            {
                Name = name,
                Instructions = instructions,
                Ingredients = ingredients,
                Intolerances = intolerances
            };
           
            recipes.Add(recipe);
        }
        return recipes;
    }
}