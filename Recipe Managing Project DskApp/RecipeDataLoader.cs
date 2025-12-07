using Recipe_Managing_Project_DskApp;
using Recipe_Managing_Project_DskApp.DB;
//using Recipe_Managing_Project_DskApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using static Recipe_Managing_Project_DskApp.DB.recipe;


namespace Recipe_Managing_Project_DskApp.Data
{


    public class RecipeDataLoader
    {
        //the default execution path is in debug 
        string path = System.Environment.CurrentDirectory.Replace("bin\\Debug", "\\DB\\dataFile.xml");

        // forced pass of variables that are used by all the files
        XmlDocument xmlDoc = new XmlDocument();
        fileRead read;
        fileWrite write;
        List<recipe.Recipe> recipeList;

        public RecipeDataLoader()
        {
            read = new fileRead(xmlDoc, path);
            write = new fileWrite(xmlDoc, path);
        }

        public List<recipe.Recipe> load()
        {
            read.refresh();
            read.read();
            return read.getRecipes();

        }
        /*
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
                var recipe = new Recipe();

               // recipe = new Recipe(, instructions, ingredients, intolerances);
                recipes.Add(recipe);
            }
            return recipes;
        }*/
    }
}