namespace CookingTrickery.Infrastructure.Data.Common
{
    public static class Constants
    {
        public static class RecipeConstants
        {
            public const int RecipeNameMaxLength = 70;
            public const int RecipeNameMinLength = 3;

            public const int RecipeQuickDescriptionMaxLength = 300;
            public const int RecipeQuickDescriptionMinLenght = 4;

            public const int RecipeDescriptionMaxLength = 4000;
            public const int RecipeDescriptionMinLength = 10;

            public const int RecipePrepTimeMaxLength = 30;
        }

        public static class IngredientConstants
        {
            public const int IngredientNameMaxLength = 50;
            public const int IngredientNameMinLength = 3;

            public const int IngredientDescriptionMaxLength = 1000;
            public const int IngredientDescriptionMinLength = 20;

            public const int IngredientOriginMaxLength = 20;
            public const int IngredientOriginMinLength = 4;
        }

        public static class CuisineConstants
        {
            public const int CuisineNameMaxLength = 60;

            public const int CuisineDescriptionMaxLength = 800;
        }

        public static class MeasurementConstants
        {
            public const int MeasurementTypeMaxLength = 10;
        }

        public static class UserConstants
        {
            public const int UserUserNameMaxLength = 20;
            public const int UserUserNameMinLength = 3;

            public const int UserEmailMaxLength = 254;
            public const int UserEmailMinLength = 12;

            public const int UserFirstNameMaxLength = 20;
            public const int UserFirstNameMinLength = 2;

            public const int UserLastNameMaxLength = 50;
            public const int UserLastNameMinLength = 2;

            public const int UserPasswordMaxLength = 32;
            public const int UserPasswordMinLength = 6;
            
        }
    }
}
