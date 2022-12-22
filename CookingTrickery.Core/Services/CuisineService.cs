using CookingTrickery.Core.Contracts;
using CookingTrickery.Core.Exceptions;
using CookingTrickery.Core.Models.Cuisines;
using CookingTrickery.Core.Models.Recipe;
using CookingTrickery.Infrastructure.Data;
using CookingTrickery.Infrastructure.Data.Common.Repository;
using CookingTrickery.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace CookingTrickery.Core.Services
{
    public class CuisineService : ICuisineService
    {
        private readonly IRepository repo;
        private IGuard guard;

        public CuisineService(IRepository _repo, IGuard _guard)
        {
            repo = _repo;
            guard = _guard;
        }

        /// <summary>
        /// Create cuisine
        /// </summary>
        /// <param name="model">The View model for the Create form</param>
        /// <returns>Adds the cuisine to the database</returns>
        public async Task CreateCuisine(CreateCuisineViewModel model)
        {
            var cuisine = new Cuisine()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                ImageUrl = model.ImageUrl,
                Description = model.Description
            };

            await repo.AddAsync(cuisine);
            await repo.SaveChangesAsync();
        }

        /// <summary>
        /// Adds selected cuisine as user's favorite
        /// </summary>
        /// <param name="userId">Logged user Id</param>
        /// <param name="cuisineId">Chosen cuisine id</param>
        /// <returns>Save the changes in User's FavoriteCuisine row</returns>
        public async Task AddFavoriteCuisineAsync(string userId, Guid cuisineId)
        {
            var user = await repo.GetByIdAsync<User>(userId);

            guard.AgainstNull(user, "User cannot be null");

            var cuisine = await repo.GetByIdAsync<Cuisine>(cuisineId);

            guard.AgainstNull(cuisine, "Cuisine cannot be null");

            user.FavoriteCuisine = cuisine;

            await repo.SaveChangesAsync();
        }

        /// <summary>
        /// Get all cuisines from database
        /// </summary>
        /// <returns>List of all cuisines</returns>
        public async Task<IEnumerable<CuisinePreviewViewModel>> GetAllCuisinesAsync()
        {
            var cuisines = await repo.AllReadonly<Cuisine>()
                .Select(c => new CuisinePreviewViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    ImageUrl = c.ImageUrl,
                })
                .ToListAsync();

            return cuisines;
        }

        /// <summary>
        /// Get a cuisine by id
        /// </summary>
        /// <param name="id">Chosen cuisine id</param>
        /// <returns>Selected Cuisine</returns>
        public async Task<CuisineViewModel> GetCuisineAsync(Guid id)
        {
            var cuisine = await repo.AllReadonly<Cuisine>()
                .Where(c => c.Id == id)
                .Select(c => new CuisineViewModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    ImageUrl = c.ImageUrl,
                    Description = c.Description,
                })
                .FirstAsync();

            return cuisine;
        }
    }
}
