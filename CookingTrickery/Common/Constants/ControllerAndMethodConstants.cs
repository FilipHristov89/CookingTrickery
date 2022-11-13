using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CookingTrickery.Common.Constants
{
    public static class ControllerAndMethodConstants
    {
        public static class ControllerConstants
        {
            public const string UserControllerValue = "User";
            public const string RecipeControllerValue = "Recipe";
            public const string IngredientControllerValue = "Ingredient";
        }

        public static class UserControllerMethodConstants 
        {
            public const string RegisterMethod = "Register";
            public const string LoginMethod = "Login";
        }

        public static class RecipeControllerMethodConstants
        {
            public const string RecipeAllMethod = "All";
            public const string RecipeRecipeMethod = "Recipe";
        }

        public const string IngredientMethod = "Ingredient";
    }
}
