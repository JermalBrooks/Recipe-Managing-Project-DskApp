using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Recipe_Managing_Project_DskApp;
using Recipe_Managing_Project_DskApp.Data;
using Recipe_Managing_Project_DskApp.Models;
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

            string connectionString = @"Data Source =. \SQLEXPRESS;Initial Catalog=RecipeDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                {
                    conn.Open();
                }

                string query = @"
                    SELECT r.Name, r.Instructions
                    FROM Recipes r
                    JOIN RecipeIngredients ri ON r.RecipeId = ri.RecipeId
                    JOIN Ingredients i ON ri.IngredientId = i.IngredientId
                    WHERE i.Name IN (@Ingredients)
                    AND r.RecipeId NOT IN (
                        SELECT ri.RecipeId
                        FROM Recipes ri
                        JOIN RecipeIngredients ri ON ri.RecipeId = ri.RecipeId
                        JOIN Ingredients i ON ri.IngredientId = i.IngredientId
                        WHERE i.Name IN (@RestrictedItems)
                    )
                    {2}
                    GROUP BY r.Name, r.Instructions
                    HAVING COUNT(DISTINCT i.Name) = @IngredientCount";

                {
                    conn.Open();
                }

                string selParams = string.Join(",", selectedIngredients.Select((s, i) => $"@sel{i}"));
                string resParams = string.Join(",", restrictedItems.Select((s, i) => $"@res{i}"));
                string dietFilter = selectedDiets.Count > 0 ? @"
                    AND r.DietType IN (" + string.Join(",", selectedDiets.Select((d, i) => $"@diet{i}")) + ")" : "";

                query = string.Format(query, selParams, resParams, dietFilter);

               

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
        }



        public class Recipe
        {
            public string Name { get; set; }
            public List<string> Ingredients { get; set; }
            public string Instructions { get; set; }

            public List<string> Intolerances { get; set; }

            public string IngredientList => string.Join(", ", Ingredients);
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
            

            public static class RecipeLoader
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
                

        }
    
            
    }
}

