using Recipe_Managing_Project_DskApp;
using Recipe_Managing_Project_DskApp.DB;
//using Recipe_Managing_Project_DskApp.Models;
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


    public class RecipeDataLoader
    {
        //the default execution path is in debug 
        string path = System.Environment.CurrentDirectory.Replace("bin\\Debug", "\\DB\\dataFile.xml");

        // forced pass of variables that are used by all the files
        XmlDocument xmlDoc = new XmlDocument();
        fileRead read;
        fileWrite write;
        List<Recipe> recipeList;

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