using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Recipe_Managing_Project_DskApp.DB.recipe;
using  Recipe_Managing_Project_DskApp.DB;


namespace Recipe_Managing_Project_DskApp
{
    /// <summary>
    ///  displays detailed information about a specified recipe, including its name, complexity,
    /// ingredients, dietary restrictions, intolerances, and instructions.
    /// </summary>
    public partial class InspectRecipe : Form
    {
        public Recipe Recip;
        public InspectRecipe(Recipe imported)
        {
            InitializeComponent();
            Recip = imported;
            ShowData();
        }
        /// <summary>
        /// This method displays all the data from the recipe into the forms data types 
        /// </summary>
        private void ShowData()
        {
            recipeName.Text = Recip.Name.name;
            nComplexity.Text = Recip.Name.complexity;
            foreach (Ingredient ingredient in Recip.Ingredients)
            {
                var item  = new ListViewItem();
                item.Text = $"{ingredient.name}, {ingredient.amount} {ingredient.unit}";
                lstIngredients.Items.Add(item);
            }
            var restrict = Recip.Restrictions.toDict();
            for (int i = 0; i < restrict.Count; i++)
            {
                var item = new ListViewItem();
                if (restrict.ElementAt(i).Value)
                {
                    item.Text = restrict.ElementAt(i).Key;
                    lstRestrictions.Items.Add(item);
                }
            }
                var intolerance = Recip.Intolerances.toDict();
                for (int i = 0; i < intolerance.Count; i++)
                {
                    var item = new ListViewItem();
                    if (intolerance.ElementAt(i).Value)
                    {
                        item.Text = intolerance.ElementAt(i).Key;
                        lstIntolerances.Items.Add(item);
                    }

                }
                rtbInstructions.Text = Recip.Instructions.Replace('-',' ');

            }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
