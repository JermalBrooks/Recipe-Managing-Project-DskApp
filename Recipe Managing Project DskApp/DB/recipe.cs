using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipe_Managing_Project_DskApp.DB
{
    public class recipe
    {
        public static string Instructions;

 
        public struct Name
        {
            public string name;
            public string complexity;
            public Name(string _Name, string _Complexity)
            {
                name = _Name;
                complexity = _Complexity;
            }

        }
        public struct Restrictions
        {
            public bool Dairy;
            public bool Gluten;
            public bool Shellfish;
            public bool TreeNuts;
            public bool Soy;
            public bool Eggs;
            public bool Peanuts;
            public bool Seafood;
            public bool RedMeat;

            public Restrictions(
                string dairy,
                string gluten,
                string shellfish,
                string treeNuts,
                string soy,
                string eggs,
                string peanuts,
                string seafood,
                string redMeat)
            {
                Dairy = Convert.ToBoolean(dairy);
                Gluten = Convert.ToBoolean(gluten);
                Shellfish = Convert.ToBoolean(shellfish);
                TreeNuts = Convert.ToBoolean(treeNuts);
                Soy = Convert.ToBoolean(soy);
                Eggs = Convert.ToBoolean(eggs);
                Peanuts = Convert.ToBoolean(peanuts);
                Seafood = Convert.ToBoolean(seafood);
                RedMeat = Convert.ToBoolean(redMeat);
            }
            public Dictionary<string, bool> toDict()
            {
                return new Dictionary<string, bool>{
            { nameof(Dairy), Dairy },
            { nameof(Gluten), Gluten },
            { nameof(Shellfish), Shellfish },
            { "Tree Nuts", TreeNuts },
            { nameof(Soy), Soy },
            { nameof(Eggs), Eggs },
            { nameof(Peanuts), Peanuts },
            { nameof(Seafood), Seafood },
            {  "Red Meat", RedMeat }
            };
            }
        }
        public struct Intolerances
        {
            public bool Lactose;
            public bool Gluten;
            public bool Caffeine;
            public bool Casein;
            public bool Fructose;
            public bool MSG;
            public bool Eggs;
            public bool Soy;
            public bool Nuts;
            public bool Shellfish;
            public bool Peanuts;
            public bool TreeNuts;

            public Intolerances(
               string lactose = "false",
               string gluten = "false",
               string caffeine = "false",
               string casein = "false",
               string fructose = "false",
               string msg = "false",
               string eggs = "false",
               string soy = "false",
               string nuts = "false",
               string shellfish = "false",
               string peanuts = "false",
               string treeNuts = "false")
            {
                Lactose = Convert.ToBoolean(lactose);
                Gluten = Convert.ToBoolean(gluten);
                Caffeine = Convert.ToBoolean(caffeine);
                Casein = Convert.ToBoolean(casein);
                Fructose = Convert.ToBoolean(fructose);
                MSG = Convert.ToBoolean(msg);
                Eggs = Convert.ToBoolean(eggs);
                Soy = Convert.ToBoolean(soy);
                Nuts = Convert.ToBoolean(nuts);
                Shellfish = Convert.ToBoolean(shellfish);
                Peanuts = Convert.ToBoolean(peanuts);
                TreeNuts = Convert.ToBoolean(treeNuts);

            }
         
         
            public Dictionary<string, bool> toDict()
            {
                return new Dictionary<string, bool>{
            { nameof(Lactose), Lactose },
            { nameof(Gluten), Gluten },
            { nameof(Caffeine), Caffeine },
            { nameof(Casein), Casein },
            { nameof(Fructose), Fructose },
            { nameof(MSG), MSG },
            { nameof(Eggs), Eggs },
            { nameof(Soy), Soy },
            { nameof(Nuts), Nuts },
            { nameof(Shellfish), Shellfish },
            { nameof(Peanuts), Peanuts },
            { nameof(TreeNuts), TreeNuts }
             };

        
            }

        }
        public struct Ingredient
        {
            public string name;
            public double amount;
            public string unit;
            public Ingredient(string _Name, string _Amount, string _Unit)
            {
                name = _Name;
                amount = Convert.ToDouble(_Amount);
                unit = _Unit;
            }
        }
        public struct Recipe
        {
            public Name Name;
            public Restrictions Restrictions;
            public Intolerances Intolerances;
            public List<Ingredient> Ingredients;
            public string Instructions;
            public Recipe(Name _Name, Restrictions _Restrictions, Intolerances _Intolerances, List<Ingredient> _Ingredients, string _Instructions)
            {
                Name = _Name;
                Restrictions = _Restrictions;
                Intolerances = _Intolerances;
                Ingredients = _Ingredients;
                Instructions = _Instructions;
            }
            public List<string> getNamedIngredients()
            {
                List<string> list = new List<string>();
                foreach (Ingredient i in Ingredients)
                {
                    list.Add(i.name);
                }
                return list;

            }

        }
    }
}
