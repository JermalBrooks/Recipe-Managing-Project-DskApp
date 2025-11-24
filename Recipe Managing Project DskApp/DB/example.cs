using System.Collections.Generic;
using System.Numerics;
using System.Xml;
using static Recipe_Managing_Project_DskApp.DB.recipe;
using Recipe_Managing_Project_DskApp.DB;

// See https://aka.ms/new-console-template for more information



public class example
{
    //if you run this, the only way you can tell if its working is from the xml file.
    public void runExample()
    {

        //the default execution path is in debug 
        string path = System.Environment.CurrentDirectory.Replace("bin\\Debug", "\\DB\\dataFile.xml");
    
        // forced pass of variables that are used by all the files
        XmlDocument xmlDoc = new XmlDocument();
        fileRead read = new fileRead(xmlDoc, path);
        fileWrite write = new fileWrite(xmlDoc,path);

        read.read();
        List<recipe.Recipe> recipes = read.getRecipes();
        recipe.Name n = new  recipe.Name("Peanut Butter and Jelly", "easy");
        recipe.Restrictions r = new Restrictions("False","True","False", "False", "True", "False", "True", "False", "False");
        recipe.Intolerances it = new Intolerances("False", "True", "False", "False", "False", "False", "False", "False", "True", "False", "True", "True");
        recipe.Ingredient p = new Ingredient("Peanut Butter","1","spread");
        recipe.Ingredient j = new Ingredient("Jelly", "1", "spread");
        recipe.Ingredient b = new Ingredient("Bread", "2", "slices");

        List< recipe.Ingredient> il = new List<recipe.Ingredient>();
        il.Add(p);
        il.Add(j);
        il.Add(b);  
        recipe.Recipe rep = new recipe.Recipe(n,r,it,il);
        
        write.write(rep);
        write.removeRecipe("Peanut-Butter-and-Jelly");


    }
}