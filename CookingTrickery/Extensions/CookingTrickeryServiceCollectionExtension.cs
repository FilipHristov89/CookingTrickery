using CookingTrickery.Core.Contracts;
using CookingTrickery.Core.Services;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class CookingTrickeryServiceCollectionExtension
    {
        public static IServiceCollection AddAplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRecipeService, RecipeService>();

            return services;
        }
    }
}
