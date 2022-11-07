﻿namespace CookingTrickery.Infrastructure.Data.Common
{
    public static class Constants
    {
        public static class RecipeConstants
        {
            public const int RecipeNameMaxLenght = 70;

            public const int RecipeQuickDecriptionMaxLenght = 300;

            public const int RecipeDescriptionMaxLenght = 4000;

            public const int RecipePrepTimeMaxLength = 30;
        }

        public static class IngredientConstants
        {
            public const int IngredientNameMaxLenght = 50;

            public const int IngredientTypeMaxLenght = 30;

            public const int IngredientDescriptionMaxLenght = 1000;

            public const int IngredientOriginMaxLenght = 20;
        }

        public static class CuisineConstants
        {
            public const int CuisineNameMaxLenght = 60;

            public const int CuisineDescriptionMaxLenght = 800;
        }

        public static class MeasurementConstants
        {
            public const int MeasurementTypeMaxLenght = 10;
        }

        public static class UserConstants
        {
            public const int UserUserNameMaxLength = 50;

            public const int UserEmailMaxLenght = 254;
            public const int UserEmailMinLenght = 12;

            public const int UserFirstNameMaxLenght = 20;
            public const int UserLastNameMaxLenght = 50;

            public const int UserPasswordMaxLenght = 32;
            public const int UserPasswordMinLenght = 6;
            
        }
    }
}