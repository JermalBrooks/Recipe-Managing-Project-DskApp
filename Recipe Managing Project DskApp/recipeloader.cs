using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml.Linq;
using System.IO;
using System.Security.AccessControl;
using Recipe_Managing_Project_DskApp;
using Recipe_Managing_Project_DskApp.Data;
using Recipe_Managing_Project_DskApp.Models;
using Recipe_Managing_Project_DskApp.DB;

namespace Recipe_Managing_Project_DskApp
{
    public partial class recipeloader : Form
    {
        public List<string> selectedIngredients { get; set; }
        public List<string> Instructions { get; set; }
        public List<string> SelectedIntolerances { get; set; }
        public List<string> RestrictedItems { get; set; }

        public recipeloader()
        {
            InitializeComponent();
        }
        
        private void recipeloader_Load(object sender, EventArgs e)
        {
           string xmlpath = Path.Combine(Application.StartupPath, "DB", "dataFile.xml");
            var allrecipes = RecipeDataloader.LoadRecipes(xmlpath);

            var filteredRecipes = allrecipes.Where(r =>
                (selectedIngredients.All(i => r.Ingredients.Contains(i))) &&
                !r.Ingredients.Any(i => SelectedIntolerances.Contains(i)) &&
                (SelectedIntolerances.Count == 0 || !r.Intolerances.Any(i => SelectedIntolerances.Contains(i)))
                ).ToList();

            dvgResults.DataSource = filteredRecipes;

            lstIngredients.Items.Clear();
            foreach (var ing in recipe.Ingredients)

            {
                lstIngredients.Items.Add(ing);
            }

            txtInstructions.Text = recipe.Instructions;
        }
        private void dvgResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               var recipe =(Recipe)dvgResults.Rows[e.RowIndex].DataBoundItem;

                lstIngredients.Items.Clear();
                foreach (var ing in recipe.Ingredients)
                {
                    lstIngredients.Items.Add(ing);
                }
                   

                txtInstructions.Text = recipe.Instructions;

            }
        }
        private void btnViewDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
       

      
    }

    public static class RecipeDataloader
    {
        public static List<Recipe> LoadRecipes(string xmlPath)
        {
            throw new NotImplementedException();
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
}
