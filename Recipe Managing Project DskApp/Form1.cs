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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Recipe_Managing_Project_DskApp
{
    /// <summary>
    /// Form 1 is the general Form. 
    /// The primary Function of this form is to search for recipes based on filters inputed by the user
    /// </summary>
    public partial class Form1 : Form
    {
        RecipeDataLoader dataLoader = new RecipeDataLoader();
        AddRecipe addRecipe = new AddRecipe();
        public Recipe selectedRecipe;
        InspectRecipe inpectRecipe;
        /// <summary>
        /// this insures the listing is up to date.
        /// </summary>
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

            var allRecipes = dataLoader.load();

            var restrictedIngredients = clbRestricted.CheckedItems.Cast<string>().ToList();


            List<Recipe> filteredRecipe = dataLoader.load();
            List<Recipe> filteredIntolerances = new List<Recipe>();
            List<Recipe> filteredRestrictions = new List<Recipe>();
            List<Recipe> filteredIngredients = new List<Recipe>();
            /// reverse interation in the search method to avoid the possibilty on out of bounds indexing
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
                recipeListing.Items.AddRange(dataLoader.convertToListView(filteredRecipe).ToArray());
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
        /// <summary>
        /// Handles the event that occurs when the selected item in the ingredients list changes.
        
        ///  Removes the currently selected ingredient from the list when a selection is unwanted
        /// </summary>
        private void lstIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIngredients.SelectedIndex != -1)
            {
                lstIngredients.Items.RemoveAt(lstIngredients.SelectedIndex);
                lstIngredients.Update();
            }
        }
        /// <summary>
        /// When a new recipe is selected from the list, this method identifies the selected recipe, and displays 
        /// its details in a dialog window.
         /// </summary>
        private void recipeListing_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (recipeListing.SelectedItems.Count > 0)
            {
                var data = dataLoader.load();
                foreach (Recipe recipe in data)
                {
                    if (recipe.Name.name == recipeListing.SelectedItems[0].Text)
                    {
                        selectedRecipe = recipe;
                    }
                }
                if (selectedRecipe.Name.name != null)
                {
                    inpectRecipe = new InspectRecipe(selectedRecipe);
                    inpectRecipe.ShowDialog();
                }
            }
        }
        /// <summary>
        /// This method prompts a new form for users in update the recipe directory
        /// </summary>
       
        private void btnAddNewRecipe_Click(object sender, EventArgs e)
        {
            addRecipe.ShowDialog();
            updateListing();
         }



 

    }
}

