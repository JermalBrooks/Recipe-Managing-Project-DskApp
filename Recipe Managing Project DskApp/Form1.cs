using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Recipe_Managing_Project_DskApp;
using Recipe_Managing_Project_DskApp.DB;

using static Recipe_Managing_Project_DskApp.DB.recipe;

namespace Recipe_Managing_Project_DskApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            var selectedIngredients = lstIngredients.Items.Cast<string>().ToList();
            var restrictedItems = clbRestricted.CheckedItems.Cast<string>().ToList();
            var selectedDiets = cblIntolerances.CheckedItems.Cast<string>().ToList();

            if (selectedIngredients.Count == 0)
            {
                MessageBox.Show("Please enter at least one ingredient.");
                return;
            }
            recipeloader recipeForm = new recipeloader
            {
                selectedIngredients = selectedIngredients,
                Instructions = restrictedItems,
                SelectedIntolerances = selectedDiets,
                RestrictedItems = restrictedItems
            };
            recipeForm.Show();



            string xmlPath = Path.Combine(Application.StartupPath, "DB", "dataFile.xml");
            var recipes = RecipeLoader.LoadRecipes(xmlPath);
            dvgResults.DataSource = recipes;

            var allRecipes = RecipeLoader.LoadRecipes(xmlPath);

            var restrictedIngredients = clbRestricted.CheckedItems.Cast<string>().ToList();
            var selectedIntolerances = cblIntolerances.CheckedItems.Cast<string>().ToList();

            var filteredRecipes = allRecipes.Where(r =>
                 selectedIngredients.All(i => r.Ingredients.Contains(i)) &&
                 !r.Ingredients.Any(i => restrictedIngredients.Contains(i)) &&
                 (selectedIntolerances.Count == 0 || !r.Intolerances.Any(i => selectedIntolerances.Contains(i)))
                 ).ToList();
        }
    



    
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Addingredient_Click(object sender, EventArgs e)
        {
            string ingredient = txtIngredient.Text.Trim();
            if (!string.IsNullOrEmpty(ingredient))
            {
                if (!lstIngredients.Items.Contains(ingredient))
                {
                    lstIngredients.Items.Add(ingredient);
                    txtIngredient.Clear();
                }
                else
                {
                    MessageBox.Show("Ingredient already added.");
                }
            }
            else
            {
                MessageBox.Show("Please enter an ingredient.");
            }
        }
            

                /*      public static class RecipeLoader
        {
  public static List<Recipe> LoadRecipes(string path)
            {
                var doc = XDocument.Load(path);
                var recipes = doc.Descendants("Recipe")
                    .Select(r => new Recipe
                    {
                        Name = r.Element("Name")?.Value,
                        Ingredients = r.Element("Ingredients")?
                            .Elements("Ingredient")
                            .Select(i => i.Value).ToList(),
                            Instructions = r.Element("Instructions")?.Value,
                            Intolerances = r.Element("Intolerances")?
                            .Elements("Intolerance")
                            .Select(i => i.Value).ToList()
                    }).ToList();
                return recipes;

            
            }
                

        }*/
    
            
    }
}

