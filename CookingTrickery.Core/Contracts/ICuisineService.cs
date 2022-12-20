using CookingTrickery.Core.Models.Cuisines;
using CookingTrickery.Core.Models.Recipe;

namespace CookingTrickery.Core.Contracts
{
    public interface ICuisineService
    {
        Task<CuisineViewModel> GetCuisineAsync(Guid id);

        Task<IEnumerable<CuisinePreviewViewModel>> GetAllCuisinesAsync();

        Task CreateCuisine(CreateCuisineViewModel model);

        Task AddFavoriteCuisineAsync(string userId, Guid cuisineId);
    }
}
