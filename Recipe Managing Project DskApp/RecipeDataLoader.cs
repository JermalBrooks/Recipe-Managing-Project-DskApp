using Recipe_Managing_Project_DskApp;
using Recipe_Managing_Project_DskApp.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static Recipe_Managing_Project_DskApp.DB.recipe;


namespace Recipe_Managing_Project_DskApp.Data
{

    /// <summary>
    /// The RecipeDataLoader Class is mostly a utility class to make the code easier to read in more critial files
    /// </summary>
    public class RecipeDataLoader
    {
        //the default execution path is in debug 
        string path = System.Environment.CurrentDirectory.Replace("bin\\Debug", "\\DB\\dataFile.xml");

        // forced pass of variables that are used by all the files
        XmlDocument xmlDoc = new XmlDocument();
        fileRead read;
  
        public RecipeDataLoader()
        {
            read = new fileRead(xmlDoc, path);
         }

        public List<recipe.Recipe> load()
        {
            read.refresh();
            read.read();
            return read.getRecipes();

        }
        /// <summary>
        /// Coverts the Recipe list into a form list so it can be displayed by the form 
        /// </summary>
        /// <returns></returns>
        public List<ListViewItem> getListView()
        {
            List<Recipe> allRecipes = load();
            List<ListViewItem> listView = new List<ListViewItem>();
            foreach (recipe.Recipe item in allRecipes)
            {
                ListViewItem lvi = new ListViewItem(item.Name.name);
                listView.Add(lvi);
             }
            return listView;
        }
        /// <summary>
        /// After filtering data, the list need to be transfered into a Form readable format
        /// </summary>
        
        public List<ListViewItem> convertToListView(List<Recipe> allRecipes)
        {
            List<ListViewItem> listView = new List<ListViewItem>();
            foreach (Recipe item in allRecipes)
            {
                ListViewItem lvi = new ListViewItem(item.Name.name);
                listView.Add(lvi);
            }
            return listView;
        }
      

    }
}