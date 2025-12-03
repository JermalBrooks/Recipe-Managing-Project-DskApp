using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Managing_Project_DskApp.DB
{
    internal class recipe
    {
        internal static readonly string Instructions;

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
                string lactose,
                string gluten,
                string caffeine,
                string casein,
                string fructose,
                string msg,
                string eggs,
                string soy,
                string nuts,
                string shellfish,
                string peanuts,
                string treeNuts)
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

        }
        public struct Ingredient
        {
            public string name;
            public int amount;
            public string unit;
            public Ingredient(string _Name, string _Amount, string _Unit)
            {
                name = _Name;
                amount = Convert.ToInt32(_Amount);
                unit = _Unit;
            }
        }
        public struct Recipe
        {
            public Name Name;
            public Restrictions Restrictions;
            public Intolerances Intolerances;
            public List<Ingredient> Ingredients;
            public Recipe(Name _Name, Restrictions _Restrictions,Intolerances _Intolerances, List<Ingredient> _Ingredients)
            {
                Name = _Name;
                Restrictions = _Restrictions;
                Intolerances = _Intolerances;
                Ingredients = _Ingredients;
            }

        }
    }
}
