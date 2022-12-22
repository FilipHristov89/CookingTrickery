using CookingTrickery.Core.Contracts;
using CookingTrickery.Core.Contracts.Administration;
using CookingTrickery.Core.Exceptions;
using CookingTrickery.Core.Services;
using CookingTrickery.Core.Services.Admin;
using CookingTrickery.Infrastructure.Data.Common.Repository;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class CookingTrickeryServiceCollectionExtension
    {
        // Adds Dependency Injections for the App

        public static IServiceCollection AddAplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IRecipeService, RecipeService>();
            services.AddScoped<IIngredientService, IngredientService>();
            services.AddScoped<ICuisineService, CuisineService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IGuard, Guard>();

            return services;
        }
    }
}
