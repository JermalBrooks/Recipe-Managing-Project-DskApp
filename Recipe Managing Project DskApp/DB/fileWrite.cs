using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static Recipe_Managing_Project_DskApp.DB.recipe;

namespace Recipe_Managing_Project_DskApp.DB
{
    internal class fileWrite
    {
      
         
        XmlDocument xmlDoc;
        string path; 
        
        public fileWrite(XmlDocument doc,string path) {
            xmlDoc = doc;
            this.path = path;

        }
        public void changePath(string path)
        {
            this.path = path;
        }
        public void write(Recipe recipe)
        {
           
            xmlDoc.Load(path);
            var input = xmlDoc.ChildNodes[1].CreateNavigator();
            
            var XML =  input.AppendChild();
       
            XML.WriteStartElement("recipe");
            XML.WriteStartElement("name");
            XML.WriteAttributeString("complexity", recipe.Name.complexity);
            XML.WriteName(recipe.Name.name.Replace(" ","-"));
            XML.WriteFullEndElement();

            XML.WriteStartElement("restrictions");
            XML.WriteAttributeString("dairy", recipe.Restrictions.Dairy.ToString());
            XML.WriteAttributeString("gluten", recipe.Restrictions.Gluten.ToString());
            XML.WriteAttributeString("shell-fish", recipe.Restrictions.Shellfish.ToString());
            XML.WriteAttributeString("tree-nuts", recipe.Restrictions.TreeNuts.ToString());
            XML.WriteAttributeString("soy", recipe.Restrictions.Soy.ToString());
            XML.WriteAttributeString("eggs", recipe.Restrictions.Eggs.ToString());
            XML.WriteAttributeString("peanuts", recipe.Restrictions.Peanuts.ToString());
            XML.WriteAttributeString("seafood", recipe.Restrictions.Seafood.ToString());
            XML.WriteAttributeString("red-meat", recipe.Restrictions.RedMeat.ToString());
            XML.WriteEndElement();

            XML.WriteStartElement("intolerances");
            XML.WriteAttributeString("lactose", recipe.Intolerances.Lactose.ToString());
            XML.WriteAttributeString("gluten", recipe.Intolerances.Gluten.ToString());
            XML.WriteAttributeString("caffeine", recipe.Intolerances.Caffeine.ToString());
            XML.WriteAttributeString("casein", recipe.Intolerances.Casein.ToString());
            XML.WriteAttributeString("fructose", recipe.Intolerances.Fructose.ToString());
            XML.WriteAttributeString("msg", recipe.Intolerances.MSG.ToString());
            XML.WriteAttributeString("eggs", recipe.Intolerances.Eggs.ToString());
            XML.WriteAttributeString("soy", recipe.Intolerances.Soy.ToString());
            XML.WriteAttributeString("nuts", recipe.Intolerances.Nuts.ToString());
            XML.WriteAttributeString("shellfish", recipe.Intolerances.Shellfish.ToString());
            XML.WriteAttributeString("peanuts", recipe.Intolerances.Peanuts.ToString());
            XML.WriteAttributeString("tree-nuts", recipe.Intolerances.TreeNuts.ToString());
            XML.WriteEndElement();

            for (int i = 0; i < recipe.Ingredients.Count; i++) {
                XML.WriteStartElement("ingredient");
                XML.WriteAttributeString("name", recipe.Ingredients[i].name);
                XML.WriteAttributeString("amount", recipe.Ingredients[i].amount.ToString());
                XML.WriteAttributeString("unit", recipe.Ingredients[i].unit);
                XML.WriteEndElement();

            }
            XML.WriteStartElement("instructions");
            XML.WriteName(recipe.Instructions);
            XML.WriteEndElement();

            XML.Close();
            xmlDoc.Save(path);

        }
        public void removeRecipe(string recipeName)
        {
            xmlDoc.Load(path);
            var doc = xmlDoc.DocumentElement;
            var root = doc.ChildNodes;
            List<XmlNode> rml = new List<XmlNode>();
            for (int i =0 ; i < root.Count; i+=1)
            {
                XmlNode node = root[i] .ChildNodes[0];

                if (node.InnerText == recipeName.Replace(" ", "-") || node.InnerText == recipeName.Replace("-", " ")) 
                {
                    rml.Add(node.ParentNode);
     
                } 
            }
            for (int i = 0; i < rml.Count; i += 1)
            {
                doc.RemoveChild(rml[i]);
            }                
            xmlDoc.Save(path);

        }
       
    }
}
