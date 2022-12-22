using CookingTrickery.Core.Contracts.Administration;
using CookingTrickery.Core.Models.Admin;
using CookingTrickery.Infrastructure.Data.Common.Repository;
using CookingTrickery.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using static CookingTrickery.Core.Constants.CoreConstants.ForgotenUsersConstants;

namespace CookingTrickery.Core.Services.Admin
{
    public class UserService : IUserService
    {
        private readonly IRepository repo;
        private readonly UserManager<User> userManager;

        public UserService(
            IRepository _repo,
            UserManager<User> _userManager
            )
        {
            repo = _repo;
            userManager = _userManager;
        }

        /// <summary>
        /// Gets all users for Admin UserController
        /// </summary>
        /// <returns>List of User</returns>
        public async Task<IEnumerable<UserServiceModel>> All()
        {
            return await repo.AllReadonly<User>()
                .Select(u => new UserServiceModel()
                {
                    UserId = u.Id,
                    UserName = u.UserName,
                    Email = u.Email,
                    FullName = $"{u.FirstName} {u.LastName}"
                })
                .ToListAsync();
        }


        /// <summary>
        /// Changes data for user if user wants to be forgoten 
        /// </summary>
        /// <param name="userId">User id</param>
        /// <returns>Update the values in the database</returns>
        public async Task<bool> Forget(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);

            user.PhoneNumber = null;
            user.FirstName = ForgotenValueConst;
            user.Email = ForgotenEmailConst;
            user.NormalizedEmail = ForgotenEmailConst.ToUpper();
            user.LastName = ForgotenValueConst;
            user.NormalizedUserName = ForgotenValueConst.ToUpper();
            user.PasswordHash = null;
            user.UserName = $"{ForgotenUserNameConst}{DateTime.Now.Ticks}";
            user.FavoriteCuisine = null;

            var result = await userManager.UpdateAsync(user);

            return result.Succeeded;
        }
        /// <summary>
        /// Return user full name for Admin panel
        /// </summary>
        /// <param name="userId">UserId</param>
        /// <returns>String with User full name</returns>
        public async Task<string> UserFullName(string userId)
        {
            var user = await repo.GetByIdAsync<User>(userId);

            return $"{user.FirstName} {user.LastName}".Trim();
        }
    }
}
