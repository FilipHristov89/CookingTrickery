﻿using CookingTrickery.Core.Models.Cuisines;

namespace CookingTrickery.Core.Contracts
{
    public interface ICuisineService
    {
        Task<CuisineViewModel> GetCuisineAsync(Guid id);
        Task<IEnumerable<CuisinePreviewViewModel>> GetAllCuisinesAsync();
        Task CreateCuisine(CreateCuisineViewModel model);
    }
}
