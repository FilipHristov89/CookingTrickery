using CookingTrickery.Core.Models.Cuisine;

namespace CookingTrickery.Core.Contracts
{
    public interface ICuisineService
    {
        Task<CuisineViewModel> GetCuisineAsync(Guid id);
        Task<IEnumerable<CuisinePreviewViewModel>> GetAllCuisinesAsync();
        Task CreateCuisine(CreateCuisineViewModel model);
    }
}
