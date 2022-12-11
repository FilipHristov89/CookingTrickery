using CookingTrickery.Core.Models.Admin;

namespace CookingTrickery.Core.Contracts.Administration
{
    public interface IUserService
    {
        Task<string> UserFullName(string userId);

        Task<IEnumerable<UserServiceModel>> All();

        Task<bool> Forget(string userId);
    }
}
