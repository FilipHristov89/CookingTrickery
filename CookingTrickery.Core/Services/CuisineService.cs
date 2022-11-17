using CookingTrickery.Core.Contracts;
using CookingTrickery.Core.Models.Cuisine;
using CookingTrickery.Infrastructure.Data;
using CookingTrickery.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CookingTrickery.Core.Services
{
    public class CuisineService : ICuisineService
    {
        private readonly CookingTrickeryDbContext context;

        public CuisineService(CookingTrickeryDbContext _context)
        {
            context = _context;
        }

        public async Task CreateCuisine(CreateCuisineViewModel model)
        {
            var cuisine = new Cuisine()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                ImageUrl = model.ImageUrl,
                Description = model.Description
            };

            await context.Cuisines.AddAsync(cuisine);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<CuisinePreviewViewModel>> GetAllCuisinesAsync()
        {
            var cuisines = await context
                .Cuisines
                .Select(c => new CuisinePreviewViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    ImageUrl = c.ImageUrl,
                })
                .ToListAsync();

            return cuisines;
        }

        public async Task<CuisineViewModel> GetCuisineAsync(Guid id)
        {
            var cuisine = await context
                .Cuisines
                .Where(c => c.Id == id)
                .Select(c => new CuisineViewModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    ImageUrl = c.ImageUrl,
                    Description = c.Description
                })
                .FirstAsync();

            return cuisine;
        }
    }
}
