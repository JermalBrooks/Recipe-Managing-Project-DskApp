using Recipe_Managing_Project_DskApp;
using Recipe_Managing_Project_DskApp.Data;
using Recipe_Managing_Project_DskApp.DB;
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
using static Recipe_Managing_Project_DskApp.DB.recipe;

namespace Recipe_Managing_Project_DskApp
{
    public partial class Form1 : Form
    {
        RecipeDataLoader dataLoader = new RecipeDataLoader();
        public void updateListing()
        {
            recipeListing.Items.Clear();
            recipeListing.Items.AddRange(dataLoader.getListView().ToArray());

        }
        public Form1()
        {
            InitializeComponent();
            updateListing();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var allRecipes = dataLoader.load();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            updateListing();



            var selectedIngredients = lstIngredients.Items.Cast<string>().ToList();
            var selectedRestrictions = clbRestricted.CheckedItems.Cast<string>().ToList();
            var selectedIntolerances = cblIntolerances.CheckedItems.Cast<string>().ToList();

            //  if (selectedIngredients.Count == 0)
            //   {
            //     MessageBox.Show("Please enter at least one ingredient.");
            //      return;
            //  }
            recipeloader recipeForm = new recipeloader
            {
                selectedIngredients = selectedIngredients,
                Instructions = selectedRestrictions,
                SelectedIntolerances = selectedIntolerances,
                RestrictedItems = selectedRestrictions
            };



            var allRecipes = dataLoader.load();

            var restrictedIngredients = clbRestricted.CheckedItems.Cast<string>().ToList();


            List<Recipe> filteredRecipe = dataLoader.load();
            List<Recipe> filteredIntolerances = new List<Recipe>();
            List<Recipe> filteredRestrictions = new List<Recipe>();
            List<Recipe> filteredIngredients = new List<Recipe>();
            int v = 0;
            int t = 0;
            int a = allRecipes.Count;
            for (int m = allRecipes.Count - 1; m >= 0; m--)
            {
                if (m == allRecipes.Count - 1)
                {
                    Recipe recipe = filteredRecipe[m];
                    var intolerances = recipe.Intolerances.toDict();

                    if (selectedIntolerances.Any())
                    {
                        for (int i = intolerances.Count - 1; i >= 0; i--)
                        {
                            if (intolerances[selectedIntolerances[i]] == true)
                            {


                                filteredRecipe.RemoveAll(filtered => filteredRecipe.Contains(recipe));

                            }

                        }
                    }
                    if (selectedRestrictions.Any())
                    {
                        var restrictions = recipe.Restrictions.toDict();

                        for (int i = selectedRestrictions.Count - 1; i >= 0; i--)
                        {
                            if (restrictions[selectedRestrictions[i]] == true)
                            {


                                filteredRecipe.RemoveAll(filtered => filteredRecipe.Contains(recipe));

                            }

                        }
                    }
                    if (selectedIngredients.Any())
                    {
                        var ingredients = recipe.getNamedIngredients();

                        for (int i = selectedIngredients.Count - 1; i >= 0; i--)
                        {
                            if (ingredients.Contains(selectedIngredients[i]))
                            {


                                filteredRecipe.RemoveAll(filtered => filteredRecipe.Contains(recipe));

                            }

                        }
                    }

                }

                recipeListing.Items.Clear();
                t.ToString();
                // v.ToString();
                recipeListing.Items.AddRange(dataLoader.convertToListView(filteredRecipe).ToArray());
                /*var filteredRecipes =  allRecipes.Where(r =>
                     selectedIngredients.All(i => r.Ingredients.Contains(i)) &&
                     !r.Ingredients.Any(i => restrictedIngredients.Contains(i)) &&
                     (selectedIntolerances.Count == 0 || !r.Intolerances.Any(i => selectedIntolerances.Contains(i)))
                     ).ToList();*/

            }
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

        private void lstIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIngredients.SelectedIndex != -1)
            {
                lstIngredients.Items.RemoveAt(lstIngredients.SelectedIndex);
                lstIngredients.Update();
            }
        }

        private void recipeListing_SelectedIndexChanged(object sender, EventArgs e)
        {

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

