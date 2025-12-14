using Recipe_Managing_Project_DskApp.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static Recipe_Managing_Project_DskApp.DB.recipe;

namespace Recipe_Managing_Project_DskApp
{
    /// <summary>
    /// The purpose of this form is to import new recipes into the directory 
    /// </summary>
    public partial class AddRecipe : Form
    {
        public string nName;
        public string nComplexity;
        XmlDocument xmlDoc = new XmlDocument();
        fileWrite write;
        string path = System.Environment.CurrentDirectory.Replace("bin\\Debug", "\\DB\\dataFile.xml");

        public AddRecipe()
        {
            InitializeComponent();
            write = new fileWrite(xmlDoc, path);
        }
        /// <summary>
        /// Receives the boolean values from the the check list, index
        /// is in order so data will not be out of order
        /// </summary>
         
        private Restrictions makeRestriction()
        {
            string dairy = clbRestricted.GetItemChecked(0).ToString();
            string gluten = clbRestricted.GetItemChecked(1).ToString();
            string shellfish = clbRestricted.GetItemChecked(2).ToString();
            string treeNut = clbRestricted.GetItemChecked(3).ToString();
            string soy = clbRestricted.GetItemChecked(4).ToString();
            string eggs = clbRestricted.GetItemChecked(5).ToString();
            string peanuts = clbRestricted.GetItemChecked(6).ToString();
            string seafood = clbRestricted.GetItemChecked(7).ToString();
            string redMeat = clbRestricted.GetItemChecked(8).ToString();

            return new Restrictions(dairy, gluten, shellfish, treeNut, soy, eggs, peanuts, seafood, redMeat);
        }
        /// <summary>
        /// Receives the boolean values from the the check list, index
        /// is in order so data will not be out of order
        /// </summary>
        private Intolerances makeIntolerance()
        {
            string lactose = clbIntolerances.GetItemChecked(0).ToString();

            string gluten = clbIntolerances.GetItemChecked(1).ToString();
            string caffeine = clbIntolerances.GetItemChecked(2).ToString();
            string casein = clbIntolerances.GetItemChecked(3).ToString();
            string fructose = clbIntolerances.GetItemChecked(4).ToString();
            string msg = clbIntolerances.GetItemChecked(5).ToString();
            string eggs = clbIntolerances.GetItemChecked(6).ToString();
            string soy = clbIntolerances.GetItemChecked(7).ToString();
            string nuts = clbIntolerances.GetItemChecked(8).ToString();
            string shellfish = clbIntolerances.GetItemChecked(9).ToString();
            string peanuts = clbIntolerances.GetItemChecked(10).ToString();
            string treeNuts = clbIntolerances.GetItemChecked(11).ToString();
            return new Intolerances(lactose, gluten, caffeine, casein, fructose, msg, eggs, soy, nuts, shellfish, peanuts, treeNuts);
        }
        /// <summary>
        /// Formats the intructions so they can be written in the xml data base
        /// </summary>
         private string makeIntructions()
        {
            string instructions = rtbInstructions.Text;
            instructions.Trim();
            instructions = instructions.Replace(' ', '-');
            instructions = instructions.Replace('.', ' ');
            instructions = instructions.Replace(',', ' ');
            instructions = instructions.Replace(':', ' ');
            instructions = instructions.Replace(';', ' ');



            return instructions;
        }
        /// <summary>
        /// Parses data from a known format and splits them into 
        /// respective data categories 
        /// </summary>
        /// <returns></returns>
        private List<Ingredient> makeIngredients()
        {

            List<Ingredient> ingredientList = new List<Ingredient>();

            string raw = rtbIngredients.Text;

            var buffer = raw.Split(';');
            foreach (string str in buffer)
            {
                var x = str.Split(',');
                if (str.Length != 0)
                {
                    ingredientList.Add(new Ingredient(x[0], x[1], x[2]));
                }

            }
            return ingredientList;
        }
        /// <summary>
        /// First checks for valid inputs
        /// then puts all the pieces of the recipe together 
        /// </summary>
      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            nName = tbName.Text;
            if (nName.Length == 0)
            {
                MessageBox.Show("Recipe name is empty!");
                return;
            }
            else if (nName.Contains(" "))
            {
                nName.Trim();
                nName.Replace(" ", "-");
            }
            List<Ingredient> ingredients = makeIngredients();
            if (ingredients.Count == 0)
            {
                MessageBox.Show("Invalid Ingredient");
                return;
            }

            write.write(new Recipe(new Name(nName, nComplexity), makeRestriction(), makeIntolerance(), ingredients, makeIntructions()));
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

       
      
        private void rdbEasy_CheckedChanged(object sender, EventArgs e)
        {
            nComplexity = (rdbEasy.Checked) ? "Easy" : "";

        }

        private void rdbMedium_CheckedChanged(object sender, EventArgs e)
        {
            nComplexity = (rdbMedium.Checked) ? "Medium" : "";

        }

        private void rdbHard_CheckedChanged(object sender, EventArgs e)
        {
            nComplexity = (rdbHard.Checked) ? "Hard" : "";
        }
    }
}
