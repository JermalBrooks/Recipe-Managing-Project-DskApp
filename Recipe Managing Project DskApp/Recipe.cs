using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recipe_Managing_Project_DskApp.Data;
using Recipe_Managing_Project_DskApp.DB;
using Recipe_Managing_Project_DskApp;

namespace Recipe_Managing_Project_DskApp.Models 
{
    
}
public class Recipe
{
    public string Name { get; set; }
    public List<string> Ingredients { get; set; }
    public string Instructions { get; set; }
    public List<string> Intolerances { get; set; }
    public string IngredientList => string.Join(", ", Ingredients);
}
