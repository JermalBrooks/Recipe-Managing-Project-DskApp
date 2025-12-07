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
using Recipe_Managing_Project_DskApp.DB;
using static Recipe_Managing_Project_DskApp.DB.recipe;


namespace Recipe_Managing_Project_DskApp
{
    public partial class recipeloader : Form
    {
        public List<string> selectedIngredients { get; set; }
        public List<string> Instructions { get; set; }
        public List<string> SelectedIntolerances { get; set; }
        public List<string> RestrictedItems { get; set; }
        public RecipeDataLoader dataLoader { get; set; }

        public recipeloader()
        {
            InitializeComponent();
            dataLoader = new RecipeDataLoader();
        }
        
        private void recipeloader_Load(object sender, EventArgs e)
        {
           string xmlpath = Path.Combine(Application.StartupPath, "DB", "dataFile.xml");
            var allrecipes = dataLoader.load();
            /*
             * var filteredRecipes = allrecipes.Where(r =>
                (selectedIngredients.All(i => r.Ingredients.Contains(i))) &&
                !r.Ingredients.Any(i => SelectedIntolerances.Contains(i)) &&
                (SelectedIntolerances.Count == 0 || !r.Intolerances.(i => SelectedIntolerances.Contains(i)))
                ).ToList();
            */
            allrecipes.Sort();
            dvgResults.DataSource = allrecipes;

            if (allrecipes.Any())
            {
                Recipe recipe = allrecipes.First();

                lstIngredients.Items.Clear();
                foreach (var ing in recipe.Ingredients)
                {
                    lstIngredients.Items.Add(ing);
                }
                //   txtInstructions.Text = recipe.Instructions;


                lstIngredients.Items.Clear();
                foreach (var ing in recipe.Ingredients)

                {
                    lstIngredients.Items.Add(ing);
                }

                txtInstructions.Text = recipe.Instructions;
            }
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
            if (dvgResults.CurrentRow != null)
            {
                var recipe = (Recipe)dvgResults.CurrentRow.DataBoundItem;

                string message = $"Name: {recipe.Name}\n\n" + $"Ingerdients:\n{string.Join("\n", recipe.Ingredients)}\n\n" + $"Instructions:\n{{recipe.Instructions}}\n\n" + $"Intolerences:\n{string.Join(", ", recipe.Intolerances)}";
                MessageBox.Show(message, "Recipe Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a recipe first.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
       

      
    }
    /*
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
    }*/
}
